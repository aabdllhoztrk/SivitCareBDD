Feature: 10_Laboratuvar
	add, validate, remove vitals on laboratuvar page under vital bulgular tab

Background: 
	Given the user logged into the system
	And the user locates to Laboratuvar page

Scenario: Laboratuvar
	When the user sets vitals on  laboratuvar page
	Then vitals should appear in table by left side
	When the user validates vitals by right side and removes vitals
	Then vitals should not appear in right and left side table
