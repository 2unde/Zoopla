Feature: SearchFoToRentFlat
	In order to search for To rent
	As a user
	I want to be able to search for To rent property


Scenario: Search To rent
	Given I navigate to Zoopla homepage
	And  Zoopla logo is displayed
	And I click To rent button
	When I enter my desire destion in the search field
	And I select minimum price
	And I select maximum price from the dropdown
	And I select property type from the dropdown
	And I click on search button
	Then the result of the search to rent flat is displayed
	And List view is enable
	And  Grid view on result page is disable
	And Map view is on result page is disable
	And I Click and validate Grid view
	And I click and validate Map view
