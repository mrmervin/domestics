@Regression 
@Browser_Chrome
@AddThirdParty

#11801
Feature:AddInstallerToThirdPartyList

	Scenario: Allow Qa to add 3rd party installers
	Given I am logged in as QA
	And I am on Rhita
	When I navigate to administration page in RHITA
	And I click the third party tab
	Then I should be able to add third party installers

	Scenario:Da Changes 3rd Party Status 
	Given I am logged in as DA
	And I am on Rhita
	When I navigate to administration page in RHITA
	And I click the third party tab
	And I click on a third party installer 
	Then I should see a third party installer details page
	And I should be able to change the status for audit 
	And I should be able to change the status  for legal
	And the history table should be updated