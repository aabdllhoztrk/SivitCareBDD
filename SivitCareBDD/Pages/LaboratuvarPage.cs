using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SivitCareBDD.Pages
{
    public class LaboratuvarPage : BasePage
    {
        public LaboratuvarPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement btn_Ekle => FindElementByXPath("//button[@class='mat-focus-indicator mat-fab mat-button-base mat-primary ng-star-inserted']");
        private IWebElement txt_Glukoz => FindElementByXPath("//input[@data-placeholder='Glukoz 0 ~ 900']");
        private IWebElement txt_WBC => FindElementByXPath("//input[@data-placeholder='WBC  ~ ']");
        private IWebElement btn_Kaydet => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[5]/button[1]");
        private IWebElement GlukozfromLeftSide => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='10.5 ']");
        private IWebElement WBCLeftSide => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='11.5 ']");
        private IWebElement GlukozfromRightSide => FindElementByXPath("//TD[@role='gridcell'][text()=' 10.5']");
        private IWebElement WBCfromRightSide => FindElementByXPath("//TD[@role='gridcell'][text()=' 11.5']");


        public void LabDataEkleSil()
        {
            btn_Ekle.Click();
            sendKeys(txt_Glukoz, "10,5");
            sendKeys(txt_WBC, "11,5");
            btn_Kaydet.Click();

            ///Validation for Ph
            GlukozfromLeftSide.Click();
            ValidateElementExist(GlukozfromRightSide, "10.5");
            Sil();
            ValidateElementNotExist("Glukoz From LeftSide", "//SPAN[@class='ng-star-inserted'][text()='10.5 ']");
            ValidateElementNotExist(" From RightSide", "//TD[@role='gridcell'][text()=' 10.5']");
            ///Validation for WBC
            WBCLeftSide.Click();
            ValidateElementExist(WBCfromRightSide, "11.5");
            Sil();
            ValidateElementNotExist("Ph From LeftSide", "//SPAN[@class='ng-star-inserted'][text()='11.5 ']");
            ValidateElementNotExist("Ph From RightSide", "//TD[@role='gridcell'][text()=' 11.5']");
        }
        public void SetVitals() 
        {
            btn_Ekle.Click();
            sendKeys(txt_Glukoz, "10,5");
            sendKeys(txt_WBC, "11,5");
            btn_Kaydet.Click();
        }

        public void ValidateVitalsfromLeftTable()
        {
            ValidateElementExisting(GlukozfromLeftSide);
            ValidateElementExisting(WBCLeftSide);
        }
        public void ValidateVitalsfromRightandRemove()
        {
            GlukozfromLeftSide.Click();
            ValidateElementExisting(GlukozfromRightSide);
            Sil();
            Sleep(1000);
            WBCLeftSide.Click();
            ValidateElementExisting(WBCfromRightSide);
            Sil();
            Sleep(1000);
        }
        public void ValidateVitalsnotExist()
        {
            ValidateElementNotExist("Glukoz From LeftSide", "//SPAN[@class='ng-star-inserted'][text()='10.5 ']");
            ValidateElementNotExist("WBC From LeftSide", "//SPAN[@class='ng-star-inserted'][text()='11.5 ']");
        }
    }
}
