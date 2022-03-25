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
    public sealed class SiviGirenSteps
    {
        private readonly IWebDriver _driver;
        private ScenarioContext _scenarioContext;
        private SiviGirenPage _siviGiren;
        public SiviGirenSteps(ScenarioContext context)
        {
            _scenarioContext = context;
            _driver = _scenarioContext.Get<IWebDriver>("currentDriver");
            _siviGiren = new SiviGirenPage(_driver);
        }

        /// <summary>
        /// GirensİVİ Steps
        /// </summary>
        [When(@"the user sets girenSivi")]
        public void WhenTheUserSetsGirenSivi()
        {
            _siviGiren.SetGirenSivi();
        }

        [Then(@"the girenSivi emount should appear in right and left table")]
        public void ThenTheGirenSiviEmountShouldAppearİnRightAndLeftTable()
        {
            _siviGiren.ValidateGirenSivionLeftandRightTable();
        }

        [When(@"the user removes girenSivi")]
        public void WhenTheUserRemovesGirenSivi()
        {
            _siviGiren.RemoveGirenSivi();
        }

        [Then(@"girenSivi should not appear in right and left table")]
        public void ThenGirenSiviShouldNotAppearİnRightAndLeftTable()
        {
            _siviGiren.ValidateGirenSivinotExistonPage();
        }

        /// <summary>
        /// Oral Verilen Sivi Steps
        /// </summary>
        [When(@"the user sets oral verilen sivi")]
        public void WhenTheUserSetsOralVerilenSivi()
        {
            _siviGiren.SetOralVerilenSivi();
        }

        [Then(@"oral verilen sivi amount should appear in right and left table")]
        public void ThenOralVerilenSiviAmountShouldAppearİnRightAndLeftTable()
        {
            _siviGiren.ValidateoralVerilenSivionLeftandRightTable();
        }

        [When(@"the user removes oral verilen sivi")]
        public void WhenTheUserRemovesOralVerilenSivi()
        {
            _siviGiren.RemoveOralVerilenSivi();
        }

        [Then(@"oral verilen sivi should not appear in right and left table")]
        public void ThenOralVerilenSiviShouldNotAppearİnRightAndLeftTable()
        {
            _siviGiren.ValidateOralVerilenSivinotExistonPage();
        }

    }
}
