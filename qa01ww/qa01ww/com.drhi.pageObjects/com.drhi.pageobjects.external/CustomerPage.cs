using System;
using System.Web.Script.Services;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using qa01ww.com.drhi.support;

namespace qa01ww.com.drhi.pageObjects
{
    public class CustomerPage
    {
        #region Page element

        [FindsBy(How = How.CssSelector, Using = " #btnSaveContinue")]
        private IWebElement btnSaveContinue { get; set; }

        [FindsBy(How = How.CssSelector, Using = " #heatingSystemAddressPostcodeLookupTxt")]
        private IWebElement heatingSystemAddressPostcodeLookupTxt { get; set; }
        [FindsBy(How = How.Id, Using = "changeDetails3")]
        private IWebElement updateBankdetailsBtn { get; set; }

        [FindsBy(How = How.Id, Using = "btnSubmit")]
        private IWebElement btnSubmit { get; set; }
        [FindsBy(How = How.Id, Using = "MeteringAndMonitoringQuestions_ServiceProviderName")]
        private IWebElement meteringAndMonitoringQuestions_ServiceProviderName { get; set; }

        [FindsBy(How = How.Id, Using = "MeteringAndMonitoringQuestions_ServiceProviderEmail")]
        private IWebElement meteringAndMonitoringQuestions_ServiceProviderEmail { get; set; }

        [FindsBy(How = How.Id, Using = "MeteringAndMonitoringQuestions_ServiceProviderContactNo")]
        private IWebElement meteringAndMonitoringQuestions_ServiceProviderContactNo { get; set; }

        [FindsBy(How = How.Id, Using = "MeteringAndMonitoringQuestions_ServiceProviderReferenceNo")]
        private IWebElement meteringAndMonitoringQuestions_ServiceProviderReferenceNo { get; set; }

        [FindsBy(How = How.Id, Using = "MeteringAndMonitoringQuestions_ServicePackageStartDate")]
        private IWebElement meteringAndMonitoringQuestions_ServicePackageStartDate { get; set; }

        [FindsBy(How = How.Id, Using = "provideBankDetailsDisabled")]
        private IWebElement bankDetailsBtn { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#sidebar-nav > li.current > a")]
        private IWebElement cta_MyRhi { get; set; }

        [FindsBy(How = How.Id, Using = "MyResponsibility")]
        private IWebElement myResponsibility { get; set; }

        [FindsBy(How = How.Id, Using = "annualDeclarationNote")]
        private IWebElement annualDeclarationNote { get; set; }

        [FindsBy(How = How.Id, Using = "MyAccreditedProperties")]
        private IWebElement myAccreditedProperties { get; set; }

        [FindsBy(How = How.Id, Using = "btnMyProperties")]
        private IWebElement cta_MyApplication { get; set; }

        [FindsBy(How = How.ClassName, Using = "page-title")]
        private IWebElement pageTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#MyAccreditedProperties > tbody > tr > td:nth-child(5) > a")]
        private IWebElement statementOfEligibility { get; set; }

        [FindsBy(How = How.Id, Using = "btnMyPayments")]
        private IWebElement cta_MyPayments { get; set; }

        [FindsBy(How = How.Id, Using = "exportPayments_DisplayForm_Btn")]
        private IWebElement exportPayments_DisplayForm_Btn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#MyPayments > tbody > tr > td:nth-child(5) > a")]
        private IWebElement quarterlyPaymentAmt { get; set; }

        [FindsBy(How = How.Id, Using = "nonToOMeteredText")]
        private IWebElement bulletPoints { get; set; }

        [FindsBy(How = How.Id, Using = "TotalBox")]
        private IWebElement calculationList { get; set; }

        [FindsBy(How = How.LinkText, Using = "Address details")]
        private IWebElement cta_AddressDetails { get; set; }

        [FindsBy(How = How.LinkText, Using = "Personal details")]
        private IWebElement cta_Personaldetails { get; set; }

        [FindsBy(How = How.Id, Using = "ContactDetails_ContactNumber")]
        private IWebElement homePhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "changeDetails")]
        private IWebElement btn_ChangePersonalDetails { get; set; }
        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement firstNamePresent { get; set; }

        [FindsBy(How = How.Id, Using = "saveChanges")]
        private IWebElement btn_SaveChanges { get; set; }

        [FindsBy(How = How.Id, Using = "btnChangePassword")]
        private IWebElement btn_ChangePassword { get; set; }

        [FindsBy(How = How.Id, Using = "btnChangePasswordConfirmation")]
        private IWebElement btn_ChangePasswordConfirmation { get; set; }

        [FindsBy(How = How.Id, Using = "bankDetails")]
        private IWebElement cta_BankDetails { get; set; }

        [FindsBy(How = How.Id, Using = "changeDetails")]
        private IWebElement btn_Change { get; set; }

        [FindsBy(How = How.Id, Using = "amendBankDetailsForm")]
        private IWebElement amendBankDetailsForm { get; set; }

        [FindsBy(How = How.Id, Using = "btnAdditionalApplication")]
        private IWebElement cta_AdditionalApplication { get; set; }

        [FindsBy(How = How.Id, Using = "btnStartApplication")]
        private IWebElement btn_StartApplication { get; set; }

        [FindsBy(How = How.Id, Using = "signInBtn")]
        private IWebElement btn_signIn { get; set; }

        [FindsBy(How = How.Id, Using = "btnAnnualDeclarations")]
        private IWebElement cta_AnnualDeclarations { get; set; }

        [FindsBy(How = How.Id, Using = "annualDeclarationsTable")]
        private IWebElement annualDeclarationsTable { get; set; }

        [FindsBy(How = How.Id, Using = "annualDecsHistoryBtn")]
        private IWebElement btn_annualDecsHistory { get; set; }

        [FindsBy(How = How.Id, Using = "btnMeteringAndMonitoring")]
        private IWebElement cta_MeteringAndMonitoring { get; set; }

        [FindsBy(How = How.Id, Using = "mmspRegistrationLink")]
        private IWebElement registerMMSPlink { get; set; }

        [FindsBy(How = How.Id, Using = "MMSPQuestions")]
        private IWebElement mMSPQuestions { get; set; }

        [FindsBy(How = How.Id, Using = "btnHeatMeters")]
        private IWebElement cta_MeterReadings { get; set; }

        [FindsBy(How = How.ClassName, Using = "tip-text")]
        private IWebElement inReviewText { get; set; }

        [FindsBy(How = How.Id, Using = "btnSignOut")]
        private IWebElement btnSignOut { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicationCriteriaViewModel_PropertyCountry_England")]
        private IWebElement ApplicationCriteriaViewModel_PropertyCountry_England { get; set; }

        [FindsBy(How = How.Id, Using = "btnStartApplication")]
        private IWebElement btnStartApplication { get; set; }

        [FindsBy(How = How.Id, Using = "ApplicationCriteriaViewModel_MCSLetter")]
        private IWebElement ApplicationCriteriaViewModel_MCSLetter { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#please-update-message")]
        private IWebElement pleaseUpdatemessage { get; set; }
        [FindsBy(How = How.Id, Using = "changeDetails-any-non-aor")]
        private IWebElement changeBankDetailsBtnNonAOr { get; set; }

        #endregion

        public void assertUserLoggedIn()
        {
            Assert.IsTrue(pageTitle.Text.Contains("Welcome"));
        }

        public void assertReviewmessage(String meteringforPerformanceMismatch)
        {
            if (Helpers.IsElementPresent(inReviewText))
            {
                Assert.True(inReviewText.Text.Contains(meteringforPerformanceMismatch));
            }
        }

        public void assertMeteringForPerformanceQuestionNotDisplayed(String meteringforPerformanceMismatch)
        {
            if (Helpers.IsElementPresent(inReviewText))
            {
                Assert.False(inReviewText.Text.Contains(meteringforPerformanceMismatch));
            }
        }

        //Click  CTAS Present
        public void assertmyRhi()
        {
            Assert.True(Helpers.IsElementPresent(cta_MyRhi));
            if (Helpers.IsElementPresent(cta_MyRhi))
            {
                cta_MyRhi.Click();
                Assert.True(Helpers.IsElementPresent(myResponsibility));
                Assert.True(Helpers.IsElementPresent(annualDeclarationNote));
            }
        }

        public void assertMyApplications()
        {
            Assert.IsTrue(Helpers.IsElementPresent(cta_MyApplication));
            if (Helpers.IsElementPresent(cta_MyApplication))
            {
                cta_MyApplication.Click();
                Assert.IsTrue(pageTitle.Text.Contains("My applications"));
                Assert.IsTrue(Helpers.IsElementPresent(myAccreditedProperties));
                Assert.True(Helpers.IsElementPresent(statementOfEligibility));
                if (Helpers.IsElementPresent(statementOfEligibility))
                {
                    statementOfEligibility.Click();
                    Assert.True(pageTitle.Text.Contains("Statement of eligibility"));
                }
            }
        }

        public void assertPaymentSchedule()
        {
            Assert.IsTrue(Helpers.IsElementPresent(cta_MyPayments));
            if (Helpers.IsElementPresent(cta_MyPayments))
            {
                cta_MyPayments.Click();
                Assert.IsTrue(pageTitle.Text.Contains("Payments"));
                Assert.True(
                    Helpers.IsElementPresent(exportPayments_DisplayForm_Btn));
                Assert.True(Helpers.IsElementPresent(quarterlyPaymentAmt));
                if (Helpers.IsElementPresent(quarterlyPaymentAmt))
                {
                    quarterlyPaymentAmt.Click();
                    Assert.True(pageTitle.Text.Contains("Payment details"));
                    Assert.True(Helpers.IsElementPresent(bulletPoints));
                    Assert.True(
                        Helpers.IsElementPresent(calculationList));
                }
            }
        }

        public void assertPersonalDetails()
        {
            Assert.IsTrue(Helpers.IsElementPresent(cta_Personaldetails));
            if (Helpers.IsElementPresent(cta_Personaldetails))
            {
                cta_Personaldetails.Click();
                Assert.IsTrue(Helpers.IsElementPresent(btn_ChangePersonalDetails));
                btn_ChangePersonalDetails.Click();
                Assert.True(pageTitle.Text.Contains("Personal details"));
                Assert.True(Helpers.IsElementPresent(homePhoneNumber));
                Assert.True(Helpers.IsElementPresent(firstNamePresent));
                Assert.True(Helpers.IsElementPresent(btn_SaveChanges));
            }
        }

        public void assertAddressDetails()
        {
            Assert.IsTrue(Helpers.IsElementPresent(cta_AddressDetails));
            if (Helpers.IsElementPresent(cta_AddressDetails))
            {
                cta_AddressDetails.Click();
                Assert.IsTrue(pageTitle.Text.Contains("Address details"));
            }
        }

        public void assertMyPassword()
        {
            Assert.IsTrue(Helpers.IsElementPresent(btn_ChangePassword));
            if (Helpers.IsElementPresent(btn_ChangePassword))
            {
                btn_ChangePassword.Click();
                Assert.True(Helpers.IsElementPresent(btn_ChangePasswordConfirmation));
                btn_ChangePasswordConfirmation.Click();
                Assert.IsTrue(pageTitle.Text.Contains("My password"));
            }
        }

        public void assertBankDetails()
        {
            Assert.IsTrue(Helpers.IsElementPresent(cta_BankDetails));
            if (Helpers.IsElementPresent(cta_BankDetails))
            {
                cta_BankDetails.Click();
                Assert.True(pageTitle.Text.Contains("Bank Details"));
                Assert.IsTrue(Helpers.IsElementPresent(btn_Change));
                btn_Change.Click();
                Assert.True(pageTitle.Text.Contains("Change bank details"));
                Assert.True(Helpers.IsElementPresent(amendBankDetailsForm));
                Assert.True(Helpers.IsElementPresent(btn_SaveChanges));
            }
        }
        public void assertBankdetailsbuttonNotPresent()
        {
            if (Helpers.IsElementPresent(cta_BankDetails))
            {
                cta_BankDetails.Click();
                Assert.True(pageTitle.Text.Contains("Bank Details"));
                Assert.False(bankDetailsBtn.Enabled);
            }
        }

        public void assertupdateBankdetailsbuttonPresent()
        {

            btn_signIn.Click();
            if (Helpers.IsElementPresent(cta_BankDetails))
            {
                cta_BankDetails.Click();
                Assert.True(pageTitle.Text.Contains("Bank Details"));
                Assert.True(updateBankdetailsBtn.Enabled);
            }
        }

        public void assertchangeBankdetailsbuttonNonAorPresent()
        {
            btn_signIn.Click();
            if (Helpers.IsElementPresent(cta_BankDetails))
            {
                cta_BankDetails.Click();
                Assert.True(pageTitle.Text.Contains("Bank Details"));
                Assert.True(changeBankDetailsBtnNonAOr.Enabled);
            }
        }

        public void assertAdditionalApplication()
        {
            Assert.IsTrue(Helpers.IsElementPresent(cta_AdditionalApplication));
            if (Helpers.IsElementPresent(cta_AdditionalApplication))
            {
                cta_AdditionalApplication.Click();
                Assert.IsTrue(pageTitle.Text.Contains("Additional application"));
                Assert.True(Helpers.IsElementPresent(btn_StartApplication));
                btn_signIn.Click();
            }
        }

        public void clickOnAdditionalApplication()
        {
            cta_AdditionalApplication.Click();
        }
        public void assertAnualDeclaration()
        {
            Assert.IsTrue(Helpers.IsElementPresent(cta_AnnualDeclarations));
            if (Helpers.IsElementPresent(cta_AnnualDeclarations))
            {
                cta_AnnualDeclarations.Click();
                Assert.IsTrue(pageTitle.Text.Contains("My annual declarations"));
                Assert.True(Helpers.IsElementPresent(btn_annualDecsHistory));
                Assert.True(Helpers.IsElementPresent(annualDeclarationsTable));
            }
        }

        public void assertMMSP()
        {
            Assert.IsTrue(Helpers.IsElementPresent(cta_MeteringAndMonitoring));
            if (Helpers.IsElementPresent(cta_MeteringAndMonitoring))
            {
                cta_MeteringAndMonitoring.Click();

                Assert.IsTrue(pageTitle.Text.Contains("Metering and monitoring service package (MMSP)"));

                if (Helpers.IsElementPresent(registerMMSPlink))
                {
                    Assert.True(Helpers.IsElementPresent(registerMMSPlink));
                    registerMMSPlink.Click();
                    Assert.True(Helpers.IsElementPresent(mMSPQuestions));
                }
            }
        }

        public void completeMMSPquestion()
        {
            meteringAndMonitoringQuestions_ServiceProviderName.SendKeys("MMSP name");
            meteringAndMonitoringQuestions_ServicePackageStartDate.SendKeys("10/09/1983");
            meteringAndMonitoringQuestions_ServiceProviderContactNo.SendKeys("07569676565");
            meteringAndMonitoringQuestions_ServiceProviderEmail.SendKeys("admin@test.com");
            meteringAndMonitoringQuestions_ServiceProviderReferenceNo.SendKeys("12345");
            btnSubmit.Click();
        }

        public void assertsubmitMeterReading()
        {
            Assert.IsTrue(Helpers.IsElementPresent(cta_MeterReadings));
            if (Helpers.IsElementPresent(cta_MeterReadings))
            {
                cta_MeterReadings.Click();
                Assert.IsTrue(pageTitle.Text.Contains("Submit my meter readings"));
            }
        }

        public void clickOnSignout()
        {
            btnSignOut.Click();
            Assert.False(Helpers.IsElementPresent(firstNamePresent));
        }

        internal void assertBankdetailsMsg()
        {
            Assert.IsTrue(pleaseUpdatemessage.Text.Contains("As your first RHI application was under Assignment of Rights"));
        }
    }
}



