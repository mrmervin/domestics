@Aor_external @Browser_Chrome @Regression

Feature: Assignment of Rights 


Background: 
Given I have completed the first page of the application form 
When I apply as an Investor with UA641213 as URIR 

Scenario Outline:Complete form with an investor 
When I enter <McsNumber> for a given technology
And I create a deemed application
And I click on Start application
And I complete the second page of the application form
And I click submit
Then application  In-Review message should be displayed
Examples: 
|McsNumber|
| A          |
| B          |
| C          |
| G          |
| W          |
| X          |    
| S         | 

#13231
Scenario Outline:Do not reject application when own money not used 
When I enter <McsNumber> for a given technology
When I answer NO for own money used
And I create a deemed application
And I click on Start application
Then applicant should not be rejected 
Examples: 
|McsNumber|
| A          |
| B          |
| C          |
| G          |
| H          |
| W          |
| X          | 
| S         | 

Scenario Outline:Do not Auto accredit applicant  applying as Investor 
When I enter <McsNumber> for a given technology
And I create a deemed application
And I click on Start application
And I complete the second page of the application form
And I click submit
Then application should not be Auto accredited
Examples: 
|McsNumber|
| s  |
| k  |

#13791
Scenario Outline: Apply for MMSP  without bank details
When I enter <McsNumber> for a given technology
And I create a deemed application
And I click on Start application
And I complete the second page of the application form
And I click submit
Then application  In-Review message should be displayed
When I click Sign-In button on Homepage
And I enter Username and Password
When I click Sign-In into MyRhi
Then I should be logged into the application
And the Bank details button should be disabled 
When I register for mmsp 
Then bank details button should be enabled 
And I Sign out from MyRHI successfully
Examples: 
| McsNumber  |
| A          |
| B          |
| C          |
| G          |
| S          | 

#14046
Scenario Outline: Create an additional application without bank details 
When I enter <McsNumber> for a given technology
And I create a deemed application
And I click on Start application
And I complete the second page of the application form
And I click submit
Then application  In-Review message should be displayed
When I click Sign-In button on Homepage
And I enter Username and Password
When I click Sign-In into MyRhi
Then I should be logged into the application
And the Bank details button should be disabled 
When I create a deemed "<Additional Technology>" additional application
And I click submit additional application
Then I should see new message to enter bank details
And I Sign out from MyRHI successfully
Examples: 
| McsNumber | Additional Technology |
| A         | A                     |
| B         | B                     |
| C         | C                     |
| G         | G                     |
| H         | H                     |
| W         | W                     |
| X         | X                     |
| S         | S                     |

#14227
Scenario Outline:Bank account details visibility
When I enter <McsNumber> for a given technology
When I apply as an organisation
And I create a deemed application
And I select The property as England
And I click on Start application
And the product is eligible for MMSP
And I complete the second page of the application form
And I click Yes to metering and monitoring 
Then Bank details section should be visible 
But If I click No to metering and monitoring 
Then Bank details section should not be visible
Examples: 
| McsNumber  |
| A          |
| B          |
| C          |
| G          |
| H          |
| W          |
| S          | 
| X          | 


