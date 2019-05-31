
@UploadRecc @Browser_Chrome @Aor_Internal @Regression

#13636
Feature:Upload Recc Register in Administration section

@SmokeTest
Scenario:DA Uploads Recc file 
Given I am logged in as DA
And I am on Rhita
When I navigate to administration page in RHITA
And I click on RECC
Then I see the upload file section 
And I am able to Upload a file "C:\\repo\\qa01ww\\qa01ww\\com.drhi.resources\\190224_RECC.xlsx" into Rhita
And the file should be uploaded successfully

Scenario:QA Uploads Recc file 
Given I am logged in as QA
And I am on Rhita
When I navigate to administration page in RHITA
And I click on RECC
Then I see the upload file section 
And I am able to Upload a file "C:\\repo\\qa01ww\\qa01ww\\com.drhi.resources\\190224_RECC.xlsx" into Rhita
And the file should be uploaded successfully

Scenario: Upload incorrect Format 
Given I am logged in as QA
And I am on Rhita
When I navigate to administration page in RHITA
And I click on RECC
Then I see the upload file section 
And I am able to Upload a file "C:\\repo\\qa01ww\\qa01ww\\com.drhi.resources\\IncorrectFormat.docx" into Rhita
And I should be shown an error message for incorrect format

Scenario: Upload incorrect columns file 
Given I am logged in as QA
And I am on Rhita
When I navigate to administration page in RHITA
And I click on RECC
Then I see the upload file section 
And I am able to Upload a file "C:\\repo\\qa01ww\\qa01ww\\com.drhi.resources\\HIES.xlsx" into Rhita
And I should be shown an error message for incorrect columns

Scenario: Upload duplicate Recc Ids
Given  I am logged in as QA
And I am on Rhita
When I navigate to administration page in RHITA
And I click on RECC
Then I see the upload file section 
And I am able to Upload a file "C:\\repo\\qa01ww\\qa01ww\\com.drhi.resources\\DuplicateReccID.xlsx" into Rhita
And I should be shown an error message for duplicate IDS
