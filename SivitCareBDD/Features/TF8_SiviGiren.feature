Feature: TF8_SiviGiren
	add, validate, remove sivigiren on sivi giren page under vital bulgular

Background: 
	Given the user logged into the system
	And the user locates to sivi giren page

Scenario: Sivi Giren GirenSivi
	When the user sets girenSivi
	Then the girenSivi emount should appear in right and left table
	When the user removes girenSivi
	Then girenSivi should not appear in right and left table

Scenario: Sivi Giren Oral Verilen Sivi
	When the user sets oral verilen sivi
	Then oral verilen sivi amount should appear in right and left table
	When the user removes oral verilen sivi
	Then oral verilen sivi should not appear in right and left table

