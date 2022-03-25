Feature: TF4_VitalBulgular
add, remove, validate process about Vital Bulgular


Background: 
	Given the user logged into the system
	And the user locates to vital bulgular page

Scenario: Vital Bulgular
	When the user sets vital bulgular
	Then the vital bulgular should appear in table by left side
	When the user validates vital bulgular by right side and removes vital bulgular
	Then vital bulgular should not appear in right and left side table.

