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
    public sealed class VentilatorSteps
    {

        private readonly IWebDriver _driver;
        private ScenarioContext _scenarioContext;
        private VentilatorPage _ventilator;
        public VentilatorSteps(ScenarioContext context)
        {
            _scenarioContext = context;
            _driver = _scenarioContext.Get<IWebDriver>("currentDriver");
            _ventilator = new VentilatorPage(_driver);
        }

        [When(@"the user sets ventilator")]
        public void WhenTheUserSetsVentilator()
        {
            _ventilator.SetVenlilator();
        }

        [Then(@"the ventilators should appear in table by left side")]
        public void ThenTheVentilatorsShouldAppearİnTableByLeftSide()
        {
            _ventilator.ValidateVentilatorfromLeftTable();
        }

        [When(@"the user validates ventilators by right side and removes ventilators")]
        public void WhenTheUserValidatesVentilatorsByRightSideAndRemovesVentilators()
        {
            _ventilator.ValidateVantilatorfromRightandRemove();
        }

        [Then(@"ventilators should not appear in right and left side table\.")]
        public void ThenVentilatorsShouldNotAppearİnRightAndLeftSideTable_()
        {
            _ventilator.ValidateVentilatorsnotExist();
        }

    }
}
