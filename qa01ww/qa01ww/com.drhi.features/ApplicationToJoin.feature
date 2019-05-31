 @Browser_Chrome 


Feature:Application form 
  A test to submit an application and confirmation message is displayed

 @DeemedApplications @Regression
Scenario Outline:Create deemed applications

Given I am on homepage
And I am not with an Investor
And I am an individual
And I am a heating system sole owner
And I am an owner occupier
When I enter <Mcsnumber> for a given technology
And I answer Yes for own money used
And I create a deemed application
And I select No for Additional funding
And I enter EPC number
And I select NO for multiple MCS
And I select what buildings are heated by the heating system
And I select system provides heat for hot water
And I select Yes if anyone live in the property before commisioning date
And I select The property as England
And I click on Start application
And I complete the second page of the application form
And I click submit
Then application  In-Review message should be displayed
Examples: 
| Mcsnumber |
| A          |
| B          |
| C          |
| G          |
| H          |
| W          |
| X          |

@meteredApplication @Regression
Scenario Outline:Create metered application
Given I am on homepage
And I am not with an Investor
And I am an individual
And I am a heating system sole owner
And I am an owner occupier
When I enter <Mcsnumber> for a given technology
And I select No for Additional funding
And I enter EPC number
And I select NO for multiple MCS
And I answer Yes for own money used
And I create a metered application
And I select what buildings are heated by the heating system
And I select system provides heat for hot water
And I select Yes if anyone live in the property before commisioning date
And I select The property as England
And I click on Start application
And I complete the second page of the application form
And I click submit
Then application  In-Review message should be displayed
Examples: 
| Mcsnumber |
| A          |
| B          |
| C          |
| G          |
| H          |
| W          |
| X          |

@AssistedDigital @Regression
Scenario Outline:Create assisted digital application
Given I am logged in as CSA
And I am on Rhita
And I click on assisted application button
And I am an individual
And I am a heating system sole owner
And I am an owner occupier
And I am not with an Investor
When I answer Yes for own money used
And I select NO for multiple MCS
And I select No for Additional funding
And I enter EPC number
And I enter <Mcsnumber> for a given technology
And I create a deemed application
And I select what buildings are heated by the heating system
And I select system provides heat for hot water
And I select Yes if anyone live in the property before commisioning date
And I select The property as England
And I click on Start application
And I complete the second page of the application form
And I click submit
Then application  In-Review message should be displayed
Examples: 
| Mcsnumber |
| A          |
| B          |
| C          |
| G          |
| H          |
| W          |
| X          |

@Organisation @Regression
Scenario Outline: Create application representing an organisation 
Given I am on homepage
And I am a heating system sole owner
And I am not with an Investor
When I enter <Mcsnumber> for a given technology
And I select NO for multiple MCS
And I select No for Additional funding
And I select what buildings are heated by the heating system
And I select system provides heat for hot water
And I select Yes if anyone live in the property before commisioning date
And I enter EPC number
And I answer Yes for own money used
And I apply as an organisation 
And I create a deemed application
And I select The property as England
And I click on Start application
And I complete the second page of the application form
And I click submit
Then application  In-Review message should be displayed
Examples: 
| Mcsnumber |
| A          |
| B          |
| C          |
| G          |
| H          |
| W          |
| X          |

@Auto-Accredited @Regression
Scenario Outline:Create application which is auto-accredited
Given I am completing the "<Technology>" application process
When I click submit
Then application should be Auto-accredited
Examples: 
|Technology|
| s        |
| k          |
