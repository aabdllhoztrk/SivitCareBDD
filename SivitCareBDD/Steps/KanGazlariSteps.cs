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
    public sealed class KanGazlariSteps{

        private readonly IWebDriver _driver;
        private ScenarioContext _scenarioContext;
        private KanGazlariPage _kanGazlari;     
        public KanGazlariSteps(ScenarioContext contex)
        {
            _scenarioContext = contex;
            _driver = _scenarioContext.Get<IWebDriver>("currentDriver");
            _kanGazlari = new KanGazlariPage(_driver);           
        }

        [When(@"the user sets kan gazlari")]
        public void WhenTheUserSetsKanGazlari()
        {
            _kanGazlari.SetKanGazlari();
        }

        [Then(@"kan gazlari should appear in table by left side")]
        public void ThenKanGazlariShouldAppearİnTableByLeftSide()
        {
            _kanGazlari.ValidateKanGazlarifromLeftTable();
        }

        [When(@"the user validates kan gazlari by right side and removes kan gazlari")]
        public void WhenTheUserValidatesKanGazlariByRightSideAndRemovesKanGazlari()
        {
            _kanGazlari.ValidateKanGazlarifromRightandRemove();
        }

        [Then(@"kan gazlari should not appear in right and left side table\.")]
        public void ThenKanGazlariShouldNotAppearİnRightAndLeftSideTable_()
        {
            _kanGazlari.ValidateKanGazlarinotExist();
        }

    }
}
