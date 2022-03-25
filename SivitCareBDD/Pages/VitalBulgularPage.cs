using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SivitCareBDD.Pages
{
    public class VitalBulgularPage : BasePage
    {
        public VitalBulgularPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement btn_VitalEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[4]/div/app-vital/div[1]/div/div/button[1]");
        private IWebElement txt_SpO2 => FindElementByXPath("//input[@data-placeholder='SpO2 0 ~ 100']");
        private IWebElement txt_KalpAtimi => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[2]/mat-form-field[2]/div/div[1]/div[1]/input");
        private IWebElement txt_VucutIsisi => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[2]/mat-form-field[3]/div/div[1]/div[1]/input");
        private IWebElement txt_Resp => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[2]/mat-form-field[4]/div/div[1]/div[1]/input");
        private IWebElement txt_Bpsys => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[2]/mat-form-field[5]/div/div[1]/div[1]/input");
        private IWebElement txt_Bpdias => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[2]/mat-form-field[6]/div/div[1]/div[1]/input");
        private IWebElement txt_cvpMean => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[2]/mat-form-field[7]/div/div[1]/div[1]/input");
        private IWebElement btn_Kaydet => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[5]/button[1]");

        /// <summary>
        /// Validate Vital Bulgular in Left Table
        /// </summary>
        private IWebElement validateSpo2fromLeft => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='59 ']");
        private IWebElement validateKalpAtimifromLeft => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='449 ']");
        private IWebElement validateVucutIsisifromLeft => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='37 ']");
        private IWebElement validateRespfromLeft => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='71 ']");
        private IWebElement validateBpsysfromLeft => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='263 ']");
        private IWebElement validateBpdiasfromLeft => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='162 ']");
        private IWebElement validatecvpMeanfromLeft => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='219 ']");

        /// <summary>
        /// Validate Vital Bulgular in Right Table
        /// </summary>
        private IWebElement validateSpo2fromRight => FindElementByXPath("//TD[@role='gridcell'][text()=' 59']");
        private IWebElement validateKalpAtimifromRight => FindElementByXPath("//TD[@role='gridcell'][text()=' 449']");
        private IWebElement validateVucutIsisifromRight => FindElementByXPath("//TD[@role='gridcell'][text()=' 37']");
        private IWebElement validateRespfromRight => FindElementByXPath("//TD[@role='gridcell'][text()=' 71']");
        private IWebElement validateBpsysfromRight => FindElementByXPath("//TD[@role='gridcell'][text()=' 263']");
        private IWebElement validateBpdiasfromRight => FindElementByXPath("//TD[@role='gridcell'][text()=' 162']");
        private IWebElement validatecvpMeanfromRight => FindElementByXPath("//TD[@role='gridcell'][text()=' 219']");


        /// <summary>
        /// Vantilator Sil/Doğrula
        /// </summary>        
        private IWebElement spO2fromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' SpO2']");
        private IWebElement kalpAtimifromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Kalp Atımı']");
        private IWebElement vucutIsisifromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Vücut Isısı']");
        private IWebElement respfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' RESP']");
        private IWebElement bpSysfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' BP SYS']");
        private IWebElement bpDiasfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' BP DIAS']");
        private IWebElement cvpMeanfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' CVP MEAN']");


        public void SetVitalBulgular()
        {
            btn_VitalEkle.Click();
            sendKeys(txt_SpO2, "59");
            sendKeys(txt_KalpAtimi, "449");
            sendKeys(txt_VucutIsisi, "37");
            sendKeys(txt_Resp, "71");
            sendKeys(txt_Bpsys, "263");
            sendKeys(txt_Bpdias, "162");
            sendKeys(txt_cvpMean, "219");
            btn_Kaydet.Click();
        }
        public void ValidateVitalBulgularfromLeftTable()
        {
            ValidateElementExisting(validateSpo2fromLeft);
            ValidateElementExisting(validateKalpAtimifromLeft);
            ValidateElementExisting(validateVucutIsisifromLeft);
            ValidateElementExisting(validateRespfromLeft);
            ValidateElementExisting(validateBpsysfromLeft);
            ValidateElementExisting(validateBpdiasfromLeft);
            ValidateElementExisting(validatecvpMeanfromLeft);
        }
        public void ValidatefromRightandRemove()
        {
            ScrollDownforVitalPage();
            spO2fromTable.Click();
            ValidateElementExisting(validateSpo2fromRight);
            Sil();
            Sleep(1000);
            kalpAtimifromTable.Click();
            ValidateElementExisting(validateKalpAtimifromRight);
            Sil();
            Sleep(1000);
            vucutIsisifromTable.Click();
            ValidateElementExisting(validateVucutIsisifromRight);
            Sil();
            Sleep(1000);
            respfromTable.Click();
            ValidateElementExisting(validateRespfromRight);
            Sil();
            Sleep(1000);
            bpSysfromTable.Click();
            ValidateElementExisting(validateBpsysfromRight);
            Sil();
            Sleep(1000);
            bpDiasfromTable.Click();
            ValidateElementExisting(validateBpdiasfromRight);
            Sil();
            Sleep(1000);
            ScrollDown();
            cvpMeanfromTable.Click();
            ValidateElementExisting(validatecvpMeanfromRight);
            Sil();            
        }

        public void ValidateVitalBulgularnotExist()
        {
            ValidateElementNotExist("Spo2", "//span[contains(text(),'59')]");
            ValidateElementNotExist("Kalp Atimi", "//span[contains(text(),'449')]");
            ValidateElementNotExist("Vucut İsisi", "//span[text()='37 ']");
            ValidateElementNotExist("RESP", "//span[contains(text(),'71')]");
            ValidateElementNotExist("BP Sys", "//span[contains(text(),'263')]");
            ValidateElementNotExist("BP Dias", "//span[contains(text(),'162')]");
            ValidateElementNotExist("Cvp Mean", "//span[contains(text(),'219')]");
        }
    }
}
