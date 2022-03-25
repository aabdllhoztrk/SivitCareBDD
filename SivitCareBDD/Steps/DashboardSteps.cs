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
    public sealed class DashboardSteps
    {
        private readonly IWebDriver _driver;
        private ScenarioContext _scenarioContext;
        private DashboardPage _dashboardPage;
        public DashboardSteps(ScenarioContext context) 
        {
            _scenarioContext = context;
            _driver = _scenarioContext.Get<IWebDriver>("currentDriver");            
            _dashboardPage = new DashboardPage(_driver);
        }

        /// <summary>
        /// boy kilo ayarlama adımları
        /// </summary>
        [When(@"the user set weight and height")]
        public void WhenTheUserSetWeightAndHeight()
        {
            _dashboardPage.SetBoyKilo();
        }

        [Then(@"weight and height should appear in dashboard page")]
        public void ThenWeightAndHeightShouldAppearInDashboardPage()
        {
            _dashboardPage.ValidateBoyKiloonDashboard();
        }

        /// <summary>
        /// basamak ayarlama adımları
        /// </summary>
        [When(@"the user sets basamak")]
        public void WhenTheUserSetsBasamak()
        {
            _dashboardPage.SetBasamak();
        }

        [Then(@"basamak should appear in dashboard page")]
        public void ThenBasamakShouldAppearİnDashboardPage()
        {
            _dashboardPage.ValidateBasamakonDashboard();
        }

        /// <summary>
        /// bilinc ayarlama adımları
        /// </summary>
        [When(@"the user sets bilinc")]
        public void WhenTheUserSetsBilinc()
        {
            _dashboardPage.SetBilinc();
        }

        [Then(@"bilinc should appear in dashboard page")]
        public void ThenBilincShouldAppearİnDashboardPage()
        {
            _dashboardPage.ValidateBilinconDashboard();
        }

        /// <summary>
        /// invaziv ekleme silme adımları
        /// </summary>
        [When(@"the user sets invaziv")]
        public void WhenTheUserSetsİnvaziv()
        {
            _dashboardPage.SetInvaziv();
        }


        [Then(@"basamak should set ""(.*)"" and appear in deshboard page")]
        public void ThenBasamakShouldSetAndAppearİnDeshboardPage(string p0)
        {
            _dashboardPage.ValidateBasamakAfterInvazivonDashboard();
        }


        [Then(@"tup no and type of invaziv should appear in invaziv girisimler page under hemsire islemleri tab")]
        public void ThenTupNoAndTypeOfİnvazivShouldAppearİnİnvazivGirisimlerPageUnderHemsireİslemleriTab()
        {
            _dashboardPage.ValidateInvazivinInvazivGirisimlerPage();
        }

        [When(@"the user removes invaziv from invaziv girisimler page")]
        public void WhenTheUserRemovesİnvazivFromİnvazivGirisimlerPage()
        {
            _dashboardPage.RemoveInvaziv();
        }

        [Then(@"invaziv should not appear in invaziv girisimler page")]
        public void ThenİnvazivShouldNotAppearİnİnvazivGirisimlerPage()
        {
            _dashboardPage.ValidatenotExistInvaziv();
        }


    }
}
