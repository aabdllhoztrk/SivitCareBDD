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
    public sealed class ScoresSteps
    {
        private readonly IWebDriver _driver;
        private LoginPage _loginPage;
        private HomePage _homePage;
        private DashboardPage _dashboardPage;
        private readonly ScenarioContext _scenarioContext;

        public ScoresSteps(ScenarioContext injectedContex)
        {
            _scenarioContext = injectedContex;
            _driver = _scenarioContext.Get<IWebDriver>("currentDriver");
            _loginPage = new LoginPage(_driver);
            _homePage = new HomePage(_driver);
            _dashboardPage = new DashboardPage(_driver);
        }

        /// <summary>
        /// Login ve Dashboard Sayfasina git
        /// </summary>
        [Given(@"the user logged into the system")]
        public void GivenTheUserLoggedİntoTheSystem()
        {
            _loginPage.NavigatetoSivitCare(); ;
            _loginPage.LoginOlma();
        }

        [Given(@"the user locates to patient dashboard page")]
        public void GivenTheUserLocateToPatientDashboardPage()
        {
            _homePage.LocatePatientDashboardPage();
        }

        /// <summary>
        /// Apache Steps
        /// </summary>
        [When(@"the user calculates apache score")]
        public void WhenTheUserCalculateApacheAcore()
        {
            _dashboardPage.calculateApache();
        }

        [Then(@"apache Score should be (.*)")]
        public void ThenApacheScoreShouldBe(int p0)
        {
            _dashboardPage.ValidateApacheScore();
        }

        [Then(@"beklenen Olum should be (.*)")]
        public void ThenBeklenenOlumShouldBe(Decimal p0)
        {
            _dashboardPage.ValidateBekleneOlum();
        }

        [Then(@"apache Score should appear in Dashboard page")]
        public void ThenApacheScoreShouldAppearİnDashboardPage()
        {
            _dashboardPage.ValidateApacheScoreinDashboard();
        }

        /// <summary>
        ///  Glaskow Steps
        /// </summary>
        [When(@"the user calculates glaskow score")]
        public void WhenTheUserCalculateGlaskowAcore()
        {
            _dashboardPage.CalculateGlaskow();
        }

        [Then(@"glaskow score ""(.*)"" should appear in dashboard page")]
        public void ThenGlaskowScoreShouldAppearInDashboardPage(int p0)
        {
            _dashboardPage.ValidateGlaskowonDeshboard();
        }

        /// <summary>
        /// Egrf Steps
        /// </summary>
        [When(@"the user calculates egrf score")]
        public void WhenTheUserCalculateEgrfScore()
        {
            _dashboardPage.CalculateEgrf();
        }

        [Then(@"egrf Score should be (.*)")]
        public void ThenEgrfScoreShouldBe(Decimal p0)
        {
            _dashboardPage.ValidateEgrfScore();
        }

        [Then(@"egrf score should appear in dashboard page")]
        public void ThenEgrfScoreShouldAppearİnDashboardPage()
        {
            _dashboardPage.ValidateEgrfonDashboard();
        }

        /// <summary>
        /// Sofa Steps 
        /// </summary>
        [When(@"the user calculates sofa score")]
        public void WhenTheUserCalculateSofaScore()
        {
            _dashboardPage.calculateSofa();
        }

        [Then(@"sofa Score should be (.*)")]
        public void ThenSofaScoreShouldBe(decimal p0)
        {
            _dashboardPage.ValidateSofaScore();
        }

        [Then(@"beklenen olum should be < (.*)%")]
        public void ThenBeklenenOlumShouldBe(int p0)
        {
            _dashboardPage.ValidateBeklenenOlumfromSofa();
        }

        [Then(@"sofa score should appear in dashboard page")]
        public void ThenSofaScoreShouldAppearİnDashboardPage()
        {
            _dashboardPage.ValidateSofaonDashboard();
        }

        /// <summary>
        ///Saps Steps 
        /// </summary>
        [When(@"the user calculates saps score")]
        public void WhenTheUserCalculateSapsScore()
        {
            _dashboardPage.CalculateSaps();
        }

        [Then(@"saps score should be (.*)")]
        public void ThenSapsScoreShouldBe(int p0)
        {
            _dashboardPage.ValidateSapsScore();
        }

        [Then(@"beklenen olum should be (.*) from saps")]
        public void ThenBeklenenOlumShouldBeFromSaps(Decimal p0)
        {
            _dashboardPage.ValidateBeklenenOlumfromSaps();
        }


        [Then(@"saps score should appear in dashboard page")]
        public void ThenSapsScoreShouldAppearİnDashboardPage()
        {
            _dashboardPage.ValidateSapsonDashboard();
        }

    }
}
