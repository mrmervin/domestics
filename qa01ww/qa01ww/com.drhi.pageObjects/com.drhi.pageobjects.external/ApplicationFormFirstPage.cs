using OpenQA.Selenium;
using qa01ww.com.drhi.support;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using Helpers = qa01ww.com.drhi.support.Helpers;

namespace qa01ww.com.drhi.pageObjects
{
    public class ApplicationFormFirstPage
    {
        #region Elements

        [FindsBy(How = How.Id, Using = "urir-span")]
        private IWebElement UrirFieldError { get; set; }

        [FindsBy(How = How.Id, Using = "MultipleMCS_False")]
        private IWebElement multipleMcsFalse { get; set; }

        [FindsBy(How = How.Id, Using = "AdditionalFunding_No")]
        private IWebElement additionalFundingNo { get; set; }

        [FindsBy(How = How.Id, Using = "DeclaredSystemCheckBoxes_HotWater")]
        private IWebElement declaredSystemCheckBoxesHotWater { get; set; }

        [FindsBy(How = How.Id, Using = "PropertiesPerHeatingSystem_Single")]
        private IWebElement propertiesHeatingSystemSingle { get; set; }

        [FindsBy(How = How.Id, Using = "HeatingSystemInstalledAfterOccupation_True")]
        private IWebElement heatingSystemInstalledTrue { get; set; }

        [FindsBy(How = How.Id, Using = "MCSNumber")]
        private IWebElement mcsNumber { get; set; }

        [FindsBy(How = How.Id, Using = "PropertyOwnership_OwnOccupy")]
        private IWebElement propertyOwnership_OwnOccupy { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicantType_LocalAuthority")]
        private IWebElement applicantType_LocalAuthority { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicantType_OwnerOccupier")]
        private IWebElement applicantTypeOwnerOccupier { get; set; }

        [FindsBy(How = How.Id, Using = "HeatingSystemOwner_SoleOwner")]
        private IWebElement heatingSystemSoleOwner { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicantCategory_Individual")]
        private IWebElement applicantCategoryIndividual { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicantCategory_Organisation")]
        private IWebElement applicantCategory_Organisation { get; set; }


        [FindsBy(How = How.Id, Using = "PropertyCountry_Scotland")]
        private IWebElement propertyCountryScotland { get; set; }

        [FindsBy(How = How.Id, Using = "btnStartApplication")]
        private IWebElement btnStartApplication { get; set; }

        [FindsBy(How = How.Id, Using = "PropertyCountry_England")]
        private IWebElement PropertyCountry_England { get; set; }

        [FindsBy(How = How.Id, Using = "EPCRRNBox1")]
        private IWebElement epc1 { get; set; }

        [FindsBy(How = How.Id, Using = "WithInvestor_False")]
        private IWebElement withInvestor_False { get; set; }

        [FindsBy(How = How.Id, Using = "URIR")]
        private IWebElement textBoxURIR { get; set; }

        [FindsBy(How = How.Id, Using = "WithInvestor_True")]
        public IWebElement withInvestor { get; set; }

        [FindsBy(How = How.Id, Using = "UsedOwnMoney_Yes")]
        private IWebElement usedOwnMoneyYes { get; set; }

        [FindsBy(How = How.Id, Using = "UsedOwnMoney_No")]
        private IWebElement UsedOwnMoney_No { get; set; }

        [FindsBy(How = How.Id, Using = "MeteredForPayment_True")]
        private IWebElement meteredForPaymentTrue { set; get; }

        [FindsBy(How = How.Id, Using = "DaysOccupiedFor")]
        private IWebElement daysOccupied { set; get; }

        [FindsBy(How = How.Id, Using = "MeteredForPayment_False")]
        private IWebElement meteredForPaymentFalse { get; set; }

        [FindsBy(How = How.Id, Using = "signInBtn")]
        private IWebElement clickSignInBtn { get; set; }

        #endregion

        public void getWithInvestor(String Urir)
        {
            withInvestor.SendKeys(Keys.Space);
            Assert.True(textBoxURIR.Displayed);
            textBoxURIR.SendKeys(Urir + Keys.Enter);
        }
       
        public void enterUrirNumber(String Urir)
        {
            textBoxURIR.SendKeys(Urir + Keys.Enter);
        }

       
        public void withoutInvestor()
        {
            withInvestor_False.SendKeys(Keys.Space);
        }

        public void ApplicantCategoryIndividual()
        {
            applicantCategoryIndividual.SendKeys(Keys.Space);
        }

        public void HeatingSystemSoleOwner()
        {
            heatingSystemSoleOwner.SendKeys(Keys.Space);
        }

        public void ApplicantTypeOwnerOccupier()
        {
            applicantTypeOwnerOccupier.SendKeys(Keys.Space);
        }

        public void ApplicantType_LocalAuthority()
        {
            applicantType_LocalAuthority.SendKeys(Keys.Space);
        }

        public void PropertyOwnership_OwnOccupy()
        {
            propertyOwnership_OwnOccupy.SendKeys(Keys.Space);
        }

        public void McsNumber(String McsLetter)
        {
            mcsNumber.SendKeys(Helpers.generateRandom(11111111, 99999999) + Keys.Tab + McsLetter);
        }

        public void enterEPCNumber()
        {
            epc1.SendKeys(string.Format(
                "1234" + Keys.Tab + "1334" + Keys.Tab + "1234" + Keys.Tab + "{0}" + Keys.Tab + "{1}",
                Helpers.generateRandom(0, 9999).PadLeft(4, '0'), Helpers.generateRandom(1, 9999).PadLeft(4, '0')));
        }

        public void UsedOwnMoneyTrue()
        {
            usedOwnMoneyYes.SendKeys(Keys.Space);
        }
        public void ownMoneyUsedQuestion_False()
        {
            UsedOwnMoney_No.SendKeys(Keys.Space);
        }

        public void MultipleMcsFalse()
        {
            multipleMcsFalse.SendKeys(Keys.Space);
        }

        public void AdditionalFundingNo()
        {
            additionalFundingNo.SendKeys(Keys.Space);
        }

        public void DeclaredSystemCheckBoxesHotWater()
        {
            declaredSystemCheckBoxesHotWater.SendKeys(Keys.Space);

        }

        public void meteredForPayment_True()
        {
            meteredForPaymentTrue.SendKeys(Keys.Space);
            daysOccupied.SendKeys("181");
        }

        public void meteredForPayment_False()
        {
            meteredForPaymentFalse.SendKeys(Keys.Space);
            daysOccupied.SendKeys("184");
        }

        public void PropertiesHeatingSystemSingle()
        {
            propertiesHeatingSystemSingle.SendKeys(Keys.Space);
        }

        public void HeatingSystemInstalled()
        {
            heatingSystemInstalledTrue.SendKeys(Keys.Space);
        }

        public void assertUrirFormatValidationMessage()
        {
            Assert.True(
                UrirFieldError.Text.Contains("* Required. Enter URIR which comprises of 8 alphanumeric characters"));
        }

        public void selectPropertyCountryScotland()
        {
            propertyCountryScotland.clickOnIt();
        }

        public void clickStartBtnOnFirstPage()
        {
            Helpers.clickOnIt(btnStartApplication);
        }

        public void selectPropertyCountryEngland()
        {
            PropertyCountry_England.clickOnIt();
        }

        public void ApplicantCategoryOrganisation()
        {
            applicantCategory_Organisation.clickOnIt();
        }

        public void clickBtnSignIn()
        {
          clickSignInBtn.Click();
        }
    }
}






