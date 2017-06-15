Feature: LoginToJoomla
	Verify that function Login works correctly

@mytag
Scenario Outline: Login to Joomla with valid account
	Given User navigate to Joomla administrator page
	When User enter valid <username> and valid <password>
	Then User login to Joomla administrator page successfully
	And Control Panel page display as default
Examples: 
| username   | password |
| testuser_1 | Test@123 |
