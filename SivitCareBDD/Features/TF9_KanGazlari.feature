Feature: TF9_KanGazlari
	add, validate, remove Kan Gazlari on kan kazları page under vital bulgular


Background: 
	Given the user logged into the system
	And the user locates to kan gazlari page

Scenario: Kan Gazlari
	When the user sets kan gazlari
	Then kan gazlari should appear in table by left side
	When the user validates kan gazlari by right side and removes kan gazlari
	Then kan gazlari should not appear in right and left side table.
