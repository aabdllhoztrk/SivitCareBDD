using OpenQA.Selenium;
using SivitCareBDD.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SivitCareBDD.Steps
{
    [Binding]
    public sealed class HemsireIslemleriSteps
    {

        private readonly IWebDriver _driver;
        private  HemsireIslemleriPage _hemsireIslemleriPage;
        private readonly ScenarioContext _scenarioContext;

        public HemsireIslemleriSteps(ScenarioContext injectedContex)
        {
            _scenarioContext = injectedContex;
            _driver = _scenarioContext.Get<IWebDriver>("currentDriver");
            _hemsireIslemleriPage = new HemsireIslemleriPage(_driver);
        }

        /// <summary>
        /// Agri takibi steps
        /// </summary>
        [When(@"the user sets agri takibi")]
        public void WhenTheUserSetsAgriTakibi()
        {
            _hemsireIslemleriPage.SetAgriTakibi();
        }

        [Then(@"yuz sklasi agri durumu pupil skalasi should appear on top of table")]
        public void ThenYuzSklasiAgriDurumuPupilSkalasiShouldAppearOnTopOfTable()
        {
            _hemsireIslemleriPage.ValidateAgriTakibi();
        }

        [When(@"the user removes agri takibi")]
        public void WhenTheUserRemovesAgriTakibi()
        {
            _hemsireIslemleriPage.AgriTakibiSil();
        }

        [Then(@"agri takibi should not appear in agri takibi page")]
        public void ThenAgriTahibiShouldNotAppearİnAgriTakibiPage()
        {
            _hemsireIslemleriPage.ValidateaAgriTakibinotExist();
        }

        /// <summary>
        /// Bası yarası ve yara bakımı steps
        /// </summary>
        [When(@"the user sets basi yarasi")]
        public void WhenTheUserSetsBasiYarasi()
        {
            _hemsireIslemleriPage.SetBasiYarasi();
            
        }

        [Then(@"bolge evre and boyut should appear on the patient card")]
        public void ThenBolgeEvreAndBoyutShouldAppearOnThePatientCard()
        {
            _hemsireIslemleriPage.ValidateBasiYarasi();
        }

        [When(@"the user sets yara bakimi")]
        public void WhenTheUserSetsYaraBakimi()
        {
            _hemsireIslemleriPage.SetYaraBakimi();
        }

        [Then(@"sonuc degerlendirme and boyut should appear on right side table")]
        public void ThenSonucDegerlendirmeAndBoyutShouldAppearOnRightSideTable()
        {
            _hemsireIslemleriPage.ValidateYaraBakimi();
        }

        [When(@"the user removes basi yarası card")]
        public void WhenTheUserRemovesBasiYarasıCard()
        {
            _hemsireIslemleriPage.BasiYarasiSil();
        }

        [Then(@"basi yarası card and yara bakimi should not appear on page")]
        public void ThenBasiYarasıCardAndYaraBakimiShouldNotAppearOnPage()
        {
            _hemsireIslemleriPage.ValidateBasiYarasiandYaraBakiminotExist();
        }

        /// <summary>
        /// Cilt Tanımlama Steps
        /// </summary>
        [When(@"the user sets cilt tanimlama")]
        public void WhenTheUserSetsCiltTanimlama()
        {
            _hemsireIslemleriPage.SetCiltTanimlama();
        }

        [Then(@"deger acıklama and agrı skalasi should appear top of table")]
        public void ThenDegerAcıklamaAndAgrıSkalasiShouldAppearTopOfTable()
        {
            _hemsireIslemleriPage.ValidateCiltTanimlama();

        }

        [When(@"the user removes cilt tanimlama")]
        public void WhenTheUserRemovesCiltTanimlama()
        {
            _hemsireIslemleriPage.CiltTanimlamaSil();
        }

        [Then(@"deger and agrı skalasi should not appear top of table")]
        public void ThenDegerAndAgrıSkalasiShouldNotAppearTopOfTable()
        {
            _hemsireIslemleriPage.ValidateCiltTanimlamanotExist();
        }

        /// <summary>
        /// Hareket kısıtlama stepleri
        /// </summary>
        [When(@"the user sets hareket kisitlama")]
        public void WhenTheUserSetsHareletKisitlama()
        {
            _hemsireIslemleriPage.SetHareketKisitlama();
        }

        [Then(@"alinan onlemler kisitlama nedenleri kisitlama bolgesi should appear top of table")]
        public void ThenAlınanOnlemlerKisitlamaNedenleriKisitlamaBolgesiShouldAppearTopOfTable()
        {
            _hemsireIslemleriPage.ValidateHareketKisitlama();
        }

        [When(@"the user takes out hareket Kisitlama")]
        public void WhenTheUserTakesOutHareketKisitlama()
        {
            _hemsireIslemleriPage.RemoveHareketKisitlama();
        }

        [Then(@"kisitlamadan dolayi zarar olustu should appear top of table")]
        public void ThenKisitlamadanDolayiZararOlustuShouldAppearTopOfTable()
        {
            _hemsireIslemleriPage.ValidateReasonofRemovedHareketKisitlama(); ;
        }

        [When(@"the user deletes hareket Kisitlama")]
        public void WhenTheUserDeletesHareketKisitlama()
        {
            _hemsireIslemleriPage.DeleteHareketKisitlama();
        }

        [Then(@"hareket kisitlama should not appear on top of table")]
        public void ThenHareketKisitlamaShouldNotAppearOnTopOfTable()
        {
            _hemsireIslemleriPage.ValidateHareketKisitlamanotExist();
        }

        /// <summary>
        /// Hasta Nitrusyon Steeps
        /// </summary>
        [When(@"the user sets hasta nitrusyon")]
        public void WhenTheUserSetsHastaNitrusyon()
        {
            _hemsireIslemleriPage.SetHastaNitrusyon();
        }

        [Then(@"oral should appear top of table")]
        public void ThenOralShouldAppearTopOfTable()
        {
            _hemsireIslemleriPage.ValiadreHastaNitrusyonExist();
        }

        [When(@"the user removes hasta nitrusyo")]
        public void WhenTheUserRemovesHastaNitrusyo()
        {
            _hemsireIslemleriPage.RemoveHastaNitrusyon();
        }

        [Then(@"oral should not appear top of table")]
        public void ThenOralShouldNotAppearTopOfTable()
        {
            _hemsireIslemleriPage.ValidateHastaNitrusyonnotExist();
        }

        /// <summary>
        /// Hasta izolasyonları steps
        /// </summary>
        [When(@"the user sets hasta izalasyonu as yok")]
        public void WhenTheUserSetsHastaİzalasyonuAsYok()
        {
            _hemsireIslemleriPage.SetHastaIzalasyonu();
        }

        [Then(@"izalasyon ihtiyaci should appear as yok top of table")]
        public void ThenİzalasyonİhtiyaciShouldAppearAsYokTopOfTable()
        {
            _hemsireIslemleriPage.ValidateIzolasyonIhtiyaciasYok();
        }

        [When(@"the user edits hasta izalasyonu")]
        public void WhenTheUserEditsHastaİzalasyonu()
        {
            _hemsireIslemleriPage.EditHastaIzolasyonu();
        }

        [Then(@"izalasyon ihtiyaci should appear as var top of table")]
        public void ThenİzalasyonİhtiyaciShouldAppearAsVarTopOfTable()
        {
            _hemsireIslemleriPage.ValidateHastaIzalasyonuasVar();
        }

        [Then(@"izalasyon sekli should appear as temas top of table")]
        public void ThenİzalasyonSekliShouldAppearAsTemasTopOfTable()
        {
            _hemsireIslemleriPage.ValidateHastaIzalasyonSekli();
        }

        [When(@"the user remove hasta izalasyonu")]
        public void WhenTheUserRemoveHastaİzalasyonu()
        {
            _hemsireIslemleriPage.HastaIzalasyonuSil();
        }

        [Then(@"hasta izolasyonu should not appear top of table")]
        public void ThenHastaİzolasyonuShouldNotAppearTopOfTable()
        {
            _hemsireIslemleriPage.ValidateHastaIzolasyonunotExist();
        }

        /// <summary>
        /// hemsire degerlendirme steps
        /// </summary>
        [When(@"the user sets hemsire degerlendirme")]
        public void WhenTheUserSetsHemsireDegerlendirme()
        {
            _hemsireIslemleriPage.SetHemsireDegerlendirme();
        }

        [Then(@"degerlendrme notu should appear as hasta uyuyor")]
        public void ThenDegerlendrmeNotuShouldAppearAsHastaUyuyor()
        {
            _hemsireIslemleriPage.ValidateHemsireDegerlendirmeNotu();
        }

        [When(@"the user edits hemsire degerkendirme as hasta kalkti")]
        public void WhenTheUserEditsHemsireDegerkendirmeAsHastaKalkti()
        {
            _hemsireIslemleriPage.EditHemsireDegerlendirme();
        }

        [Then(@"degerlendrme notu should appear as hasta kalti")]
        public void ThenDegerlendrmeNotuShouldAppearAsHastaKalti()
        {
            _hemsireIslemleriPage.ValidateHemsireDegerlendirmeNotuAfterEdit();
        }

        [When(@"the user remove hemsire degerlendirme")]
        public void WhenTheUserRemoveHemsireDegerlendirme()
        {
            _hemsireIslemleriPage.RemoveHemsireDegerlendirme();
        }

        [Then(@"hemsire degerlendirme should not appear top of table")]
        public void ThenHemsireDegerlendirmeShouldNotAppearTopOfTable()
        {
            _hemsireIslemleriPage.ValidateHemsireDegerlendirmenotExist();
        }

        /// <summary>
        /// Invaziv Girismler Steps
        /// </summary>
        [When(@"the user sets invaziv girisimler")]
        public void WhenTheUserSetsİnvazivGirisimler()
        {
            _hemsireIslemleriPage.SetInvazivGirisimler();
        }

        [Then(@"tupNo should appear as (.*)")]
        public void ThenTupNoShouldAppearAs(int p0)
        {
            _hemsireIslemleriPage.ValidateTupNo();
        }

        [Then(@"invaziv girisim should appear as peg")]
        public void ThenİnvazivGirisimShouldAppearAsPeg()
        {
            _hemsireIslemleriPage.ValiateInvazivGirisim();
        }

        [When(@"the user takes out invaziv girisimler")]
        public void WhenTheUserTakesOutİnvazivGirisimler()
        {
            _hemsireIslemleriPage.TakeoutInvazivGirisim();
        }

        [Then(@"cikaran should appear as abdullah öztürk")]
        public void ThenCıkaranShouldAppearAsAbdullahOzturk()
        {
            _hemsireIslemleriPage.ValiateCikaran();
        }

        [Then(@"aciklma should appear as denemetest")]
        public void ThenAciklmaShouldAppearAsDenemetest()
        {
            _hemsireIslemleriPage.ValiateAciklama();
        }

        [When(@"the user edits invaziv girisimler")]
        public void WhenTheUserEditsİnvazivGirisimler()
        {
            _hemsireIslemleriPage.EditInvazivGirisimler();
        }

        [Then(@"tupNo should appear As (.*)")]
        public void ThenTupNoShouldAppearAss(int p0)
        {
            _hemsireIslemleriPage.ValidateTupNoAfterEdit();
        }


        [Then(@"invaziv girisim should appear as foley sonda")]
        public void ThenİnvazivGirisimShouldAppearAsFoleySonda()
        {
            _hemsireIslemleriPage.ValiateInvazivGirisimAfterEdit();
        }

        [When(@"the user removes invaziv girisim")]
        public void WhenTheUserRemovesİnvazivGirisim()
        {
            _hemsireIslemleriPage.RemoveInvazivGirisimler();
        }

        [Then(@"invaziv girisim should not appear on the page")]
        public void ThenİnvazivGirisimShouldNotAppearOnThePage()
        {
            _hemsireIslemleriPage.ValidateInvazivGirisimlernotExist();
        }

    }
}
