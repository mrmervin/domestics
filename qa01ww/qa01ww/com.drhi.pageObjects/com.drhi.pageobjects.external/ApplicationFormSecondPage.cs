
using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using qa01ww.com.drhi.support;
using qa01ww.com.drhi.utils;

namespace qa01ww.com.drhi.pageObjects.com.drhi.pageobjects.external
{
   public  class ApplicationFormSecondPage
   {
       // private string emailId=;
        public void personalDetails()
        {
            //Organisation
            if (Helpers.IsElementPresent(organisationName))
            {
                organisationName.SendKeys("OrganistionNameTest");
                socialLandlordRegistrationNumber.SendKeys("12345");
                var title = new SelectElement(authorisedRepresentativeDetails_SelectedTitle);
                title.SelectByIndex(1);
                authorisedRepresentativeDetails_Name_FirstName.SendKeys("AutomatedTest");
                authorisedRepresentativeDetails_Name_Surname.SendKeys("Qa");
                authorisedRepresentativeDetails_DateOfBirth.SendKeys("10/12/1995");
            }

            //Individual
            if (Helpers.IsElementPresent(applicantDetails_Name_FirstName))
            {
                var title_Dropdown = new SelectElement(applicantDetails_Name_SelectedTitle);
                title_Dropdown.SelectByIndex(1);
                applicantDetails_Name_FirstName.SendKeys("AutomatedTest");
                applicantDetails_Name_Surname.SendKeys("Qa");
                applicantDetails_DateOfBirth.SendKeys("10/12/1995");
            }

            //Enter email id
            if (Helpers.IsElementPresent(contactDetails_EmailAddress))
            {
                var emailaddress = "random" + Helpers.generateRandom(10000, 100000) + "@test.com";
                contactDetails_EmailAddress.SendKeys(emailaddress);
                   
                contactDetails_ConfirmationEmailAddress.SendKeys(emailaddress);
                contactDetails_ContactNumber.SendKeys("07570000000");
                btnPDcontinue.SendKeys(Keys.Enter);
                
            }
            else
            {
                contactDetails_ContactNumber.SendKeys("07570000000");
            }

        }

        public void enterPassword()

        {
            if (Helpers.IsElementPresent(password))
            {
                password.SendKeys(ConfigurationManager.AppSettings["admin.password"]);
                confirmPassword
                    .SendKeys(ConfigurationManager.AppSettings["admin.password"]);
                btnCreatePwd.SendKeys(Keys.Enter);
            }
        }

        public void addressDetails()
        {
            heatingSystemAddressPostcodeLookupTxt.SendKeys("AB12 3CD");
            Helpers.explicitWait(AppDriver.Driver, "heatingSystemAddressPostcodeLookupBtn");
            heatingSystemAddressPostcodeLookupBtn.SendKeys(Keys.Enter);
            var addressDropdown =
                new SelectElement(heatingSystemAddressPostcodeLookupDdl);
            Helpers.explicitWait(AppDriver.Driver, "heatingSystemAddressPostcodeLookupDdl");
            addressDropdown.SelectByIndex(1);

            if (Helpers.IsElementPresent(organisationAddressPostcodeLookupTxt))
            {
                organisationAddressPostcodeLookupTxt.SendKeys("AB12 3CD");
                organisationAddressPostcodeLookupBtn.SendKeys(Keys.Enter);

                var organisationAddress = new SelectElement(organisationAddressPostcodeLookupDdl);
                Helpers.explicitWait(AppDriver.Driver, "organisationAddressPostcodeLookupDdl");
                organisationAddress.SelectByIndex(1);
                homeAddressPostcodeLookupTxt.SendKeys("AB12 3CD");
                homeAddressPostcodeLookupBtn.SendKeys(Keys.Enter);
                var represenativeHomeAddress = new SelectElement(homeAddressPostcodeLookupDdl);
                Helpers.explicitWait(AppDriver.Driver, "homeAddressPostcodeLookupDdl");
                represenativeHomeAddress.SelectByIndex(1);
            }

            if (Helpers.IsElementPresent(btnADcontinue))
            {
                btnADcontinue.SendKeys(Keys.Enter);
            }

        }

        public void epcRecommendations()
        {
            if (Helpers.IsElementPresent(AdditionalEPCQuestionsModel_HasPermittedExemption_True))
            {
                AdditionalEPCQuestionsModel_HasPermittedExemption_True.clickOnIt();
                if (Helpers.IsElementPresent(LoftInsulationNotInstalledReason))
                {
                    SelectElement LoftInsulationDrpdown = new SelectElement(LoftInsulationNotInstalledReason);
                    LoftInsulationDrpdown.SelectByIndex(1);
                }

                if (Helpers.IsElementPresent(CavityWallInsulationNotInstalledReason))
                {
                    SelectElement CavityWallInsulationDrpDown =
                        new SelectElement(CavityWallInsulationNotInstalledReason);
                    CavityWallInsulationDrpDown.SelectByIndex(1);
                }

                if (Helpers.IsElementPresent(btnAdditionalEPCQuestionsContinue))
                {
                    btnAdditionalEPCQuestionsContinue.Click();
                }
            }
           
        }

       internal void submitForm()
       {
         btnSaveContinue.Submit();
       }

       public void meteringForPayment()
        {
            if (Helpers.IsElementPresent(ShowMeteringSection))
            {
                if (Helpers.IsElementPresent(metering_SourcePumpMeteringQuestions_HasMeteringInformation_True))
                {
                    {
                        metering_SourcePumpMeteringQuestions_HasMeteringInformation_True
                            .SendKeys(Keys.Space);
                    }

                    metering_SourcePumpMeteringQuestions_InstallationCompanyName
                        .SendKeys("CompanyName");
                    metering_SourcePumpMeteringQuestions_InstallerMcsNumber
                        .SendKeys("123455");


                    if (Helpers.IsElementPresent(metering_SourcePumpMeteringQuestions_HasDefrostMechanism_False))
                    {
                        metering_SourcePumpMeteringQuestions_HasDefrostMechanism_FalseID
                            .SendKeys(Keys.Space);
                        metering_SourcePumpMeteringQuestions_MetersMeasureOutputFromRHIPumpOnly_False
                            .SendKeys(Keys.Space);
                    }
                    else if
                    (Helpers.IsElementPresent(
                        metering_SourcePumpMeteringQuestions_MetersMeasureOutputFromRHIPumpOnly_False))
                    {
                        metering_SourcePumpMeteringQuestions_MetersMeasureOutputFromRHIPumpOnly_False
                            .SendKeys(Keys.Space);
                    }
                }


                //Biomass 
                if (Helpers.IsElementPresent(metering_BiomassMeteringQuestions_HasMeteringInformation_True))
                {
                    metering_BiomassMeteringQuestions_HasMeteringInformation_True
                        .SendKeys(Keys.Space);
                    metering_BiomassMeteringQuestions_InstallationCompanyName
                        .SendKeys("CompanyName");
                    metering_BiomassMeteringQuestions_InstallerMcsNumber
                        .SendKeys("123455");

                    if (Helpers.IsElementPresent(metering_BiomassMeteringQuestions_SelectedBiomassType_Stove))
                    {
                        metering_BiomassMeteringQuestions_SelectedBiomassType_Stove
                            .SendKeys(Keys.Space);
                        metering_BiomassMeteringQuestions_MetersForBiomassOnly_False
                            .SendKeys(Keys.Space);
                    }
                }
            }

            if (Helpers.IsElementPresent(btnMeteringContinue))
            {
                btnMeteringContinue.SendKeys(Keys.Enter);
            }

        }

        internal void clickNoForIMQS()
        {
           
                if (Helpers.IsElementPresent(btnMeteringForPaymentChangeLink))
                {
                    btnMeteringForPaymentChangeLink.Click();
                }

                if (Helpers.IsElementPresent(Metering_SourcePumpMeteringQuestions_HasMeteringInformation_False))
                {
                    Metering_SourcePumpMeteringQuestions_HasMeteringInformation_False.SendKeys(Keys.Space);
                }

                if (Helpers.IsElementPresent(Metering_BiomassMeteringQuestions_HasMeteringInformation_False))
                {
                    Metering_BiomassMeteringQuestions_HasMeteringInformation_False.clickOnIt();
                }
            
        }

       public bool clickNoForEpc()
       {
           if (Helpers.IsElementPresent(AdditionalEPCQuestionsModel_HasPermittedExemption_True))
           {
               if (Helpers.IsElementDisplayedandEnabled(btnAdditionalEPCQuestionsChangeLink))
               {
                   btnAdditionalEPCQuestionsChangeLink.clickOnIt();
               }
               AdditionalEPCQuestionsModel_HasPermittedExemption_False.SendKeys(Keys.Space);
           }

           return !Helpers.IsElementPresent(AdditionalEPCQuestionsModel_HasPermittedExemption_True) ? false : true;

       }

        public void meteringForPerformanceFalse()
        {
            if (Helpers.IsElementDisplayedandEnabled(meteringForPerformanceSection))
            {
                MeteringForPerformanceAnswerViewModel_HasDeclaredToHaveAnElectricMeterInstalled_False
                     .SendKeys(Keys.Space);
                if (Helpers.IsElementDisplayedandEnabled(btnMeteringForPerformanceContinue))
                {
                    btnMeteringForPerformanceContinue.SendKeys(Keys.Enter);
                }
            }
        }

       public bool meteringForPerformanceDisplayed()
       {
           if (Helpers.IsElementDisplayedandEnabled(meteringForPerformanceSection))
           {
               return true;
           }

           return false;
       }

        public void meteringAndMonitoring_Yes()
       {
           Helpers.explicitWait(AppDriver.Driver, "btnMeteringAndMonitoringChangeLink");
           btnMeteringAndMonitoringChangeLink.Click();
           meteringAndMonitoringQuestions_HasMeteringAndMonitoringPackageInstalled_True.SendKeys(Keys.Space);
           meteringAndMonitoringQuestions_ServiceProviderName.SendKeys("ProviderName");
           MeteringAndMonitoringQuestionsServicePackageStartDate.SendKeys("10/03/1980");
           MeteringAndMonitoringQuestions_ServiceProviderContactNo.SendKeys("07579877878");
           MeteringAndMonitoringQuestions_ServiceProviderEmail.SendKeys("a@a.com");
           MeteringAndMonitoringQuestions_ServiceProviderReferenceNo.SendKeys("123");
           btnMeteringAndMonitoringContinue.SendKeys(Keys.Enter);
       }

        public void meteringAndMonitoring_Section()
        {
            if (Helpers.IsElementPresent(meteringAndMonitoringSection))
            {
                if (Helpers.IsElementDisplayedandEnabled(btnMeteringAndMonitoringChangeLink))
                {
                    btnMeteringAndMonitoringChangeLink.Click();
                }
                meteringAndMonitoringQuestions_HasMeteringAndMonitoringPackageInstalled_False
                    .SendKeys(Keys.Space);
            }

            if (Helpers.IsElementPresent(btnMeteringAndMonitoringContinue))
            {
                btnMeteringAndMonitoringContinue.SendKeys(Keys.Enter);
            }

        }

        public void surveyQuestions()
        {
            deccSurvey_TotalSystemCost.SendKeys("1000");
            deccSurvey_InstallationCost.SendKeys("1000");
            deccSurvey_EquipmentCost.SendKeys("1000");
            var propDropDown =
                new SelectElement(deccSurvey_SelectedPreviousSystem);
            propDropDown.SelectByIndex(2);
            var fuelDropDown =
                new SelectElement(deccSurvey_SelectedPreviousSystemFuel);
            fuelDropDown.SelectByIndex(2);
            if (Helpers.IsElementPresent(btnDeccSurveyContinue))
                btnDeccSurveyContinue.SendKeys(Keys.Enter);
            
        }

        public void bankAccountDetails()
        {
            if (Helpers.IsElementDisplayedandEnabled(bankDetailsSection))
            {
                var bankDetailsDropDown =
                    new SelectElement(bankAccountDetails_BankName);
                bankDetailsDropDown.SelectByValue("BankOfEngland");
                bankAccountDetails_AccountNumber.SendKeys("12345678");
                bankAccountDetails_SortCode.SendKeys("123456");
            }

            if (Helpers.IsElementDisplayedandEnabled(btnBankDetailsContinue))
            {
                BankAccountDetails_VerifyBankDetailsAreCorrectId
                    .SendKeys(Keys.Space);
                btnBankDetailsContinue.SendKeys(Keys.Enter);
            }
        }

        public void declaration()
        {
            termsAndConditions_AcceptTermsAndConditions.SendKeys(Keys.Space);

        }

        #region Page elements

        [FindsBy(How = How.Id, Using = "unsuccessfulMessage")]
        private IWebElement unsuccessfulMessage { get; set; }

        [FindsBy(How = How.Id, Using = "Metering_BiomassMeteringQuestions_HasMeteringInformation_False")]
        private IWebElement Metering_BiomassMeteringQuestions_HasMeteringInformation_False { get; set; }

        [FindsBy(How = How.Id, Using = "Metering_SourcePumpMeteringQuestions_HasMeteringInformation_False")]
        private IWebElement Metering_SourcePumpMeteringQuestions_HasMeteringInformation_False { get; set; }

        [FindsBy(How = How.Id, Using = "ShowMeteringSection")]
        private IWebElement IsEligibleForMetering { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='meteringSection']/div/div[2]/span/a/span")]
        private IWebElement btnMeteringForPaymentChangeLink { get; set; }

        [FindsBy(How = How.Id, Using = "btnMeteringAndMonitoringChangeLink")]
        private IWebElement btnMeteringAndMonitoringChangeLink { get; set; }

        [FindsBy(How = How.Id, Using = "MeteringAndMonitoringQuestions_ServiceProviderName")]
        private IWebElement meteringAndMonitoringQuestions_ServiceProviderName { get; set; }

        [FindsBy(How = How.Id, Using = "MeteringAndMonitoringQuestions_ServiceProviderEmail")]
        private IWebElement MeteringAndMonitoringQuestions_ServiceProviderEmail { get; set; }

        [FindsBy(How = How.Id, Using = "MeteringAndMonitoringQuestions_ServiceProviderReferenceNo")]
        private IWebElement MeteringAndMonitoringQuestions_ServiceProviderReferenceNo { get; set; }

        [FindsBy(How = How.Id, Using = "MeteringAndMonitoringQuestions_ServiceProviderContactNo")]
        private IWebElement MeteringAndMonitoringQuestions_ServiceProviderContactNo { get; set; }

        [FindsBy(How = How.Name, Using = "MeteringAndMonitoringQuestions.ServicePackageStartDate")]
        private IWebElement MeteringAndMonitoringQuestionsServicePackageStartDate { get; set; }

        [FindsBy(How = How.Id, Using = "UsedOwnMoney_No")]
        private IWebElement UsedOwnMoney_No { get; set; }

        [FindsBy(How = How.Id, Using = "urir-span")]
        private IWebElement UrirFieldError { get; set; }

        [FindsBy(How = How.Id, Using = "WithInvestor_False")]
        private IWebElement withInvestor_False { get; set; }

        [FindsBy(How = How.Id, Using = "URIR")]
        private IWebElement textBoxURIR { get; set; }

        [FindsBy(How = How.Id, Using = "WithInvestor_True")]
        private IWebElement withInvestor_True { get; set; }

        [FindsBy(How = How.Id, Using = "with-investor-span")]
        public IWebElement withInvestorQuestion { get; set; }

        [FindsBy(How = How.Id, Using = "signInBtn")]
        private IWebElement btn_signIn { get; set; }

        [FindsBy(How = How.Id, Using = "MCSLetter")]
        private IWebElement mcsletter { get; set; }

        [FindsBy(How = How.Id, Using = "MeteredForPayment_True")]
        private IWebElement meteredForPaymentTrue { set; get; }

        [FindsBy(How = How.Id, Using = "DaysOccupiedFor")]
        private IWebElement daysOccupied { set; get; }

        [FindsBy(How = How.Id, Using = "MeteredForPayment_False")]
        private IWebElement meteredForPaymentFalse { get; set; }

        [FindsBy(How = How.Id, Using = "signInBtn")]
        private IWebElement signInBtn { get; set; }

        [FindsBy(How = How.Id, Using = "HeatingSystemOwner_SoleOwner")]
        private IWebElement heatingSystemSoleOwner { get; set; }

        [FindsBy(How = How.Id, Using = "EPCRRNBox1")]
        private IWebElement epc1 { get; set; }

        [FindsBy(How = How.Id, Using = "EPCRRNBox2")]
        private IWebElement epc2 { get; set; }

        [FindsBy(How = How.Id, Using = "EPCRRNBox3")]
        private IWebElement epc3 { get; set; }

        [FindsBy(How = How.Id, Using = "EPCRRNBox4")]
        private IWebElement epc4 { get; set; }

        [FindsBy(How = How.Id, Using = "EPCRRNBox5")]
        private IWebElement epc5 { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicantCategory_Individual")]
        private IWebElement applicantCategoryIndividual { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicantType_OwnerOccupier")]
        private IWebElement applicantTypeOwnerOccupier { get; set; }

        [FindsBy(How = How.Id, Using = "MCSNumber")]
        private IWebElement mcsNumber { get; set; }

        [FindsBy(How = How.Id, Using = "MultipleMCS_False")]
        private IWebElement multipleMcsFalse { get; set; }

        [FindsBy(How = How.Id, Using = "UsedOwnMoney_Yes")]
        private IWebElement usedOwnMoneyYes { get; set; }

        [FindsBy(How = How.Id, Using = "AdditionalFunding_No")]
        private IWebElement additionalFundingNo { get; set; }

        [FindsBy(How = How.Id, Using = "DeclaredSystemCheckBoxes_HotWater")]
        private IWebElement declaredSystemCheckBoxesHotWater { get; set; }

        [FindsBy(How = How.Id, Using = "PropertiesPerHeatingSystem_Single")]
        private IWebElement propertiesHeatingSystemSingle { get; set; }

        [FindsBy(How = How.Id, Using = "HeatingSystemInstalledAfterOccupation_True")]
        private IWebElement heatingSystemInstalledTrue { get; set; }

        [FindsBy(How = How.Id, Using = "PropertyCountry_Scotland")]
        private IWebElement propertyCountryScotland { get; set; }

        [FindsBy(How = How.Id, Using = "btnStartApplication")]
        private IWebElement btnStartApplication { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicantDetails_Name_FirstName")]
        private IWebElement applicantDetails_Name_FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicantDetails_Name_Surname")]
        private IWebElement applicantDetails_Name_Surname { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicantDetails_DateOfBirth_DateOfBirth")]
        private IWebElement applicantDetails_DateOfBirth { get; set; }

        [FindsBy(How = How.Id, Using = "ContactDetails_EmailAddress")]
        private IWebElement contactDetails_EmailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "ContactDetails_ConfirmationEmailAddress")]
        private IWebElement contactDetails_ConfirmationEmailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "ContactDetails_ContactNumber")]
        private IWebElement contactDetails_ContactNumber { get; set; }

        [FindsBy(How = How.Id, Using = "btnPDcontinue")]
        private IWebElement btnPDcontinue { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "ConfirmPassword")]
        private IWebElement confirmPassword { get; set; }

        [FindsBy(How = How.Id, Using = "btnCreatePwd")]
        private IWebElement btnCreatePwd { get; set; }

        [FindsBy(How = How.Id, Using = "heatingSystemAddressPostcodeLookupTxt")]
        private IWebElement heatingSystemAddressPostcodeLookupTxt { get; set; }

        [FindsBy(How = How.Id, Using = "heatingSystemAddressPostcodeLookupBtn")]
        private IWebElement heatingSystemAddressPostcodeLookupBtn { get; set; }

        [FindsBy(How = How.Id, Using = "heatingSystemAddressPostcodeLookupDdl")]
        private IWebElement heatingSystemAddressPostcodeLookupDdl { get; set; }

        [FindsBy(How = How.Id, Using = "btnADcontinue")]
        private IWebElement btnADcontinue { get; set; }

        [FindsBy(How = How.Id, Using = "Metering_SourcePumpMeteringQuestions_HasMeteringInformation_True")]
        private IWebElement metering_SourcePumpMeteringQuestions_HasMeteringInformation_True { get; set; }

        [FindsBy(How = How.Id, Using = "ShowMeteringSection")]
        private IWebElement ShowMeteringSection { get; set; }

        [FindsBy(How = How.Id, Using = "Metering_SourcePumpMeteringQuestions_InstallationCompanyName")]
        private IWebElement metering_SourcePumpMeteringQuestions_InstallationCompanyName { get; set; }

        [FindsBy(How = How.Id, Using = "Metering_SourcePumpMeteringQuestions_InstallerMcsNumber")]
        private IWebElement metering_SourcePumpMeteringQuestions_InstallerMcsNumber { get; set; }

        [FindsBy(How = How.CssSelector,
            Using = "#heatpumpMeteringQuestions_hasDefrostMechanism > fieldset > div > span:nth-child(1) > label")]
        private IWebElement metering_SourcePumpMeteringQuestions_HasDefrostMechanism_False { get; set; }

        [FindsBy(How = How.Id, Using = "Metering_SourcePumpMeteringQuestions_HasDefrostMechanism_False")]
        private IWebElement metering_SourcePumpMeteringQuestions_HasDefrostMechanism_FalseID { get; set; }

        [FindsBy(How = How.Id, Using = "Metering_SourcePumpMeteringQuestions_MetersMeasureOutputFromRHIPumpOnly_False")]
        private IWebElement metering_SourcePumpMeteringQuestions_MetersMeasureOutputFromRHIPumpOnly_False { get; set; }

        [FindsBy(How = How.Id, Using = "Metering_BiomassMeteringQuestions_SelectedBiomassType_Stove")]
        private IWebElement metering_BiomassMeteringQuestions_SelectedBiomassType_Stove { get; set; }

        [FindsBy(How = How.Id, Using = "Metering_BiomassMeteringQuestions_MetersForBiomassOnly_False")]
        private IWebElement metering_BiomassMeteringQuestions_MetersForBiomassOnly_False { get; set; }

        [FindsBy(How = How.Id, Using = "btnMeteringContinue")]
        private IWebElement btnMeteringContinue { get; set; }

        [FindsBy(How = How.Id, Using = "meteringAndMonitoringSection")]
        private IWebElement meteringAndMonitoringSection { get; set; }

        [FindsBy(How = How.Id, Using = "MeteringAndMonitoringQuestions_HasMeteringAndMonitoringPackageInstalled_True")]
        private IWebElement meteringAndMonitoringQuestions_HasMeteringAndMonitoringPackageInstalled_True { get; set; }


        [FindsBy(How = How.Id, Using = "MeteringAndMonitoringQuestions_HasMeteringAndMonitoringPackageInstalled_False")]
        private IWebElement meteringAndMonitoringQuestions_HasMeteringAndMonitoringPackageInstalled_False { get; set; }


        [FindsBy(How = How.Id, Using = "btnMeteringAndMonitoringContinue")]
        private IWebElement btnMeteringAndMonitoringContinue { get; set; }

        [FindsBy(How = How.Id, Using = "Metering_BiomassMeteringQuestions_HasMeteringInformation_True")]
        private IWebElement metering_BiomassMeteringQuestions_HasMeteringInformation_True { get; set; }

        [FindsBy(How = How.Id, Using = "Metering_BiomassMeteringQuestions_InstallationCompanyName")]
        private IWebElement metering_BiomassMeteringQuestions_InstallationCompanyName { get; set; }

        [FindsBy(How = How.Id, Using = "DeccSurvey_TotalSystemCost")]
        private IWebElement deccSurvey_TotalSystemCost { get; set; }

        [FindsBy(How = How.Id, Using = "DeccSurvey_InstallationCost")]
        private IWebElement deccSurvey_InstallationCost { get; set; }

        [FindsBy(How = How.Id, Using = "DeccSurvey_SelectedPreviousSystemFuel")]
        private IWebElement deccSurvey_SelectedPreviousSystemFuel { get; set; }

        [FindsBy(How = How.Id, Using = "DeccSurvey_SelectedPreviousSystem")]
        private IWebElement deccSurvey_SelectedPreviousSystem { get; set; }

        [FindsBy(How = How.Id, Using = "DeccSurvey_EquipmentCost")]
        private IWebElement deccSurvey_EquipmentCost { get; set; }

        [FindsBy(How = How.Id, Using = "btnDeccSurveyContinue")]
        private IWebElement btnDeccSurveyContinue { get; set; }

        [FindsBy(How = How.Id, Using = "BankAccountDetails_AccountNumber")]
        private IWebElement bankAccountDetails_AccountNumber { get; set; }

        [FindsBy(How = How.Id, Using = "btnBankDetailsContinue")]
        private IWebElement btnBankDetailsContinue { get; set; }

        [FindsBy(How = How.Id, Using = "BankAccountDetails_SortCode")]
        private IWebElement bankAccountDetails_SortCode { get; set; }

        [FindsBy(How = How.Id,
            Using = "BankAccountDetails_VerifyBankDeatilsAreCorrect")]
        private IWebElement BankAccountDetails_VerifyBankDeatilsAreCorrect { get; set; }

        [FindsBy(How = How.Id, Using = "BankAccountDetails_VerifyBankDetailsAreCorrect")]
        private IWebElement BankAccountDetails_VerifyBankDetailsAreCorrectId { get; set; }

        [FindsBy(How = How.Id, Using = "TermsAndConditions_AcceptTermsAndConditions")]
        private IWebElement termsAndConditions_AcceptTermsAndConditions { get; set; }

        [FindsBy(How = How.Id, Using = "btnSaveContinue")]
        private IWebElement btnSaveContinue { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicantDetails_Name_SelectedTitle")]
        private IWebElement applicantDetails_Name_SelectedTitle { get; set; }

        [FindsBy(How = How.Id, Using = "bankDetailsSection")]
        private IWebElement bankDetailsSection { get; set; }

        [FindsBy(How = How.Id, Using = "BankAccountDetails_BankName")]
        private IWebElement bankAccountDetails_BankName { get; set; }

        [FindsBy(How = How.ClassName, Using = "page-title")]
        private IWebElement pageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='IneligibiltyReasons']/div/div/div/div/p[2]")]
        private IWebElement IneligibilityReason { get; set; }

        [FindsBy(How = How.Id, Using = "Metering_BiomassMeteringQuestions_InstallerMcsNumber")]
        private IWebElement metering_BiomassMeteringQuestions_InstallerMcsNumber { get; set; }

        [FindsBy(How = How.Id, Using = "meteringForPerformanceSection")]
        private IWebElement meteringForPerformanceSection { get; set; }

        [FindsBy(How = How.Id, Using = "MeteringForPerformanceAnswerViewModel_HasDeclaredToHaveAnElectricMeterInstalled_False")]
        private IWebElement MeteringForPerformanceAnswerViewModel_HasDeclaredToHaveAnElectricMeterInstalled_False { get; set; }

        [FindsBy(How = How.Id, Using = "MeteringForPerformanceAnswerViewModel_HasDeclaredToHaveAnElectricMeterInstalled_True")]
        private IWebElement MeteringForPerformanceAnswerViewModel_HasDeclaredToHaveAnElectricMeterInstalled_True { get; set; }

        [FindsBy(How = How.Id, Using = "btnMeteringForPerformanceContinue")]
        private IWebElement btnMeteringForPerformanceContinue { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicantCategory_Organisation")]
        private IWebElement applicantCategory_Organisation { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicantType_LocalAuthority")]
        private IWebElement applicantType_LocalAuthority { get; set; }

        [FindsBy(How = How.Id, Using = "OrganisationName")]
        private IWebElement organisationName { get; set; }

        [FindsBy(How = How.Id, Using = "SocialLandlordRegistrationNumber")]
        private IWebElement socialLandlordRegistrationNumber { get; set; }

        [FindsBy(How = How.Id, Using = "PropertyOwnership_OwnOccupy")]
        private IWebElement propertyOwnership_OwnOccupy { get; set; }

        [FindsBy(How = How.Id, Using = "AuthorisedRepresentativeDetails_Name_FirstName")]
        private IWebElement authorisedRepresentativeDetails_Name_FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "AuthorisedRepresentativeDetails_Name_Surname")]
        private IWebElement authorisedRepresentativeDetails_Name_Surname { get; set; }

        [FindsBy(How = How.Id, Using = "AuthorisedRepresentativeDetails_Name_SelectedTitle")]
        private IWebElement authorisedRepresentativeDetails_SelectedTitle { get; set; }

        [FindsBy(How = How.Id, Using = "AuthorisedRepresentativeDetails_DateOfBirth_DateOfBirth")]
        private IWebElement authorisedRepresentativeDetails_DateOfBirth { get; set; }

        [FindsBy(How = How.Id, Using = "organisationAddressPostcodeLookupTxt")]
        private IWebElement organisationAddressPostcodeLookupTxt { get; set; }

        [FindsBy(How = How.Id, Using = "homeAddressPostcodeLookupTxt")]
        private IWebElement homeAddressPostcodeLookupTxt { get; set; }

        [FindsBy(How = How.Id, Using = "organisationAddressPostcodeLookupBtn")]
        private IWebElement organisationAddressPostcodeLookupBtn { get; set; }

        [FindsBy(How = How.Id, Using = "homeAddressPostcodeLookupBtn")]
        private IWebElement homeAddressPostcodeLookupBtn { get; set; }

        [FindsBy(How = How.Id, Using = "homeAddressPostcodeLookupDdl")]
        private IWebElement homeAddressPostcodeLookupDdl { get; set; }

        [FindsBy(How = How.Id, Using = "organisationAddressPostcodeLookupDdl")]
        private IWebElement organisationAddressPostcodeLookupDdl { get; set; }

        [FindsBy(How = How.Id, Using = "AdditionalEPCQuestionsModel_HasPermittedExemption_True")]
        private IWebElement AdditionalEPCQuestionsModel_HasPermittedExemption_True { get; set; }

        [FindsBy(How = How.Id, Using = "AdditionalEPCQuestionsModel_HasPermittedExemption_False")]
        private IWebElement AdditionalEPCQuestionsModel_HasPermittedExemption_False { get; set; }

        [FindsBy(How = How.Id, Using = "LoftInsulationNotInstalledReason")]
        private IWebElement LoftInsulationNotInstalledReason { get; set; }

        [FindsBy(How = How.Id, Using = "CavityWallInsulationNotInstalledReason")]
        private IWebElement CavityWallInsulationNotInstalledReason { get; set; }

        [FindsBy(How = How.Id, Using = "btnAdditionalEPCQuestionsContinue")]
        private IWebElement btnAdditionalEPCQuestionsContinue { get; set; }

        [FindsBy(How = How.Id, Using = "PropertyCountry_England")]
        private IWebElement PropertyCountry_England { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#additionalEPCQuestionsSection > div > div.summary-content > span > a > span")]
        private IWebElement btnAdditionalEPCQuestionsChangeLink { get; set; }


        #endregion
    }
}
