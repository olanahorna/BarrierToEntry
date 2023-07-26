Feature: Scenario1
	
	Scenario: Check that user without loggining cannot have access to the site
	When I navigate to the tracking site
	Then I am presented with the loggining screen


Scenario Outline: Check that user able to login with valid credentials
	Given I login into the site with the following credentials - '<username>', '<password>'
	Then I logged in successfully

	Examples: 
	| username | password | 
	| Admin    | admin123 | 