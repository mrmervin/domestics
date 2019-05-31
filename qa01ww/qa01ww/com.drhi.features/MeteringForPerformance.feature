@meteringForPerformance @Browser_Chrome @Regression

    Feature: Metering for performance	
    All heatpumps to have "Metering for performance" question after rp2 date


	Scenario:Display Metering for performance question to heat pumps after RP2 date 
    #12374
	Given I have completed the first page of the application form
	And I am not with an Investor
	When I enter A for a given technology	
	And I create a deemed application
	And I select The property as England
	And I click on Start application
	Then the Metering for performace section is displayed
	When I complete the second page of the application form
	And I click submit
	Then application  In-Review message should be displayed

	Scenario: Manual review of applications with metering for performance mismatch 
	#12380
	When I click Sign-In button on Homepage
	And I enter Username and Password
	And I click Sign-In into MyRhi
	Then I should see metering for performance mismatch on review message
	And I Sign out from MyRHI successfully
	
	Scenario: Check metering for performance question not displayed for non heat pumps
	Given I have completed the first page of the application form
	And I am not with an Investor
	When I enter B for a given technology
	And I create a deemed application
	And I select The property as England
	And I click on Start application
	Then the Metering for performace section is not displayed
	
	#12395
	Scenario: Check metering for performance question for Assisted digital  
	Given I am logged in as CSA
	And I am on Rhita
	And I click on assisted application button
	Given I have completed the first page of the application form
	And I am not with an Investor
	When I enter A for a given technology
	And I create a deemed application
	And I select The property as England
	And I click on Start application
	Then the Metering for performace section is displayed

	
	

	