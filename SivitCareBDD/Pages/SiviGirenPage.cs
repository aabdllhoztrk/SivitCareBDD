using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SivitCareBDD.Pages
{
    public class SiviGirenPage : BasePage
    {
        public SiviGirenPage(IWebDriver driver) : base(driver)
        {
        }
        /// <summary>
        /// Giren ve Oral verilen Sıvı Ekle/Doğrula
        /// </summary>
        private IWebElement btn_Ekle => FindElementByXPath("//button[@class='mat-focus-indicator mat-fab mat-button-base mat-primary ng-star-inserted']");
        private IWebElement dropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[3]/mat-form-field/div/div[1]/div/mat-select/div/div[2]");
        private IWebElement secGirenSivi => FindElementByXPath("//span[contains(text(),'Giren Sıvı')]");
        private IWebElement secOralVerilenSivi => FindElementByXPath("//span[contains(text(),'Oral Verilen Sıvı')]");
        private IWebElement txt_DegerBulgu => FindElementByXPath("//input[@data-placeholder='Değer']");
        private IWebElement btn_Kaydet => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[5]/button[1]");
        private IWebElement validateGirenSivi => FindElementByXPath("//TD[@role='gridcell'][text()=' 15']");
        private IWebElement validateOralSivi => FindElementByXPath("//TD[@role='gridcell'][text()=' 16']");

        /// <summary>
        /// Sol Taraf Vitaller Tablosu
        /// </summary>
        private IWebElement girenSiviFromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Giren Sıvı']");
        private IWebElement oralVerilenSiviFromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Oral Verilen Sıvı']");
        private IWebElement validateGirenSiviFromTable => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='15 ']");
        private IWebElement validateOralSiviFromTable => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='16 ']");

        public void SetGirenSivi()
        {

            btn_Ekle.Click();
            dropDown.Click();
            secGirenSivi.Click();
            sendKeys(txt_DegerBulgu, "15");
            btn_Kaydet.Click();
        }
        public void ValidateGirenSivionLeftandRightTable()
        {
            girenSiviFromTable.Click();
            ValidateElementExisting(validateGirenSiviFromTable);
            ValidateElementExisting(validateGirenSivi);
        }

        public void RemoveGirenSivi()
        {
            Sil();
        }

        public void ValidateGirenSivinotExistonPage()
        {
            ValidateElementNotExist("Giren Sivi from table", "//SPAN[@class='ng-star-inserted'][text()='15 ']");
            ValidateElementNotExist("Giren Sivi", "//TD[@role='gridcell'][text()=' 15']");
        }

        /// <summary>
        /// Oral Verilen Sivi Methodları
        /// </summary>
        public void SetOralVerilenSivi()
        {
            btn_Ekle.Click();
            dropDown.Click();
            secOralVerilenSivi.Click();
            sendKeys(txt_DegerBulgu, "16");
            btn_Kaydet.Click();
        }

        public void ValidateoralVerilenSivionLeftandRightTable()
        {
            oralVerilenSiviFromTable.Click();
            ValidateElementExisting(validateOralSiviFromTable);
            ValidateElementExisting(validateOralSivi);
        }
        public void RemoveOralVerilenSivi()
        {
            Sil();
        }

        public void ValidateOralVerilenSivinotExistonPage()
        {
            ValidateElementNotExist("Giren Oral Sivi from table", "//SPAN[@class='ng-star-inserted'][text()='16 ']");
            ValidateElementNotExist("Giren Oral Sivi", "//TD[@role='gridcell'][text()=' 16']");
        }
    }
}
