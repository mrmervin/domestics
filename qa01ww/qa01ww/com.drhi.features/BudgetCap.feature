@BudgetCap @Browser_Chrome @Regression

#12313
Feature:Adding Budget cap in Rhita
	Delegated Authority would like to add manual review start date of all new applications, 
	start date of soft closure, start date of hard closure inorder to restrict new applications.
	
Scenario:Adding soft closure dates in rhita
Given I am logged in as DA	
And I am on Rhita
When I navigate to administration page in RHITA
And I click on Budget cap
Then I should be able to add the Budget cap dates
And the dates should be added to the active dates table

Scenario:Create a soft closure application 
Given I have completed the first page of the application form
And I am not with an Investor
When I enter J for a given technology 
And I create a deemed application
And I select The property as England
And I click on Start application
Then it should be autorejected with a soft closure message

Scenario:Update budget cap dates for hard closure
Given I am logged in as DA
And I am on Rhita
When I navigate to administration page in RHITA
And I click on Budget cap
When  I add new budget cap dates
Then the dates should be updated In the active dates table

Scenario:Create a Hardclosure application 
Given I am on homepage
Then I should see the hard closure message

Scenario:Removing budget cap dates from table
Given I am logged in as DA
And I am on Rhita
When I navigate to administration page in RHITA
And I click on Budget cap
When I click on remove 
Then the dates should be removed from the active dates table



 