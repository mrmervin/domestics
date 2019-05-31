using qa01ww.com.drhi.support;
using qa01ww.com.drhi.utils;
using TechTalk.SpecFlow;

namespace qa01ww.com.drhi.stepDefinitions
{
    [Binding]
    public class BudgetCapSteps
    {
        //[When(@"I complete the first page of the application")]
        //public void WhenICompleteTheFirstPageOfTheApplication()
        //{
        //    Page.landingPage.editFirstPageOfApplication();
        //}

        [Then(@"it should be autorejected with a soft closure message")]
        public void ThenItShouldBeAutorejectedWithASoftClosureMessage()
        {
            Page.ApplicationSubmittedPage.assertsSoftClosurePage();
        }

        [Then(@"I should see the hard closure message")]
        public void ThenIShouldSeeTheHardClosurMessage()
        {
            Page.ApplicationSubmittedPage.assertHardClosurePage();
        }
        
        [When(@"I click on Budget cap")]
        public void WhenIClickOnBudgetCap()
        {
            Page.administrationPage.clickOnBudgetCap();
        }

        [Then(@"I should be able to add the Budget cap dates")]
        public void ThenIShouldBeAbleToAddTheBudgetCapDates()
        {
            Page.budgetCapPage.removeDates();//if already present 
            Page.budgetCapPage.createBudgetCapDates();
        }

        [Then(@"the dates should be added to the active dates table")]
        public void ThenTheDatesShouldBeAddedToTheActivedatesTable()
        {
            Page.budgetCapPage.assertFirstDatesInTable();
        }

        [Then(@"the dates should be updated In the active dates table")]
        public void ThenTheDatesShouldBeUpdatedInTheActiveDatesTable()
        {
           Page.budgetCapPage.assertSecondDateInTable();
        }

        [When(@"I add new budget cap dates")]
        public void WhenIAddNewBudgetCapDates()
        {
            Page.budgetCapPage.updateBudgetCapDates();
        }

        [When(@"I click on remove")]
        public void WhenIClickOnRemove()
        {
            Page.budgetCapPage.removeDates();
            AppDriver.Driver.Navigate().Refresh();
        }

        [Then(@"the dates should be removed from the active dates table")]
        public void ThenTheDatesShouldBeRemovedFromTheActiveDatesTable()
        {
           Page.budgetCapPage.assertDatesRemoved();
        }
    }
}
