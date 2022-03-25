using NUnit.Framework;
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
    public sealed class LoginSteps
    {
        private readonly IWebDriver _driver;
        private  LoginPage _loginPage;
        private readonly ScenarioContext _scenarioContext;

        public LoginSteps(ScenarioContext injectedContex)
        {
            _scenarioContext = injectedContex;
            _driver = _scenarioContext.Get<IWebDriver>("currentDriver");
            _loginPage = new LoginPage(_driver);
        }

        

        [Given(@"the user is on the login screen")]
        public void GivenIAmOnTheLoginScreen()
        {
            _loginPage.NavigatetoSivitCare();
            
        }


        [When(@"the user submit valid log-in criteria")]
        public void WhenISubmitValidLog_İnCriteria()
        {
            _loginPage.LoginOlma();
        }


    }
}
