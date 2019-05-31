@Regression @BulkSignDeclaration @Browser_Chrome @Regression
#Note This test doesnt not work in demo due to number of bulk applications in Db

#11771
Feature:Bulk sign declarations where annual declarations are due

    Scenario Outline:Accredit applications where Annual declarations are due 
    Given I am completing the "<Technology>" application process
	When I click submit
	Then application  In-Review message should be displayed
	Given the application  status is accredited 
	And the first annual declaration is due
    Examples: 
	|Technology |
	| A          |
	| C          |
	| G          |
	
	Scenario: Verify interactions are created after Bulk signing declarations
	Given I am on Rhita
	And I am logged in as CSA
	And I am on Rhita
	When I sign as complaint via bulk sign declaration page
	Then a new Interaction is created
	

	