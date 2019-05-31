@API_LinksTest @Browser_Chrome @SmokeTest
Feature: Verify all links are working Api tests
Scenario: Check all links are working on Homepage
Given I am on homepage
Then all links present should work