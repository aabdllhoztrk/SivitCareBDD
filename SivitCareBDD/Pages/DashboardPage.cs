using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SivitCareBDD.Pages
{
    public class DashboardPage : BasePage
    {
        public DashboardPage(IWebDriver driver) : base(driver)
        {
        }
        /// <summary>
        /// Apache Skorlama
        /// </summary>
        private IWebElement btn_Apache => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[1]/div/div[3]/app-score-card/div/div[1]/div[2]/button");
        private IWebElement txt_Yas => FindElementByXPath("//input[@formcontrolname='Age']");
        private IWebElement txt_Vucutİsisi => FindElementByXPath("//input[@formcontrolname='Temp']");
        private IWebElement txt_OrtKanBasinci => FindElementByXPath("//input[@formcontrolname='MeanArterialPressure']");
        private IWebElement txt_OrtalamSolunumHizi => FindElementByXPath("//input[@formcontrolname='RespiratoryRate']");
        private IWebElement txt_Serum => FindElementByXPath("//input[@formcontrolname='SerumHCO3']");
        private IWebElement txt_Sodyum => FindElementByXPath("//input[@formcontrolname='Sodium']");
        private IWebElement txt_Ph => FindElementByXPath("//input[@formcontrolname='ArterialPh']");
        private IWebElement txt_Potasyum => FindElementByXPath("//input[@formcontrolname='Potassium']");
        private IWebElement txt_KalpHizi => FindElementByXPath("//input[@formcontrolname='HeartRate']");
        private IWebElement txt_Kreatinin => FindElementByXPath("//input[@formcontrolname='Creatinine']");
        private IWebElement txt_Hematokrit => FindElementByXPath("//input[@formcontrolname='Hematocrit']");
        private IWebElement txt_Glaskow => FindElementByXPath("//input[@formcontrolname='GlasgowComaScale']");
        private IWebElement txt_BeyazKan => FindElementByXPath("//input[@formcontrolname='Wbc']");
        private IWebElement txt_Fio2 => FindElementByXPath("//input[@formcontrolname='Fio2']");
        private IWebElement txt_PaO2 => FindElementByXPath("//input[@formcontrolname='O2']");
        private IWebElement btn_ApacheHesapla => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-primary']");
        private IWebElement btn_ApacheKaydet => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-accent ng-star-inserted']");
        private IWebElement validateApacheSkor => FindElementByXPath("//li[contains(text(),'Apache Skor: 16')]");
        private IWebElement validateApacheBeklenenOlum => FindElementByXPath("//li[contains(text(),'Beklenen Ölüm: 23.5')]");
        private IWebElement validateApacheSkoronDeshboard => FindElementByXPath("//div[text()='16']");

        /// <summary>
        /// Glaskow Skorlama
        /// </summary>
        private IWebElement btn_Glaskow => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[1]/div/div[2]/app-score-card/div/div[1]/div[2]/button");
        private IWebElement spontanAcik => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-glaskow-dialog/div[1]/mat-radio-group/mat-radio-button[1]/label/span[1]");
        private IWebElement oryante => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-glaskow-dialog/div[2]/mat-radio-group/mat-radio-button[1]/label/span[1]");
        private IWebElement cevapYok => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-glaskow-dialog/div[3]/mat-radio-group/mat-radio-button[6]/label/span[1]");
        private IWebElement btn_GlaskowKydet => FindElementByXPath("(//BUTTON[@mat-raised-button=''])[1]");
        private IWebElement validateGlaskowSkoronDeshboard => FindElementByXPath("//div[text()='10']");

        /// <summary>
        /// Egrf Skorlama
        /// </summary>
        private IWebElement btn_Egrf => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[1]/div/div[6]/app-score-card/div/div[1]/div[2]/button");
        private IWebElement txt_EgrfYas => FindElementByXPath("//input[@data-placeholder='Yaş']");
        private IWebElement txt_Creatinine => FindElementByXPath("//input[@data-placeholder='Creatinine']");
        private IWebElement btn_EgrfHesapla => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-primary']");
        private IWebElement btn_EgrfKaydet => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-accent ng-star-inserted']");
        private IWebElement validateEgrfSkor => FindElementByXPath(".//td[.//text()[contains(., '1,13')]]");
        private IWebElement validateEgrfSkoronDeshboard => FindElementByXPath("//div[text()='1.13']");


        /// <summary>
        /// Sofa skorlama
        /// </summary> 
        private IWebElement btn_Sofa => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[1]/div/div[5]/app-score-card/div/div[1]/div[2]/button");
        private IWebElement txt_SofaPao2 => FindElementByXPath("//input[@formcontrolname='pao2']");
        private IWebElement txt_Fio => FindElementByXPath("//input[@formcontrolname='fio2']");
        private IWebElement txt_Platelest => FindElementByXPath("//input[@formcontrolname='platelets']");
        private IWebElement txt_Billirubin => FindElementByXPath("//input[@formcontrolname='bilirubin']");
        private IWebElement txt_OrtArterBasinci => FindElementByXPath("//input[@formcontrolname='meanArterialPressure']");
        private IWebElement txt_SofaIdrarCikisi => FindElementByXPath("//input[@formcontrolname='urineOutput']");
        private IWebElement txt_GloskowKoma => FindElementByXPath("//input[@formcontrolname='glasgowComaScale']");
        private IWebElement txt_SofaKreatinin => FindElementByXPath("//input[@formcontrolname='creatinine']");
        private IWebElement vantilatorTuru => FindElementByXPath("//span[contains(text(),'MV')]");
        private IWebElement btn_SofaHesapla => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-primary']");
        private IWebElement btn_SofaKaydet => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-accent ng-star-inserted']");
        private IWebElement validatesofaSkor => FindElementByXPath("//li[text()='Sofa Skor: 3']");
        private IWebElement validatebeklenenOlum => FindElementByXPath("//li[text()='Beklenen Ölüm: < 10%']");
        private IWebElement validatesofaSkoronDashboard => FindElementByXPath("//div[text()='3']");


        /// <summary>
        /// Saps Skorlama
        /// </summary>
        private IWebElement btn_SapsCinsiyet => FindElementByXPath("//span[contains(text(),'Erkek')]");
        private IWebElement btn_Saps => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[1]/div/div[4]/app-score-card/div/div[1]/div[2]/button");
        private IWebElement txt_SapsYas => FindElementByXPath("//input[@formcontrolname='Age']");
        private IWebElement txt_SapsKalpHizi => FindElementByXPath("//input[@formcontrolname='HeartRate']");
        private IWebElement txt_Sistolik => FindElementByXPath("//input[@formcontrolname='SystolicBloodPressure']");
        private IWebElement txt_VucutIsisi => FindElementByXPath("//input[@formcontrolname='Temperature']");
        private IWebElement txt_SapsFio2 => FindElementByXPath("//input[@formcontrolname='Fio2']");
        private IWebElement txt_SapsPao2 => FindElementByXPath("//input[@formcontrolname='PaO2']");
        private IWebElement txt_GlaskowKoma => FindElementByXPath("//input[@formcontrolname='GlasgowComaScale']");
        private IWebElement txt_IdrarCikisi => FindElementByXPath("//input[@formcontrolname='UrineOutput']");
        private IWebElement txt_SapsSodyum => FindElementByXPath("//input[@formcontrolname='Sodium']");
        private IWebElement txt_SapsPotasyum => FindElementByXPath("//input[@formcontrolname='Potassium']");
        private IWebElement txt_Billrubin => FindElementByXPath("//input[@formcontrolname='Bilirubin']");
        private IWebElement txt_Wbc => FindElementByXPath("//input[@formcontrolname='WBC']");
        private IWebElement txt_Hco3 => FindElementByXPath("//input[@formcontrolname='HCO3']");
        private IWebElement txt_Ure => FindElementByXPath("//input[@formcontrolname='Urea']");
        private IWebElement yattigiBolum => FindElementByXPath("//span[contains(text(),'Acil Servis')]");
        private IWebElement klinikKatagori => FindElementByXPath("//span[contains(text(),'Dahili Hasta')]");
        private IWebElement yatisSekli => FindElementByXPath("//span[contains(text(),'Plansız')]");
        private IWebElement ventilatorTuru => FindElementByXPath("//span[contains(text(),'MV')]");
        private IWebElement zehirlenme => FindElementByXPath("//span[contains(text(),'Var')]");
        private IWebElement btn_SapsHesapla => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-primary']");
        private IWebElement btn_SapsKaydet => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-accent ng-star-inserted']");
        private IWebElement validateSapsSkor => FindElementByXPath("//li[text()='Saps Skor: 102']");
        private IWebElement validateSapsBeklenenOlum => FindElementByXPath("//li[text()='Beklenen Ölüm: 74.7']");
        private IWebElement validateSapsSkoronDashboard => FindElementByXPath("//div[text()='102']");
        private IWebElement btn_Carsaf => FindElementByXPath("//div[text()='Çarşaf']");
        private IWebElement btn_Dashboard => FindElementByXPath("//div[text()='Dashboard']");

        /// <summary>
        /// Boy Kilo Değiştirme
        /// </summary>
        private IWebElement kilo_onDashboard => FindElementByXPath("//span[contains(text(),'Kilo')]");
        private IWebElement boy_onDashboard => FindElementByXPath("//span[contains(text(),'Boy 169')]");
        private IWebElement txt_Boy => FindElementByXPath("//input[@data-placeholder='170']");
        private IWebElement txt_Kilo => FindElementByXPath("//input[@data-placeholder='70']");
        private IWebElement btn_BoyKiloKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");

        /// <summary>
        /// Basamak Sec
        /// </summary>
        private IWebElement btn_Basamak => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[3]/app-basamak/div[1]/div/button");
        private IWebElement selectBasamak => FindElementById("mat-radio-2");
        private IWebElement btn_BasamakKaydet => FindElementByXPath("(//BUTTON[@mat-raised-button=''])[1]");
        private IWebElement validateBasamak1 => FindElementByXPath("//span[contains(text(),'1. derece')]");

        /// <summary>
        /// Bilic Sec
        /// </summary>
        private IWebElement btn_Bilinc => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[3]/app-basamak/div[2]/div/button");
        private IWebElement selectStupor => FindElementByXPath("(//SPAN[@class='mat-radio-container'])[4]");
        private IWebElement btn_BilincKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        private IWebElement validateBilinc => FindElementByXPath("//span[contains(text(),'Stupor')]");

        /// <summary>
        /// İnvaziv Ekleme
        /// </summary>
        private IWebElement btn_InvalizEkle => FindElementByXPath("//button[@class='mat-focus-indicator icon-button-small mat-icon-button mat-button-base'][2]");
        private IWebElement txt_TupNo => FindElementByXPath("//input[@data-placeholder='Tüp No']");
        private IWebElement invaziGirisimDropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-invasiv-dialog/div[3]/mat-form-field/div/div[1]/div/mat-select");
        private IWebElement txt_Endotrakeal => FindElementByXPath("//span[contains(text(),' Endotrakeal Tüp')]");
        private IWebElement btn_InvaziKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        private IWebElement onayYes => FindElementByXPath("//span[contains(text(),'Yes')]");
        private IWebElement validateBasamak3 => FindElementByXPath("//span[contains(text(),'3. derece')]");
        private IWebElement tabHemsireIslemleri => FindElementByXPath("//div[contains(text(),'Hemşire İşlemleri')]");
        private IWebElement btn_InvazivGirisimler => FindElementByXPath("//i[contains(@class,'invaziv')]");
        private IWebElement validateTarih => FindElementByXPath("//div[contains(text(),'Şu anda')]");
        private IWebElement validateTupNo => FindElementByXPath("//div[contains(text(),'1589')]");
        private IWebElement validateInvaziGiris => FindElementByXPath("//div[contains(text(),'Endotrakeal Tüp')]");
        private IWebElement btn_InvazivSil => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-invaziv/div[2]/table/tbody/mat-row/mat-cell[1]/div/button[2]");
        private IWebElement defaultyes => FindElementByXPath("//span[contains(text(),'Yes')]");

        /// <summary>
        /// Apache Methodlari
        /// </summary>
        /// 
        public void calculateApache()
        {

            Thread.Sleep(2000);
            btn_Apache.Click();
            sendKeys(txt_Yas, "45");
            sendKeys(txt_Vucutİsisi, "39");
            sendKeys(txt_OrtKanBasinci, "75");
            sendKeys(txt_OrtalamSolunumHizi, "20");
            //txt_Serum.SendKeys("25");
            sendKeys(txt_Sodyum, "137");
            sendKeys(txt_Ph, "7");
            sendKeys(txt_Potasyum, "4");
            sendKeys(txt_KalpHizi, "65");
            sendKeys(txt_Kreatinin, "0.74");
            sendKeys(txt_Hematokrit, "36");
            sendKeys(txt_Glaskow, "10");
            sendKeys(txt_BeyazKan, "4");
            sendKeys(txt_Fio2, "50");
            sendKeys(txt_PaO2, "150");
            btn_ApacheHesapla.Click();

        }
        public void ValidateApacheScore() => ValidateScoreResults(validateApacheSkor);
        public void ValidateBekleneOlum() => ValidateScoreResults(validateApacheBeklenenOlum);

        public void ValidateApacheScoreinDashboard()
        {
            btn_ApacheKaydet.Click();
            ValidateScoreResults(validateApacheSkoronDeshboard);
        }

        /// <summary>
        /// Glaskow Methodlari
        /// </summary>
        public void CalculateGlaskow()
        {
            Thread.Sleep(1000);
            btn_Glaskow.Click();
            spontanAcik.Click();
            oryante.Click();
            cevapYok.Click();
            btn_GlaskowKydet.Click();
        }
        public void ValidateGlaskowonDeshboard() => ValidateScoreResults(validateGlaskowSkoronDeshboard);

        /// <summary>
        /// egrf methodlari
        /// </summary>
        public void CalculateEgrf()
        {
            Thread.Sleep(1000);
            btn_Egrf.Click();
            sendKeys(txt_EgrfYas, "18");
            sendKeys(txt_Creatinine, "50");
            btn_EgrfHesapla.Click();
            Thread.Sleep(1000);
            btn_EgrfKaydet.Click();
            Thread.Sleep(1000);
        }
        public void ValidateEgrfScore() => ValidateScoreResults(validateEgrfSkor);
        public void ValidateEgrfonDashboard() => ValidateScoreResults(validateEgrfSkoronDeshboard);
        
        /// <summary>
        /// Sofa methodları
        /// </summary>
        public void calculateSofa()
        {
            Thread.Sleep(2000);
            btn_Sofa.Click();
            Thread.Sleep(200);
            sendKeys(txt_SofaPao2, "90");
            sendKeys(txt_Fio, "20");
            sendKeys(txt_Platelest, "160");
            sendKeys(txt_Billirubin, "1.1");
            sendKeys(txt_OrtArterBasinci, "75");
            sendKeys(txt_SofaIdrarCikisi, "400");
            sendKeys(txt_GloskowKoma, "15");
            sendKeys(txt_SofaKreatinin, "1.1");
            vantilatorTuru.Click();
            btn_SofaHesapla.Click();                                  
        }
        public void  ValidateSofaScore() => ValidateScoreResults(validatesofaSkor);

        public void ValidateBeklenenOlumfromSofa()
        {
            ValidateScoreResults(validatebeklenenOlum);
            btn_SofaKaydet.Click();
        }
        public void ValidateSofaonDashboard() => ValidateScoreResults(validatesofaSkoronDashboard);

        /// <summary>
        /// Saps Methodlari 
        /// </summary>
        public void CalculateSaps()
        {
            Thread.Sleep(2000);
            btn_Saps.Click();
            btn_SapsCinsiyet.Click();
            sendKeys(txt_SapsYas, "38");
            sendKeys(txt_SapsKalpHizi, "38");
            sendKeys(txt_Sistolik, "65");
            sendKeys(txt_VucutIsisi, "38");
            sendKeys(txt_SapsFio2, "2");
            sendKeys(txt_SapsPao2, "100");
            sendKeys(txt_GlaskowKoma, "5");
            sendKeys(txt_IdrarCikisi, "0.4");
            sendKeys(txt_SapsSodyum, "147");
            sendKeys(txt_SapsPotasyum, "2");
            sendKeys(txt_Billrubin, "3");
            sendKeys(txt_Wbc, "888000");
            sendKeys(txt_Hco3, "13");
            sendKeys(txt_Ure, "9.77");
            yattigiBolum.Click();
            klinikKatagori.Click();
            yatisSekli.Click();
            ventilatorTuru.Click();
            zehirlenme.Click();
            btn_SapsHesapla.Click();           
        }
        public void ValidateSapsScore() => ValidateScoreResults(validateSapsSkor);
        public void ValidateBeklenenOlumfromSaps() 
        {
            ValidateScoreResults(validateSapsBeklenenOlum);
            btn_SapsKaydet.Click();
            Thread.Sleep(700);
        }
        public void ValidateSapsonDashboard() => ValidateScoreResults(validateSapsSkoronDashboard);

        /// <summary>
        /// Boy Kilo Methodları
        /// </summary>
        public void SetBoyKilo()
        {
            Thread.Sleep(2000);
            kilo_onDashboard.Click();
            sendKeys(txt_Kilo, "70");
            sendKeys(txt_Boy, "169");
            btn_BoyKiloKaydet.Click();
            ValidateElementExist(boy_onDashboard, "Boy 169");
            ValidateElementExist(kilo_onDashboard, "Kilo 70");
        }
        public void ValidateBoyKiloonDashboard() 
        {
            ValidateElementExisting(boy_onDashboard);
            ValidateElementExisting(kilo_onDashboard);
        }

        /// <summary>
        /// Basamak Methodaları
        /// </summary>
        public void SetBasamak()
        {
            Thread.Sleep(2000);
            btn_Basamak.Click();
            Thread.Sleep(2000);
            selectBasamak.Click();
            btn_BasamakKaydet.Click();
        }
        public void ValidateBasamakonDashboard() 
        {
            ValidateElementExisting(validateBasamak1);
            Thread.Sleep(4000);
        }

        /// <summary>
        /// Bilinc Methodları
        /// </summary>
        public void SetBilinc()
        {
            Thread.Sleep(2000);
            btn_Bilinc.Click();
            Thread.Sleep(3000);
            selectStupor.Click();
            btn_BilincKaydet.Click();           
        }
        public void ValidateBilinconDashboard() 
        {
            ValidateElementExisting(validateBilinc);
            Thread.Sleep(2000);
        }

        /// <summary>
        /// İnvaziv Methodları
        /// </summary>
        public void SetInvaziv()
        {
            btn_InvalizEkle.Click();
            sendKeys(txt_TupNo, "1589");
            invaziGirisimDropDown.Click();
            txt_Endotrakeal.Click();
            btn_InvaziKaydet.Click();
            onayYes.Click();            
        }
        public void ValidateBasamakAfterInvazivonDashboard() 
        {
            ValidateElementExisting(validateBasamak3);
            Thread.Sleep(3000);
        }

        public void ValidateInvazivinInvazivGirisimlerPage() 
        {
            tabHemsireIslemleri.Click();
            Thread.Sleep(1000);
            btn_InvazivGirisimler.Click();
            ValidateElementExisting(validateTarih);
            ValidateElementExisting(validateTupNo);
            ValidateElementExisting(validateInvaziGiris);
        }

        public void RemoveInvaziv() 
        {
            btn_InvazivSil.Click();
            defaultyes.Click();
        }

        public void ValidatenotExistInvaziv() 
        {
            ValidateElementNotExist("Tarih:", "//div[contains(text(),'Şu anda')]");
            ValidateElementNotExist("TüpNo:20", "//div[contains(text(),'1589')]");
        }
    }
}
