Feature: Browser Login

Simple login feature of application 


@regression
Scenario: Open Browser and login to application and assert the details
	Given user launches the application
	And click on contact button	
	Then user will see the contact us heading
	And I close the browser

	