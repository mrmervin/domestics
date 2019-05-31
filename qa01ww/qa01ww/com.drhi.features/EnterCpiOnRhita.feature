@Regression 
@Browser_Chrome
@Add_CPI 
Feature:11907_Allow Payment manager to enter CPI amount

Scenario:Payment manager enters CPI amount
	Given I am logged in as PM
	And I am on Rhita
	When I navigate to administration page in RHITA
	And I click the CPI tab
	And I complete the  CPI details form 
	Then It should be added to the list successfully 
	And the state should be pending
