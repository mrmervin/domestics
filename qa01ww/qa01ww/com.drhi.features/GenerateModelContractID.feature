@ModelContractID @Browser_Chrome @Aor_Internal 
#bug created Validations not thrown

Feature:Create Model Contract-id 
	AS A authorized user of RHITA (CSA/DRO, etc)
	I WANT to be able to generate a Model-Contract-Id given RECC/HIES number and model-contract-name
	SO THAT I am able to provide it to the registered Investor and complete the registration process.
	
#13787
@ignore 

Scenario: Generate contract ID 
	Given I am logged in as DA
	And I am on Rhita
	When I navigate to administration page in RHITA
	And  I click on Contract Id
	And I enter 70731 as  a valid Recc/Heis Id
	And I enter Heat Right as a Contract Name
	And I click on Generate Contract Id
	Then contract Id should be generated
	
@ignore 
Scenario:Error message for invalid ReccId
    Given I am logged in as DA
	And I am on Rhita
	When I navigate to administration page in RHITA
	And  I click on Contract Id
	And I enter 007073100 as  a valid Recc/Heis Id
	And I enter Heat Right as a Contract Name
	And I click on Generate Contract Id
	Then I should see the ReccId does not exist error message

@ignore
Scenario: Error when contract already exists
	Given I am logged in as DA
	And I am on Rhita
	When I navigate to administration page in RHITA
	And  I click on Contract Id
	And I enter 70731 as  a valid Recc/Heis Id
	And I enter Heat Right as a Contract Name
	And I click on Generate Contract Id
	Then I should see the contract already exists error