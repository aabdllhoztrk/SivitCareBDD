Feature: TF7_SiviCikan
	add, validate, remove sivicikan on sivi cikan page under vital bulgular

Background: 
	Given the user logged into the system
	And the user locates to sivi cikan page

Scenario: Sivi Cikan Idrar
	When the user sets idrar
	Then the idrar emount should appear in right and left table
	When the user removes idrar
	Then idrar should not appear in right and left table

Scenario: Sivi Cikan Kusma
	When the user sets kusma
	Then the kusma emount should appear in right and left table
	When the user removes kusma
	Then kusma should not appear in right and left table

Scenario: Sivi Cikan Defekasyon
	When the user sets defekasyon
	Then the defekasyon emount should appear in right and left table
	When the user removes defekasyon
	Then defekasyon should not appear in right and left table