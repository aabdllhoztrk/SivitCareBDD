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
    public sealed class HomeSteps
    {
        private readonly IWebDriver _driver;
        private ScenarioContext _scenarioContext;
        private HomePage _homePage;
        public HomeSteps(ScenarioContext context )
        {
            _scenarioContext = context;
            _driver = _scenarioContext.Get<IWebDriver>("currentDriver");
            _homePage = new HomePage(_driver);
        }

        [Then(@"the user should see UserName on HomePage")]
        public void ThenIShouldSeeUserNameOnHomePage()
        {
            _homePage.ValidateUserName();
        }

        [Given(@"the user locates to vital bulgular page")]
        public void GivenTheUserLocatesToVitalBulgularPage()
        {
            _homePage.LocateVitalBulgular();
        }


        [Given(@"the user locates to hemsire islemleri page")]
        public void GivenTheUserLocatesToHemsireİslemleriPage()
        {
            _homePage.LocateHemsirePage();
        }

        [Given(@"the user locates to ventilator page")]
        public void GivenTheUserLocatesToVentilatorPage()
        {
            _homePage.LocateVentilatorPage();
        }

        [Given(@"the user locates to sivi cikan page")]
        public void GivenTheUserLocatesToSiviCikanPage()
        {
            _homePage.LocateSiviCikanPage();
        }

        [Given(@"the user locates to sivi giren page")]
        public void GivenTheUserLocatesToSiviGirenPage()
        {
            _homePage.LocateSiviGirenPage();
        }

        [Given(@"the user locates to kan gazlari page")]
        public void GivenTheUserLocatesToKanGazlariPage()
        {
            _homePage.LocateKanGazlariPage();
        }

        [Given(@"the user locates to Laboratuvar page")]
        public void GivenTheUserLocatesToLaboratuvarPage()
        {
            _homePage.LocateLabPage();
        }

    }
}
