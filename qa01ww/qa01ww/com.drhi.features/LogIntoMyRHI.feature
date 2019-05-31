@MyRHI_Login
@Browser_Chrome @SmokeTest


Feature: Log into an accredited application 
    Create a fresh application 
	Assert the tabs when applicant logs into a accredited application 


Scenario Outline:To check all CTAS present on login
Given I have created a "<Technology>" application and logged in 
And the application  status is accredited
Then I expect to see all CTAS present
And I Sign out from MyRHI successfully
Examples: 
|Technology|
| A          |
| B          |
| C          |
| G          |
| H          |
| W          |
| X          |
