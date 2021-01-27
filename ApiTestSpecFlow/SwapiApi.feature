Feature: SwapiApiFeature

	

@mytag
Scenario: Swapi Api schema test
	Given I send GET Request to endponit "https://swapi.dev/api/vehicles "
	When the request is succesfull
	Then compare actual response to expected scema