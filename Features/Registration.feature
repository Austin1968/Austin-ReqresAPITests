Feature: User Registration
	In order to create new post for User Registration
	I want to be able to register new user on Reqres Registration page

Scenario: Successful Registration
	Given I Navigate to the Registration page of reqres
	When I Register a user with Username and Password Registration Page		
	Then I Should See Message Response200Msg on the Registration Page

Scenario Outline: UnSuccessful Registration
	Given I Navigate to the Registration page of reqres
	When I Unsucessfully Register a user with Username and BLANK on the Registration Page
	Then I Should See Error Message errorMsg on the Registration Page

Examples: 
 | name             | username | password | errorMsg                                                                                 |
 | Blank Password   | admin    |          | Response: 400 along with an error. 