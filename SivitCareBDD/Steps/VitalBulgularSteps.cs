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
    public sealed class VitalBulgularSteps
    {
        private readonly IWebDriver _driver;
        private ScenarioContext _scenarioContext;
        private VitalBulgularPage _vitalBulgular;
        public VitalBulgularSteps(ScenarioContext context)
        {
            _scenarioContext = context;
            _driver = _scenarioContext.Get<IWebDriver>("currentDriver");
            _vitalBulgular = new VitalBulgularPage(_driver);
        }

        [When(@"the user sets vital bulgular")]
        public void WhenTheUserSetsVitalBulgular()
        {
            _vitalBulgular.SetVitalBulgular();
        }

        [Then(@"the vital bulgular should appear in table by left side")]
        public void ThenTheVitalBulgularShouldAppearİnTableByLeftSide()
        {
            _vitalBulgular.ValidateVitalBulgularfromLeftTable();
        }

        [When(@"the user validates vital bulgular by right side and removes vital bulgular")]
        public void WhenTheUserValidatesVitalBulgularByRightSideAndRemovesVitalBulgular()
        {
           _vitalBulgular.ValidatefromRightandRemove();
        }

        [Then(@"vital bulgular should not appear in right and left side table\.")]
        public void ThenVitalBulgularShouldNotAppearİnRightAndLeftSideTable_()
        {
            _vitalBulgular.ValidateVitalBulgularnotExist();
        }

    }
}
