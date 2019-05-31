
@AutomateRfi @Browser_Chrome @Regression

#18406
Feature:To automate Request for Information 
I want the DRHI applicant; on completion of an application form in MyRHI and Identified
by RHITA as having a status of ‘Manual Review’;  presented onscreen in MyRHI with the RFI 
which corresponds to the information they have entered (the correct RFI)


Scenario Outline:Rfi to be sent out on application 
Given I have completed the first page of the application form
And I am not with an Investor
When I enter <Mcsnumber> for a given technology
And I create a deemed application
And I select The property as England
And I click on Start application
And I complete the second page of the application form
And I click submit
Then an Rfi should be sent out automatically
Examples: 
| Mcsnumber |
| A         |
| B         |
| C         |
| G         |
| H         |
| W         |
| X         |
| S         |

Scenario Outline: Rfi should not be sent out for accredited applications
Given I am completing the "<Technology>" application process
When I click submit
Then application should be Auto-accredited
Then an Rfi should not be sent out automatically
Examples: 
|Technology|
| S         |


#18408
Scenario: Maureen status to change to "With Member" 
Given I have completed the first page of the application form
And I am not with an Investor
When I enter A for a given technology
And I create a deemed application
And I select The property as England
And I click on Start application
And I complete the second page of the application form
And I click submit
Then Maureen status should change to With Member