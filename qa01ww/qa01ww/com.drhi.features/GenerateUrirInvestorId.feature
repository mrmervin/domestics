@GenerateUrir @Browser_Chrome @Aor_Internal @Regression

Feature:Generate Urir and Investor Id

#13406	
Scenario:Generate Urir
Given I am logged in as QA
And I am on Rhita
When I navigate to administration page in RHITA
And I click URIR & Investor ID 
And I enter 00053326 as  a valid Recc/Heis Id
And I click on generate Urir and Investor Id
Then Urir should be generated

Scenario:Urir already generated 
Given I am logged in as QA
And I am on Rhita
When I navigate to administration page in RHITA
And I click URIR & Investor ID
And I enter 00053326 as  a valid Recc/Heis Id
And I click on generate Urir and Investor Id
Then I should see a validation error URIR & Investor Id already generated for this

@Ignore
#Bug present due to datafix to add values in Investor table 
Scenario:Model contract not generated before Urir
Given I am logged in as QA
And I am on Rhita
When I navigate to administration page in RHITA
And I click URIR & Investor ID
And I enter 00070929 as  a valid Recc/Heis Id
And I click on generate Urir and Investor Id
Then I should see a validation error RECC/HIES Id needs at least one model contract id before a URIR/Investor Id can be generated

Scenario:Unavailable to other roles
Given I am logged in as CSA
And I am on Rhita
When I navigate to administration page in RHITA
Then I should not see the Urir Investor Tab

Scenario:Recc Id does not exist 
Given I am logged in as QA
And I am on Rhita
When I navigate to administration page in RHITA
And I click URIR & Investor ID
And I enter 7073100 as  a valid Recc/Heis Id
And I click on generate Urir and Investor Id
Then I should see a validation error RECC/HIES Id provided does not exist, please provide a valid Id
