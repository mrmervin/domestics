using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using qa01ww.com.drhi.pageobjects;
using qa01ww.com.drhi.pageObjects;
using qa01ww.com.drhi.pageObjects.com.drhi.pageobjects;
using qa01ww.com.drhi.pageObjects.com.drhi.pageobjects.external;
using qa01ww.com.drhi.utils;

namespace qa01ww.com.drhi.support
{
    public static class Page
    {

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(AppDriver.Driver, page);
            return page;
        }

        public static InvestorPage investorPage
        {
            get { return GetPage<InvestorPage>(); }
        }

        public static HeaderSection headerSection
        {
            get { return GetPage<HeaderSection>(); }
        }

        public static AdministrationPage administrationPage
        {
            get { return GetPage<AdministrationPage>(); }
        }

        public static CustomerPage customerPage
        {
            get { return GetPage<CustomerPage>(); }
        }

        public static LoginPage loginPage
        {
            get { return GetPage<LoginPage>(); }
        }

        public static UserAdminPage userAdminPage
        {
            get { return GetPage<UserAdminPage>(); }
        }

        public static ThirdPartyListPage thirdpartyListPage
        {
            get { return GetPage<ThirdPartyListPage>(); }
        }

        public static BulkDeclarationPage bulkDeclarationPage
        {
            get { return GetPage<BulkDeclarationPage>(); }
        }

        public static CpiDetailsPage CpiDetailsPage
        {
            get { return GetPage<CpiDetailsPage>(); }
        }

        public static BudgetCapPage budgetCapPage
        {
            get { return GetPage<BudgetCapPage>(); }
        }

        public static ToReviewPage toReviewPage
        {
            get { return GetPage<ToReviewPage>(); }
        }

        public static AdditionalApplicationPage additionalApplicationPage
        {
            get { return GetPage<AdditionalApplicationPage>(); }
        }

        public static ApplicationFormFirstPage ApplicationFormFirstPage
        {
            get { return GetPage<ApplicationFormFirstPage>(); }
        }

        public static ApplicationFormSecondPage ApplicationFormSecondPage
        {
            get { return GetPage<ApplicationFormSecondPage>(); }
        }

        public static ApplicationSubmittedPage ApplicationSubmittedPage
        {
            get { return GetPage<ApplicationSubmittedPage>(); }
        }
        public static AorInternalPage AorInternalPage
        {
            get { return GetPage<AorInternalPage>(); }
        }

       

    }
}
