Feature: TF5_HemsireIslemleri
	This feature contains some process like agri takibi, basi yarasi, hareket kisitlama islemleri under the hemsire islemleri tab.

Background: 
	Given the user logged into the system
	And the user locates to hemsire islemleri page

Scenario: Agri Takibi
	When the user sets agri takibi
	Then yuz sklasi agri durumu pupil skalasi should appear on top of table
	When the user removes agri takibi 
	Then agri takibi should not appear in agri takibi page

Scenario: Basi Yarasi
	When the user sets basi yarasi
	Then bolge evre and boyut should appear on the patient card
	When the user sets yara bakimi
	Then sonuc degerlendirme and boyut should appear on right side table
	When the user removes basi yarası card
	Then basi yarası card and yara bakimi should not appear on page

Scenario: Cilt Tanimlama
	When the user sets cilt tanimlama
	Then deger acıklama and agrı skalasi should appear top of table
	When the user removes cilt tanimlama
	Then deger and agrı skalasi should not appear top of table

Scenario: Hareket Kisitlama
	When the user sets hareket kisitlama
	Then alinan onlemler kisitlama nedenleri kisitlama bolgesi should appear top of table
	When the user takes out hareket Kisitlama
	Then kisitlamadan dolayi zarar olustu should appear top of table
	When the user deletes hareket Kisitlama
	Then hareket kisitlama should not appear on top of table

Scenario: Hasta Nitrusyon
	When the user sets hasta nitrusyon
	Then oral should appear top of table
	When the user removes hasta nitrusyo
	Then oral should not appear top of table

Scenario: Hasta Izolasyonu
	When the user sets hasta izalasyonu as yok
	Then izalasyon ihtiyaci should appear as yok top of table
	When the user edits hasta izalasyonu
	Then izalasyon ihtiyaci should appear as var top of table
	And izalasyon sekli should appear as temas top of table
	When the user remove hasta izalasyonu
	Then hasta izolasyonu should not appear top of table

Scenario: Hemsire Degerlendirme
	When the user sets hemsire degerlendirme
	Then degerlendrme notu should appear as hasta uyuyor
	When the user edits hemsire degerkendirme as hasta kalkti
	Then degerlendrme notu should appear as hasta kalti
	When the user remove hemsire degerlendirme
	Then hemsire degerlendirme should not appear top of table

Scenario: İnvaziv Girisimler
	When the user sets invaziv girisimler
	Then tupNo should appear as 1258
	And invaziv girisim should appear as peg
	When the user takes out invaziv girisimler
	Then cikaran should appear as abdullah öztürk
	And aciklma should appear as denemetest
	When the user edits invaziv girisimler
	Then tupNo should appear As 1259
	And invaziv girisim should appear as foley sonda
	When the user removes invaziv girisim
	Then invaziv girisim should not appear on the page