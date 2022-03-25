Feature: TF3_Dashboard
	this feature contains some scenerios like changing weight-height, add diagnosis on Dashboard Page.

Background: 
	Given the user logged into the system
	And the user locates to patient dashboard page

# Girdi: Boy 169 , Kilo 70
Scenario: Boy Kilo Ayarla
	When the user set weight and height 
	Then weight and height should appear in dashboard page

# Girdi: 1. Basamak
Scenario: Basamak Ayarla
	When the user sets basamak 
	Then basamak should appear in dashboard page

# Girdi: Stupor
Scenario: Bilinc Ayarla
	When the user sets bilinc 
	Then bilinc should appear in dashboard page

# Girdi: Tüp No: 1589, invaziv girişim: Endotrakeal Tüp
Scenario: İnvaziv Ayarla
	When the user sets invaziv 
	Then basamak should set "3. basamak" and appear in deshboard page
	And tup no and type of invaziv should appear in invaziv girisimler page under hemsire islemleri tab
	When the user removes invaziv from invaziv girisimler page
	Then invaziv should not appear in invaziv girisimler page
