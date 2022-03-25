Feature: TF2_Scores
	calculate some scores about patient
	
Background: 
	Given the user logged into the system
	And the user locates to patient dashboard page

Scenario: Apache Score		
	When the user calculates apache score
	Then apache Score should be 16
	And beklenen Olum should be 23.5
	And apache Score should appear in Dashboard page

Scenario: Glaskow Score		
	When the user calculates glaskow score
	Then glaskow score "10" should appear in dashboard page

Scenario: Egrf Score		
	When the user calculates egrf score
	Then egrf Score should be 1.13
	And egrf score should appear in dashboard page

Scenario: Sofa Score		
	When the user calculates sofa score
	Then sofa Score should be 1.13
	And beklenen olum should be < 10%
	And sofa score should appear in dashboard page

Scenario: Saps Score		
	When the user calculates saps score
	Then saps score should be 102
	And beklenen olum should be 74.7 from saps
	And saps score should appear in dashboard page