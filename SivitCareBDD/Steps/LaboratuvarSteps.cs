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
    public sealed class LaboratuvarSteps
    {
        private readonly IWebDriver _driver;
        private ScenarioContext _scenarioContext;
        private LaboratuvarPage _lab;
        public LaboratuvarSteps(ScenarioContext contex)
        {
            _scenarioContext = contex;
            _driver = _scenarioContext.Get<IWebDriver>("currentDriver");
            _lab = new LaboratuvarPage(_driver);
        }

        [When(@"the user sets vitals on  laboratuvar page")]
        public void WhenTheUserSetsVitalsOnLaboratuvarPage()
        {
            _lab.SetVitals();
        }

        [Then(@"vitals should appear in table by left side")]
        public void ThenVitalsShouldAppearİnTableByLeftSide()
        {
            _lab.ValidateVitalsfromLeftTable();
        }

        [When(@"the user validates vitals by right side and removes vitals")]
        public void WhenTheUserValidatesVitalsByRightSideAndRemovesVitals()
        {
            _lab.ValidateVitalsfromRightandRemove();
        }

        [Then(@"vitals should not appear in right and left side table")]
        public void ThenVitalsShouldNotAppearİnRightAndLeftSideTable()
        {
            _lab.ValidateVitalsnotExist();
        }

    }
}
