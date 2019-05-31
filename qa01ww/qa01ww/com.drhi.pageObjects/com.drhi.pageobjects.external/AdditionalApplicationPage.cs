using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using qa01ww.com.drhi.support;
using qa01ww.com.drhi.utils;

namespace qa01ww.com.drhi.pageObjects.com.drhi.pageobjects.external
{
    public class AdditionalApplicationPage
    {
        #region PageElements


        [FindsBy(How = How.Id, Using = "AdditionalEPCQuestionsModel_HasPermittedExemption_True")]
        private IWebElement AdditionalEPCQuestionsModel_HasPermittedExemption_True { get; set; }

        [FindsBy(How = How.ClassName, Using = "page-title")]
        private IWebElement pageTitle { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicationCriteriaViewModel_PropertyCountry_England")]
        private IWebElement ApplicationCriteriaViewModel_PropertyCountry_England { get; set; }

        [FindsBy(How = How.Id, Using = "btnStartApplication")]
        private IWebElement btnStartApplication { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicationCriteriaViewModel_MCSLetter")]
        private IWebElement ApplicationCriteriaViewModel_MCSLetter { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#heatingSystemAddressPostcodeLookupDdl")]
        private IWebElement heatingSystemAddressPostcodeLookupDdl { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#heatingSystemAddressPostcodeLookupBtn")]
        private IWebElement heatingSystemAddressPostcodeLookupBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DeccSurvey_InstallationCost")]
        private IWebElement DeccSurvey_InstallationCost { get; set; }

        [FindsBy(How = How.Id, Using = "changeDetails-any-non-aor")]
        private IWebElement changeBankDetailsBtnNonAOr { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EPCRRNBox1")]
        private IWebElement EPCRRNBox1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EPCRRNBox2")]
        private IWebElement EPCRRNBox2 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EPCRRNBox3")]
        private IWebElement EPCRRNBox3 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EPCRRNBox4")]
        private IWebElement EPCRRNBox4 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EPCRRNBox5")]
        private IWebElement EPCRRNBox5 { get; set; }

        [FindsBy(How = How.CssSelector, Using = " #ApplicationCriteriaViewModel_WithInvestor_False")]
        private IWebElement ApplicationCriteriaViewModel_WithInvestor_False { get; set; }

        [FindsBy(How = How.CssSelector, Using = " #ApplicationCriteriaViewModel_HeatingSystemOwner_SoleOwner")]
        private IWebElement ApplicationCriteriaViewModel_HeatingSystemOwner_SoleOwner { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ApplicationCriteriaViewModel_MCSNumber")]
        private IWebElement ApplicationCriteriaViewModel_MCSNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ApplicationCriteriaViewModel_MultipleMCS_False")]
        private IWebElement ApplicationCriteriaViewModel_MultipleMCS_False { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ApplicationCriteriaViewModel_UsedOwnMoney_Yes")]
        private IWebElement ApplicationCriteriaViewModel_UsedOwnMoney_Yes { get; set; }

        [FindsBy(How = How.CssSelector, Using = " #ApplicationCriteriaViewModel_DeclaredSystemCheckBoxes_SpaceHeating")]
        private IWebElement ApplicationCriteriaViewModel_DeclaredSystemCheckBoxes_SpaceHeating { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ApplicationCriteriaViewModel_AdditionalFunding_No")]
        private IWebElement ApplicationCriteriaViewModel_AdditionalFunding_No { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ApplicationCriteriaViewModel_MeteredForPayment_False")]
        private IWebElement ApplicationCriteriaViewModel_MeteredForPayment_False { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ApplicationCriteriaViewModel_DaysOccupiedFor")]
        private IWebElement ApplicationCriteriaViewModel_DaysOccupiedFor { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ApplicationCriteriaViewModel_PropertiesPerHeatingSystem_Single")]
        private IWebElement ApplicationCriteriaViewModel_PropertiesPerHeatingSystem_Single { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ApplicationCriteriaViewModel_HeatingSystemInstalledAfterOccupation_True")]
        private IWebElement ApplicationCriteriaViewModel_HeatingSystemInstalledAfterOccupation_True { get; set; }

        [FindsBy(How = How.CssSelector, Using = " #LoftInsulationNotInstalledReason")]
        private IWebElement LoftInsulationNotInstalledReason { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CavityWallInsulationNotInstalledReason")]
        private IWebElement CavityWallInsulationNotInstalledReason { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#MeteringForPerformanceAnswerViewModel_HasDeclaredToHaveAnElectricMeterInstalled_False ")]
        private IWebElement MeteringForPerformanceAnswerViewModel_HasDeclaredToHaveAnElectricMeterInstalled_False
        { get; set; }

        [FindsBy(How = How.CssSelector, Using = " #MeteringAndMonitoringQuestions_HasMeteringAndMonitoringPackageInstalled_False")]
        private IWebElement MeteringAndMonitoringQuestions_HasMeteringAndMonitoringPackageInstalled_False { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DeccSurvey_TotalSystemCost")]
        private IWebElement DeccSurvey_TotalSystemCost { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DeccSurvey_EquipmentCost")]
        private IWebElement DeccSurvey_EquipmentCost { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DeccSurvey_SelectedPreviousSystem")]
        private IWebElement DeccSurvey_SelectedPreviousSystem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DeccSurvey_SelectedPreviousSystemFuel")]
        private IWebElement DeccSurvey_SelectedPreviousSystemFuel { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#TermsAndConditions_AcceptTermsAndConditions")]
        private IWebElement TermsAndConditions_AcceptTermsAndConditions { get; set; }

        [FindsBy(How = How.CssSelector, Using = " #btnSaveContinue")]
        private IWebElement btnSaveContinue { get; set; }

        [FindsBy(How = How.CssSelector, Using = " #heatingSystemAddressPostcodeLookupTxt")]
        private IWebElement heatingSystemAddressPostcodeLookupTxt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#please-update-message")]
        private IWebElement pleaseUpdatemessage { get; set; }

        [FindsBy(How = How.Id, Using = "meteringSection")]
        private IWebElement ShowMeteringSection { get; set; }

        [FindsBy(How = How.Id, Using = "biomassMeteringQuestions")]
        private IWebElement biomassMeteringQuestions { get; set; }

        [FindsBy(How = How.CssSelector, Using = "  #Metering_BiomassMeteringQuestions_HasMeteringInformation_True")]
        private IWebElement Metering_BiomassMeteringQuestions_HasMeteringInformation_True { get; set; }

        [FindsBy(How = How.Id, Using = "Metering_SourcePumpMeteringQuestions_HasMeteringInformation_True")]
        private IWebElement metering_SourcePumpMeteringQuestions_HasMeteringInformation_True { get; set; }

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
        private IWebElement Metering_BiomassMeteringQuestions_MetersForBiomassOnly_False { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Metering_BiomassMeteringQuestions_InstallationCompanyName")]
        private IWebElement Metering_BiomassMeteringQuestions_InstallationCompanyName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Metering_BiomassMeteringQuestions_InstallerMcsNumber")]
        private IWebElement Metering_BiomassMeteringQuestions_InstallerMcsNumber { get; set; }
        #endregion

        internal void enterMcsLetter(string technology)
        {
            ApplicationCriteriaViewModel_MCSLetter.SendKeys(technology);
        }

        public void completeFirstPageAdditionalApplication()
        {
            Assert.IsTrue(pageTitle.Text.Contains("Additional application"));
            ApplicationCriteriaViewModel_WithInvestor_False.SendKeys(Keys.Space);
            ApplicationCriteriaViewModel_HeatingSystemOwner_SoleOwner.SendKeys(Keys.Space);
            ApplicationCriteriaViewModel_MCSNumber.SendKeys(Helpers.generateRandom(11111111, 99999999));
            ApplicationCriteriaViewModel_MultipleMCS_False.SendKeys(Keys.Space);
            ApplicationCriteriaViewModel_UsedOwnMoney_Yes.SendKeys(Keys.Space);
            ApplicationCriteriaViewModel_AdditionalFunding_No.SendKeys(Keys.Space);
            ApplicationCriteriaViewModel_MeteredForPayment_False.SendKeys(Keys.Space);
            enterEPCNumber();
            ApplicationCriteriaViewModel_HeatingSystemInstalledAfterOccupation_True.SendKeys(Keys.Space);
            ApplicationCriteriaViewModel_DeclaredSystemCheckBoxes_SpaceHeating.SendKeys(Keys.Space);
            ApplicationCriteriaViewModel_PropertiesPerHeatingSystem_Single.SendKeys(Keys.Space);
            ApplicationCriteriaViewModel_PropertyCountry_England.SendKeys(Keys.Space);
            btnStartApplication.Submit();
        }

        public void createMeteredAdditionalApplication()
        {
            ApplicationCriteriaViewModel_DaysOccupiedFor.SendKeys("18");
        }
        internal void createDeemedAdditionalApplication()
        {
            ApplicationCriteriaViewModel_DaysOccupiedFor.SendKeys("183");
        }

        public void completeSecondPageOfadditionalApplication()
        {
            heatingSystemAddressPostcodeLookupTxt.SendKeys("AB123CD");
            var postcodeLookup = new SelectElement(heatingSystemAddressPostcodeLookupDdl);
            heatingSystemAddressPostcodeLookupBtn.Click();
            Helpers.explicitWait(AppDriver.Driver, "heatingSystemAddressPostcodeLookupDdl");
            postcodeLookup.SelectByIndex(1);
            if (Helpers.IsElementPresent(AdditionalEPCQuestionsModel_HasPermittedExemption_True))
            {
                AdditionalEPCQuestionsModel_HasPermittedExemption_True.clickOnIt();
            }
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

            if (Helpers.IsElementPresent(ShowMeteringSection))
            {
                if (Helpers.IsElementPresent(biomassMeteringQuestions))
                {
                    Metering_BiomassMeteringQuestions_HasMeteringInformation_True
                        .SendKeys(Keys.Space);
                    Metering_BiomassMeteringQuestions_InstallationCompanyName.SendKeys("CompanyName");
                    Metering_BiomassMeteringQuestions_InstallerMcsNumber.SendKeys("123455");
                    metering_BiomassMeteringQuestions_SelectedBiomassType_Stove.SendKeys(Keys.Space);
                    Metering_BiomassMeteringQuestions_MetersForBiomassOnly_False.SendKeys(Keys.Space);
                }

                if (Helpers.IsElementPresent(metering_SourcePumpMeteringQuestions_HasMeteringInformation_True))
                {
                    {
                        metering_SourcePumpMeteringQuestions_HasMeteringInformation_True
                            .SendKeys(Keys.Space);
                        metering_SourcePumpMeteringQuestions_InstallationCompanyName
                            .SendKeys("CompanyName");
                        metering_SourcePumpMeteringQuestions_InstallerMcsNumber
                            .SendKeys("123455");
                    }

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
            }

            if (Helpers.IsElementPresent(
                MeteringForPerformanceAnswerViewModel_HasDeclaredToHaveAnElectricMeterInstalled_False))
            {
                MeteringForPerformanceAnswerViewModel_HasDeclaredToHaveAnElectricMeterInstalled_False.SendKeys(
                    Keys.Space);
            }

            MeteringAndMonitoringQuestions_HasMeteringAndMonitoringPackageInstalled_False.SendKeys(Keys.Space);
            DeccSurvey_TotalSystemCost.SendKeys("100");
            DeccSurvey_InstallationCost.SendKeys("100");
            DeccSurvey_EquipmentCost.SendKeys("100");
            var DeccSurvey_SelectedPreviousSystemdrpdwn = new SelectElement(DeccSurvey_SelectedPreviousSystem);
            DeccSurvey_SelectedPreviousSystemdrpdwn.SelectByIndex(1);
            var DeccSurvey_SelectedPreviousSystemFueldrpdwn =
                new SelectElement(DeccSurvey_SelectedPreviousSystemFuel);
            DeccSurvey_SelectedPreviousSystemFueldrpdwn.SelectByIndex(1);
            TermsAndConditions_AcceptTermsAndConditions.SendKeys(Keys.Space);
        }

        public void submitAdditionalApplication()
        {
            btnSaveContinue.Submit();
        }
        
        public void enterEPCNumber()
        {
            EPCRRNBox1.SendKeys(Helpers.generateRandom(1111, 9999));
            EPCRRNBox2.SendKeys(Helpers.generateRandom(1111, 9999));
            EPCRRNBox3.SendKeys(Helpers.generateRandom(1111, 9999));
            EPCRRNBox4.SendKeys(Helpers.generateRandom(1111, 9999));
            EPCRRNBox5.SendKeys(Helpers.generateRandom(1111, 9999));
        }
    }
}
