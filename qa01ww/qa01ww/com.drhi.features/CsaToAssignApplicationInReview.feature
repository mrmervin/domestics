@CsaAssignsapplication @Browser_Chrome @Regression
   Feature:#12408_Allow CSA to assign applications in Review
   To support the new Operations manual review process a CSA needs 
   to be able to assign reviews to other CSA's as well as to themselves
 
   Scenario:Allow CSA to assign applications in Review
   Given I am logged in as CSA
   And I am on Rhita
   When I click on To review tab
   Then I can click on assign application 
   And I should be able to assign applications to a CSA