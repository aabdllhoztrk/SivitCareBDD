Feature: TF1_Login
	Login with valid creteria

@mytag
	Scenario: User log In
	Given the user is on the login screen 
	When the user submit valid log-in criteria
	Then the user should see UserName on HomePage 
	
