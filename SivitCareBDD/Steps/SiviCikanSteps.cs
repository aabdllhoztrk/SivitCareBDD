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
    public sealed class SiviCikanSteps
    {
        private readonly IWebDriver _driver;
        private ScenarioContext _scenarioContext;
        private SiviCikanPage _siviCikan;
        public SiviCikanSteps( ScenarioContext context)
        {
            _scenarioContext = context;
            _driver = _scenarioContext.Get<IWebDriver>("currentDriver");
            _siviCikan = new SiviCikanPage(_driver);
        }

        /// <summary>
        /// idrar steps
        /// </summary>
        [When(@"the user sets idrar")]
        public void WhenTheUserSetsİdrar()
        {
            _siviCikan.SetIdrar();
        }

        [Then(@"the idrar emount should appear in right and left table")]
        public void ThenTheİdrarEmountShouldAppearİnRightAndLeftTable()
        {
            _siviCikan.ValidateIdraronLeftandRightTable();
        }

        [When(@"the user removes idrar")]
        public void WhenTheUserRemovesİdrar()
        {
            _siviCikan.RemoveIdrar();
        }

        [Then(@"idrar should not appear in right and left table")]
        public void ThenİdrarShouldNotAppearİnRightAndLeftTable()
        {
            _siviCikan.ValidateIdrarnotExistonPage();
        }

        /// <summary>
        /// Kusma steps
        /// </summary>
        [When(@"the user sets kusma")]
        public void WhenTheUserSetsKusma()
        {
            _siviCikan.SetKusma();
        }

        [Then(@"the kusma emount should appear in right and left table")]
        public void ThenTheKusmaEmountShouldAppearİnRightAndLeftTable()
        {
            _siviCikan.ValidateKusmaonLeftandRightTable();
        }

        [When(@"the user removes kusma")]
        public void WhenTheUserRemovesKusma()
        {
            _siviCikan.RemoveKusma();
        }

        [Then(@"kusma should not appear in right and left table")]
        public void ThenKusmaShouldNotAppearİnRightAndLeftTable()
        {
            _siviCikan.ValidateKusmanotExistonPage();
        }


        /// <summary>
        /// Defekasyon Steps
        /// </summary>
        [When(@"the user sets defekasyon")]
        public void WhenTheUserSetsDefekasyon()
        {
            _siviCikan.SetDefekasyon();
        }

        [Then(@"the defekasyon emount should appear in right and left table")]
        public void ThenTheDefekasyonEmountShouldAppearİnRightAndLeftTable()
        {
            _siviCikan.ValidateDefekasyononLeftandRightTable();
        }

        [When(@"the user removes defekasyon")]
        public void WhenTheUserRemovesDefekasyon()
        {
            _siviCikan.RemoveDefekasyon();
        }

        [Then(@"defekasyon should not appear in right and left table")]
        public void ThenDefekasyonShouldNotAppearİnRightAndLeftTable()
        {
            _siviCikan.ValidateDefekasyonnotExistonPage();
        }

    }
}
