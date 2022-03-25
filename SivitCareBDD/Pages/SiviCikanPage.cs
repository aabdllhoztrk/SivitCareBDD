using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SivitCareBDD.Pages
{
    public class SiviCikanPage : BasePage
    {
        public SiviCikanPage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// randomIdrarMiktari, kusma, defekasyon ekle/dogrula
        /// </summary>
        private IWebElement btn_Ekle => FindElementByXPath("//button[@class='mat-focus-indicator mat-fab mat-button-base mat-primary ng-star-inserted']");
        private IWebElement dropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[3]/mat-form-field/div/div[1]/div/mat-select/div/div[2]");
        private IWebElement secIdrar => FindElementByXPath("//span[contains(text(),'İdrar')]");
        private IWebElement secKusma => FindElementByXPath("//span[contains(text(),'Kusma / NG')]");
        private IWebElement secDefekasyon => FindElementByXPath("//span[contains(text(),'Defekasyon')]");
        private IWebElement txt_DigerBulgu => FindElementByXPath("//input[@data-placeholder='Değer']");
        private IWebElement btn_Kaydet => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[5]/button[1]");
        private IWebElement validateIdrarfromRightTable => FindElementByXPath("//TD[@role='gridcell'][text()=' 15']");
        private IWebElement validateKusmaffromRigthTable => FindElementByXPath("//TD[@role='gridcell'][text()=' 16']");
        private IWebElement validateDefekasyonRigthTable => FindElementByXPath("//TD[@role='gridcell'][text()=' 17']");

        /// <summary>
        /// Sol Taraf Vitaller Tablosu
        /// </summary>
        private IWebElement idrarFromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' İdrar']");
        private IWebElement kusmaFromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Kusma / NG']");
        private IWebElement defekasyonFromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Defekasyon']");
        private IWebElement validateIdrarFromLeftTable => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='15 ']");
        private IWebElement validateKusmaFromTableLeftTable => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='16 ']");
        private IWebElement validateDefekasyonFromTableLeftSide => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='17 ']");

        /// <summary>
        /// İdrar Methodları
        /// </summary>
        public void SetIdrar() 
        {
            btn_Ekle.Click();
            dropDown.Click();
            secIdrar.Click();
            sendKeys(txt_DigerBulgu, "15");
            btn_Kaydet.Click();
        }
        public void ValidateIdraronLeftandRightTable()
        {
            idrarFromTable.Click();
            ValidateElementExisting(validateIdrarFromLeftTable);
            ScrollDown();
            ValidateElementExisting(validateIdrarfromRightTable);
            Thread.Sleep(500);
        }       
        public void RemoveIdrar() 
        {
            Sil();
        }
        public void ValidateIdrarnotExistonPage()
        {
            ValidateElementNotExist("Sivi Cikis Sayfasindan Idrar", "//SPAN[@class='ng-star-inserted'][text()='15']");
            ValidateElementNotExist("Idrar", "//TD[@role='gridcell'][text()='15']");
        }

        /// <summary>
        /// Kusma Methodları
        /// </summary>
        /// 
        public void SetKusma()
        {
            btn_Ekle.Click();
            dropDown.Click();
            secKusma.Click();
            sendKeys(txt_DigerBulgu, "16");
            btn_Kaydet.Click();
        }
        public void ValidateKusmaonLeftandRightTable()
        {
            kusmaFromTable.Click();
            ValidateElementExisting(validateKusmaFromTableLeftTable);
            ScrollDown();
            ValidateElementExisting(validateKusmaffromRigthTable);
            Thread.Sleep(500);
        }
        public void RemoveKusma()
        {
            Sil();
        }
        public void ValidateKusmanotExistonPage()
        {
            ValidateElementNotExist("Sivi Cikis Sayfasindan Kusma", "//SPAN[@class='ng-star-inserted'][text()='16 ']");
            ValidateElementNotExist("Kusma", "//TD[@role='gridcell'][text()=' 16']");
        }

        /// <summary>
        /// Defekasyon Methodları
        /// </summary>
        /// 
        public void SetDefekasyon()
        {
            btn_Ekle.Click();
            dropDown.Click();
            secDefekasyon.Click();
            sendKeys(txt_DigerBulgu, "17");
            btn_Kaydet.Click();
        }
        public void ValidateDefekasyononLeftandRightTable()
        {
            defekasyonFromTable.Click();
            ValidateElementExist(validateDefekasyonFromTableLeftSide, "17");
            ValidateElementExist(validateDefekasyonRigthTable, "17");
        }
        public void RemoveDefekasyon()
        {
            Sil();
        }
        public void ValidateDefekasyonnotExistonPage()
        {
            ValidateElementNotExist("Sivi Cikis Sayfasindan Defekasyon", "//SPAN[@class='ng-star-inserted'][text()='17 ']");
            ValidateElementNotExist("Defekasyon", "//TD[@role='gridcell'][text()=' 17']");
        }
    }
}
