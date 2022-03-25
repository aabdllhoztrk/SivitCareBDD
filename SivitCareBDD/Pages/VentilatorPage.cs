using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SivitCareBDD.Pages
{
    public class VentilatorPage : BasePage
    {
        public VentilatorPage(IWebDriver driver) : base(driver)
        {
        }
        /// <summary>
        /// Ventilator Ekle/Doğrula
        /// </summary>
        private IWebElement btn_VantilatorEkle => FindElementByXPath("//button[@class='mat-focus-indicator mat-fab mat-button-base mat-primary ng-star-inserted']");
        private IWebElement txt_Peak => FindElementByXPath("//input[@data-placeholder='Peak  ~ ']");
        private IWebElement txt_Fio2 => FindElementByXPath("//input[@data-placeholder='Fio2  ~ ']");
        private IWebElement txt_VentMod => FindElementByXPath("//input[@data-placeholder='VentMod  ~ ']");
        private IWebElement txt_Rsb => FindElementByXPath("//input[@data-placeholder='RSB  ~ ']");
        private IWebElement btn_Kaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        private IWebElement validatePeakfromLeft => FindElementByXPath("//span[contains(text(),'150')]");
        private IWebElement validateFiozfromLeft => FindElementByXPath("//span[contains(text(),'151')]");
        private IWebElement validateVentModfromLeft => FindElementByXPath("//span[contains(text(),'152')]");
        private IWebElement validateRsbfromLeft => FindElementByXPath("//span[contains(text(),'153')]");

        /// <summary>
        /// Vantilator Sil/Doğrula
        /// </summary>
        private IWebElement peakfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Peak']");
        private IWebElement fio2fromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Fio2']");
        private IWebElement ventModfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' VentMod']");
        private IWebElement rsbfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' RSB']");


        /// <summary>
        /// ventilator Bulgular in Right Table
        /// </summary>
        private IWebElement validatePeakfromRight => FindElementByXPath("//TD[@role='gridcell'][text()=' 150']");
        private IWebElement validateFiozfromRight => FindElementByXPath("//TD[@role='gridcell'][text()=' 151']");
        private IWebElement validateVentModfromRight => FindElementByXPath("//TD[@role='gridcell'][text()=' 152']");
        private IWebElement validateRsbfromRight => FindElementByXPath("//TD[@role='gridcell'][text()=' 153']");

        public void SetVenlilator()
        {
            btn_VantilatorEkle.Click();
            sendKeys(txt_Peak, "150");
            sendKeys(txt_Fio2, "151");
            sendKeys(txt_VentMod, "152");
            sendKeys(txt_Rsb, "153");
            btn_Kaydet.Click();
        }
        public void ValidateVentilatorfromLeftTable()
        {
            ValidateElementExisting(validatePeakfromLeft);
            ValidateElementExisting(validateFiozfromLeft);
            ValidateElementExisting(validateVentModfromLeft);
            ValidateElementExisting(validateRsbfromLeft);
        }
        public void ValidateVantilatorfromRightandRemove()
        {
            ScrollDownforVitalPage();
            peakfromTable.Click();
            ValidateElementExisting(validatePeakfromRight);
            Sil();
            Sleep(1000);
            fio2fromTable.Click();
            ValidateElementExisting(validateFiozfromRight);
            Sil();
            Sleep(1000);
            ventModfromTable.Click();
            ValidateElementExisting(validateVentModfromRight);
            Sil();
            Sleep(1000);
            rsbfromTable.Click();
            ValidateElementExisting(validateRsbfromRight);
            Sil();
            Sleep(1000);

        }

        public void ValidateVentilatorsnotExist()
        {
            ValidateElementNotExist("Peak from Vanlilator Page", "//span[contains(text(),'150')]");
            ValidateElementNotExist("Fio2 from Vanlilator Page", "//span[contains(text(),'151')]");
            ValidateElementNotExist("VentMod from Vanlilator Page", "//span[contains(text(),'152')]");
            ValidateElementNotExist("Rsb from Vanlilator Page", "//span[contains(text(),'153')]");
        }
    }
}

