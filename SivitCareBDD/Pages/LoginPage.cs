using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SivitCareBDD.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement btn_fullScreen => FindElementByXPath("//button[@class='mat-focus-indicator mat-icon-button mat-button-base ng-star-inserted']");
        private IWebElement txt_UserName => FindElementByXPath("//*[@id='mat-input-0']");
        private IWebElement txt_Password => FindElementByXPath("/html/body/app-root/app-login/form/div/mat-drawer-container/mat-drawer-content/div[1]/mat-form-field[2]/div/div[1]/div[4]/input");
        private IWebElement btn_Login => FindElementByXPath("//span[contains(text(),'Giriş')]");
        private IWebElement dropdownDil => FindElementByXPath("/html/body/app-root/app-login/form/div/mat-drawer-container/mat-drawer-content/div[1]/mat-form-field[4]/div/div[1]/div/mat-select/div/div[2]");
        private IWebElement selectTurkce => FindElementByXPath("//SPAN[@class='mat-option-text'][text()=' Türkçe ']");

        public void NavigatetoSivitCare() 
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(50);
            goToUrl("http://192.168.1.9:81/");
        } 
        public HomePage LoginOlma()
        {
            btn_fullScreen.Click();
            txt_UserName.SendKeys("AO");
            txt_Password.SendKeys("Ao12.");
            Thread.Sleep(500);
            dropdownDil.Click();
            selectTurkce.Click();
            btn_Login.Click();
            Thread.Sleep(3000);
            return new HomePage(Driver);
        }

    }
}
