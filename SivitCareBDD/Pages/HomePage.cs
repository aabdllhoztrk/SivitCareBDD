using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SivitCareBDD.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }
        private IWebElement validate_UserName => FindElementByXPath("//SPAN[text()='abdullah öztürk']");
        private IWebElement patient => FindElementByXPath("//span[contains(text(),'Leone')]");
        private IWebElement ServisDegistir => FindElementByXPath("/html/body/app-root/main-app/div/karmed-headerbar/karmed-statusbar/mat-toolbar/button[4]");
        private IWebElement btn_CerrahiYogunBakim => FindElementByXPath("//SPAN[text()='Cerrahi Yoğun Bakım Servisi']");
        private IWebElement tabVitalBulgular => FindElementByXPath("//div[contains(text(),'Vital Bulgular')]");
        private IWebElement tabHemsireIslemleri => FindElementByXPath("//div[contains(text(),'Hemşire İşlemleri')]");
        private IWebElement tabHizmetIsleme => FindElementByXPath("//div[contains(text(),'Hizmet İşleme')]");
        private IWebElement btn_menuBar => FindElementByXPath("//button[@class='mat-focus-indicator mat-menu-trigger mat-icon-button mat-button-base']");
        private IWebElement secventilator => FindElementByXPath("//SPAN[text()='VENTİLATÖR']");
        private IWebElement secSiviGiren => FindElementByXPath("//SPAN[text()='SIVI GİREN']");
        private IWebElement secSiviCikan => FindElementByXPath("//SPAN[text()='SIVI ÇIKAN']");
        private IWebElement secKanGazlari => FindElementByXPath("//SPAN[text()='KAN GAZLARI']");
        private IWebElement secLab => FindElementByXPath("//SPAN[text()='LABORATUVAR']");

        public void ValidateUserName() 
         {

            ValidateElementExisting(validate_UserName);
        }
        public DashboardPage LocatePatientDashboardPage()
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(2000);
            patient.Click();
            Thread.Sleep(3000);
            return new DashboardPage(Driver);
        }

        public VitalBulgularPage LocateVitalBulgular()
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(500);
            patient.Click();
            Thread.Sleep(3000);
            tabVitalBulgular.Click();
            return new VitalBulgularPage(Driver);
        }

        public HemsireIslemleriPage LocateHemsirePage()
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(1000);
            patient.Click();
            Thread.Sleep(3000);
            tabHemsireIslemleri.Click();
            return new HemsireIslemleriPage(Driver);
        }

        public VentilatorPage LocateVentilatorPage()
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            patient.Click();
            Thread.Sleep(3000);
            tabVitalBulgular.Click();
            Thread.Sleep(1000);
            btn_menuBar.Click();
            Thread.Sleep(1000);
            secventilator.Click();
            return new VentilatorPage(Driver);
        }
        public SiviCikanPage LocateSiviCikanPage()
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(1000);
            patient.Click();
            Thread.Sleep(3000);
            tabVitalBulgular.Click();
            Thread.Sleep(1000);
            btn_menuBar.Click();
            Thread.Sleep(1000);
            secSiviCikan.Click();
            return new SiviCikanPage(Driver);
        }
        public SiviGirenPage LocateSiviGirenPage()
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(1000);
            patient.Click();
            Thread.Sleep(3000);
            tabVitalBulgular.Click();
            Thread.Sleep(1000);
            btn_menuBar.Click();
            Thread.Sleep(1000);
            secSiviGiren.Click();
            return new SiviGirenPage(Driver);
        }
        public KanGazlariPage LocateKanGazlariPage()
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(1000);
            patient.Click();
            Thread.Sleep(3000);
            tabVitalBulgular.Click();
            Thread.Sleep(1000);
            btn_menuBar.Click();
            Thread.Sleep(1000);
            secKanGazlari.Click();
            return new KanGazlariPage(Driver);
        }
        public LaboratuvarPage LocateLabPage()
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(1000);
            patient.Click();
            Thread.Sleep(3000);
            tabVitalBulgular.Click();
            Thread.Sleep(1000);
            btn_menuBar.Click();
            Thread.Sleep(1000);
            secLab.Click();
            return new LaboratuvarPage(Driver);
        }
    }
}
