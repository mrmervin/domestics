@NoImqs @Browser_Chrome @Regression

Feature: Reject applications with no IMQS
	As an applicant
	I want new applications to be rejected when submitted without IMQS

#16354,16413
Scenario Outline: To reject external applications without IMQS
Given I am completing the "<Technology>" application process 
When I answer NO for IMQs
And I click submit
Then application should be rejected for No IMQ's
And an email should not be sent to the applicant
Examples: 
|Technology  |
| A			 |
| B          |
| C          |
| G          |
| H          |
| W          |
| X          |

#15691
Scenario Outline: To reject external organisations applications without IMQS
Given I am completing the "<Technology>" application process as an organisation 
When I answer NO for IMQs
And I click submit
Then application should be rejected for No IMQ's
And an email should not be sent to the applicant
Examples: 
|Technology  |
| A			 |
| B          |
| C          |
| G          |
| H          |
| W          |
| X          |

#15693
Scenario Outline: To reject additional applications without IMQS
Given I have created a "<Technology>" application and logged in 
When I create a metered "<Additional Technology>" additional application
And I answer NO for IMQs
And I click submit additional application
Then application should be rejected for No IMQ's
And I Sign out from MyRHI successfully
Examples: 
| Technology | Additional Technology |
| A          | A                     |
| B          | B                     |
| C          | C                     |
| G          | G                     |
| H          | H                     |
| W          | W                     |
| X          | X                     |













