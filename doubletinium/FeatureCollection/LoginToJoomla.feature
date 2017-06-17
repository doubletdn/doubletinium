Feature: LoginToJoomla
	Verify that function Login works correctly

@mytag
Scenario: Login to Joomla with valid account
	Given User navigate to Joomla administrator page
	When User login with valid account
	| Username     | Password |
	| doubletinium | 123456   |
	Then User login to Joomla administrator page successfully
	And Control Panel page display as default

