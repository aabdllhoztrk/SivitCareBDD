using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SivitCareBDD.Pages
{
    public class KanGazlariPage : BasePage
    {
        public KanGazlariPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement btn_Ekle => FindElementByXPath("//button[@class='mat-focus-indicator mat-fab mat-button-base mat-primary ng-star-inserted']");
        private IWebElement txt_Ph => FindElementByXPath("//input[@data-placeholder='pH 1 ~ 14']");
        private IWebElement txt_pCO2 => FindElementByXPath("//input[@data-placeholder='pCO2  ~ ']");
        private IWebElement txt_pO2 => FindElementByXPath("//input[@data-placeholder='pO2  ~ ']");
        private IWebElement btn_Kaydet => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[5]/button[1]");
        private IWebElement PhfromLeftSide => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='10.5 ']");
        private IWebElement pCO2LeftSide => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='11.5 ']");
        private IWebElement pO2LeftSide => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='12.5 ']");
        private IWebElement PhfromRightSide => FindElementByXPath("//TD[@role='gridcell'][text()=' 10.5']");
        private IWebElement pCo2fromRightSide => FindElementByXPath("//TD[@role='gridcell'][text()=' 11.5']");
        private IWebElement pO2fromRightSide => FindElementByXPath("//TD[@role='gridcell'][text()=' 12.5']");



        public void SetKanGazlari()
        {
            Thread.Sleep(1000);
            btn_Ekle.Click();
            sendKeys(txt_Ph, "10,5");
            sendKeys(txt_pCO2, "11,5");
            sendKeys(txt_pO2, "12,5");
            btn_Kaydet.Click();
        }

        public void ValidateKanGazlarifromLeftTable()
        {
            ValidateElementExisting(PhfromLeftSide);
            ValidateElementExisting(pCO2LeftSide);
            ValidateElementExisting(pO2LeftSide);
        }

        public void ValidateKanGazlarifromRightandRemove()
        {
            PhfromLeftSide.Click();
            ValidateElementExisting(PhfromRightSide);
            Sil();
            Sleep(1000);
            pCO2LeftSide.Click();
            ValidateElementExisting(pCo2fromRightSide);
            Sil();
            Sleep(1000);
            pO2LeftSide.Click();
            ValidateElementExisting(pO2fromRightSide);
            Sil();
            Sleep(1000);
        }
        public void ValidateKanGazlarinotExist()
        {
            ValidateElementNotExist("Ph From LeftSide", "//SPAN[@class='ng-star-inserted'][text()='10.5 ']");
            ValidateElementNotExist("Ph From LeftSide", "//SPAN[@class='ng-star-inserted'][text()='11.5 ']");
            ValidateElementNotExist("Ph From LeftSide", "//SPAN[@class='ng-star-inserted'][text()='12.5 ']");
        }
    }
}
