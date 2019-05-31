@NewEpcQuestion @Browser_Chrome @Regression

Feature:New EPC Question 
	In order to reduce reviews 
	As a applicant 
	I want the application to be rejected if I answered No for EPC exemption

#16436
Scenario Outline:To reject Individuals who answer No to new question  

Given I have completed the first page of the application form
And I am not with an Investor
When I enter <Mcsnumber> for a given technology
And I create a deemed application
And I select The property as England
And I click on Start application
And I complete the second page of the application form
And I select No for  Epc recommendation
And I click submit
Then application  should be rejected for No Epc 
And an email should not be sent to the applicant
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

#16607
Scenario Outline: To reject organisations who answer No to new EPC question
Given I am completing the "<Technology>" application process as an organisation
When I select No for  Epc recommendation
And I click submit
Then application  should be rejected for No Epc 
And an email should not be sent to the applicant
Examples: 
| Technology |
| A         |
| B         |
| C         |
| G         |
| H         |
| W         |
| X         |
| S         |

#16495
Scenario Outline:To reject additional applications who answer No to Epc
Given I have created a "<Technology>" application and logged in 
When I create a metered "<Additional Technology>" additional application
And I select No for  Epc recommendation
And I click submit additional application
Then application  should be rejected for No Epc 
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

Scenario Outline: Epc question should be not be shown for Scotland as Loft/cavity returns False  
Given I am completing the "<Technology>" application process
Then new Epc question should not be present
Examples: 
| Technology |
| A          |
| B          |
| S          |