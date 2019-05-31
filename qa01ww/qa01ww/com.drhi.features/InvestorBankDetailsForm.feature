	
	#16922,16921
	@InvestorBankForm @Browser_Chrome 
	@Regression
	
	Feature: Investor bank Details Form
	As a registered user in Rhita
	I want to enter Investor bank details 
	So that they go into sun payment system 

 
	Background: 
    Given I am logged in as DA
	And I am on Rhita
	When I navigate to administration page in RHITA
    When I click the Inv bank details
    
	Scenario:DA to enter bank details 
	Then I should see the Investor form 

    Scenario: Investor ID present in dropdown
	When I click on the dropdown InvestorID
	Then I should see a list of Investors

	Scenario:Complete Investor form
	When I click on the dropdown InvestorID
    And I complete the Investor form 
	And I click on Update Investor bank details
	Then the Investor Bank details should be added successfully



