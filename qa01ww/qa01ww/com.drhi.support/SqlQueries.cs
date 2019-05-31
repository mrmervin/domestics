using System;
using System.Data.Common;

namespace qa01ww.com.drhi.support
{
    public class SqlQueries
    {
        private static string savedRegulationDate;


        public static void deleteThirdPartyList()
        {
            var deleteThirdPartyStatus
                = "Delete  FROM [RHI_Domestics].[dbo].[ThirdPartyStatus] where ThirdPartyStatusId IN (select top 4 ThirdPartyStatusId from [RHI_Domestics].[dbo].[ThirdPartyStatus] order by ThirdPartyStatusId desc)";
            var deleteThirdPartyInstaller =
                "Delete  FROM [RHI_Domestics].[dbo].[ThirdPartyInstaller] where ThirdPartyInstallerId IN (select top 1 ThirdPartyInstallerId from [RHI_Domestics].[dbo].[ThirdPartyInstaller] order by ThirdPartyInstallerId desc)";

            Helpers.connectingDB(deleteThirdPartyStatus, "Dbconnection");
            Helpers.connectingDB(deleteThirdPartyInstaller, "Dbconnection");
        }

        internal static void cleanBulkDeclarationsNotCreatedToday()
        {
            var cleanBulkDeclarations = "update[dbo].[AnnualDeclarations] set[Status] = 0" +
                                        " where[AnnualDeclarationId] in (SELECT Adec.AnnualDeclarationId FROM RHIApplication AS R WITH(NOLOCK) INNER JOIN HeatingSystem AS HS WITH(NOLOCK) ON r.HeatingSystemID = HS.HeatingSystemID AND HS.McsTechnologyTypeId != 3" +
                                        " INNER JOIN(SELECT Max(DueDate) as maxDate,RhiApplicationId FROM AnnualDeclarations AS AD WITH(NOLOCK)" +
                                        "WHERE DueDate <=getDate()  GROUP BY RhiApplicationId) AS subQuery ON r.RHIApplicationID = subQuery.RHIApplicationID" +
                                        " INNER JOIN AnnualDeclarations AS Adec WITH(NOLOCK) ON subQuery.RhiApplicationId = Adec.RhiApplicationId AND Adec.DueDate = subQuery.maxDate INNER JOIN ApplicationStatus AS APS " +
                                        "  ON APS.RhiApplicationId = R.RHIApplicationID INNER JOIN[ApplicationStatusType] AS AST ON APS.ApplicationStatusTypeId = ast.ApplicationStatusTypeId WHERE APS.Timestamp = (SELECT MAX(ST.Timestamp)" +
                                        "FROM ApplicationStatus AS ST WHERE ST.RhiApplicationId = R.RHIApplicationID) AND APS.ApplicationStatusTypeId in (1) AND Adec.Status = 1 AND Adec.IsTransferred = 0 AND R.SubmittedDate <DATEADD(day,-1,GETDATE()))";
            Helpers.connectingDB(cleanBulkDeclarations, "DbConnection");
        }

        public static void changeApplicationStatus(int statusType)
        {
            Helpers.connectingDB(
                "update[RHI_Domestics].[dbo].[ApplicationStatus] set ApplicationStatusTypeId =" + statusType +
                " where RhiApplicationId in (select top 1 RHIApplicationID from[RHI_Domestics].[dbo].[RHIApplication] order by RHIApplicationID  desc)",
                "DbConnection");
        }

        public static string retrieveLastApplicationEmailId()
        {
            var result =
                Helpers.connectingDB(
                    "select top 1 EmailAddress from  [RHI_Domestics].[dbo].[Person] order by PersonID  desc",
                    "DbConnection");

            return result;
        }

        public static string retrieveLastApplicationrhiNumber()
        {
            var rhiNumber = Helpers.connectingDB("  select top 1 r.RHINumber from  [RHI_Domestics].[dbo].[Person] as p  Join [RHI_Domestics].[dbo].[RHIApplication] as r on p.PersonID=r.PersonId  order by p.PersonID  desc ", "DbConnection");

            return rhiNumber;
        }

        public static string getRowResult(int row)
        {
            var result =
                Helpers.connectingDB(
                  string.Format ("SELECT * FROM (SELECT t.EmailAddress, ROW_NUMBER() OVER(ORDER BY PersonID DESC) AS RowNumber FROM[RHI_Domestics].[dbo].[Person] t) AS tmp" + 
           " WHERE RowNumber = {0}",row),
                    "DbConnection");

            return result;
        }

        public static void deleteCpiUpdates()
        {
            Helpers.connectingDB("DELETE [RHI_Domestics].[dbo].[CpiUpdate] ", "DbConnection");
        }

        public static void updateAnnualdeclaration()
        {
            var updateDuedate1 =
                "Update top (1) [RHI_Domestics].[dbo].[AnnualDeclarations] set DueDate =  DATEADD(d,DATEDIFF(d,0,getdate()),0) where RhiApplicationId in (select top 1 RHIApplicationID from[RHI_Domestics].[dbo].[RHIApplication] order by RHINumber desc)";
            Helpers.connectingDB(updateDuedate1, "DbConnection");
        }

        internal static void updateIsMMSPeligible_True()
        {
            var updateIsMMSPEligible_True = "UPDATE [dbo].[McsProductEligibility] SET[IsMMSPEligible] = 1";
            Helpers.connectingDB(updateIsMMSPEligible_True, "Dbconnection");
        }
         
        public static void getRegulationDateAndSetItToToday()
        {
            savedRegulationDate = Helpers.connectingDB(
                "select [Value] From [RHI_Domestics].[dbo].[BusinessParametersConfig]" +
                "where [Key]='RegChanges2017PartTwo'", "DbConnection");
            Helpers.connectingDB("update [RHI_Domestics].[dbo].[BusinessParametersConfig] set"
                                 + " [Value]= Format(GETDATE(), 'dd/MM/yyyy hh:mm:s ') where[Key] = 'RegChanges2017PartTwo'",
                "DbConnection");
        }

        public static void updateToSavedRequlationDate()
        {
            Helpers.connectingDBwithParameter(
                "Update [RHI_Domestics].[dbo].[BusinessParametersConfig] set [Value]=@regulationDate where[Key] = 'RegChanges2017PartTwo'",
                "DbConnection", savedRegulationDate);
        }
    }
}
