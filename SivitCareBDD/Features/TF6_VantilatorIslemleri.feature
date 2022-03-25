Feature: TF6_VantilatorIslemleri
	Add, Remove, Valiadation process on vantilator page under Vital Bulgular 

Background: 
	Given the user logged into the system
	And the user locates to ventilator page

Scenario: Ventilator Islemleri
	When the user sets ventilator
	Then the ventilators should appear in table by left side
	When the user validates ventilators by right side and removes ventilators
	Then ventilators should not appear in right and left side table.