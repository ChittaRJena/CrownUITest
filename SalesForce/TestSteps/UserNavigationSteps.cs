﻿using SalesForce.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SalesForce.TestSteps
{
    [Binding]
    public sealed class UserNavigationSteps
    {

        [When(@"I click on the home tab")]
        public void WhenIClickOnTheHomeTab()
        {
            TestBase.login.UserLogin("chitta.jena@crowncommercial.gov.uk.pemqa", "Data@3456");
            Thread.Sleep(5000);
            TestBase.login.ClickOnLogIn();
            Thread.Sleep(5000);
            TestBase.landing.ClickOnHomeTab();
            Thread.Sleep(3000);
        }

        [Then(@"I should see the home page")]
        public void ThenIShouldSeeTheHomePage()
        {
            TestBase.home.VerifyPage();

        }

        [When(@"I click on the Chatter tab")]
        public void WhenIClickOnTheChatterTab()
        {
            TestBase.landing.ClickOnChatterTab();
            Thread.Sleep(3000);
        }

        [Then(@"I should see the Chatter page")]
        public void ThenIShouldSeeTheChatterPage()
        {
            TestBase.chatter.VerifyPage();
        }

        [When(@"I click on the Organisations tab")]
        public void WhenIClickOnTheOrganisationsTab()
        {
            TestBase.landing.ClickOnOrganisationTab();
            Thread.Sleep(3000);
        }

        [Then(@"I should see the Organisations page")]
        public void ThenIShouldSeeTheOrganisationsPage()
        {
            TestBase.organisations.VerifyPage();
        }

        [When(@"I click on the Contacts tab")]
        public void WhenIClickOnTheContactsTab()
        {
            TestBase.landing.ClickOnContactsTab();
            Thread.Sleep(3000);
        }

        [Then(@"I should see the Contacts page")]
        public void ThenIShouldSeeTheContactsPage()
        {
            TestBase.contacts.VerifyPage();
        }

        [When(@"I click on the Cases tab")]
        public void WhenIClickOnTheCasesTab()
        {
            TestBase.landing.ClickOnCasesTab();
            Thread.Sleep(3000);
        }

        [Then(@"I should see the Cases page")]
        public void ThenIShouldSeeTheCasesPage()
        {
            TestBase.cases.VerifyPage();
        }

        [When(@"I click on the All tabs tab")]
        public void WhenIClickOnTheAllTabsTab()
        {
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(3000);
        }

        [Then(@"I should see the All tabs page")]
        public void ThenIShouldSeeTheAllTabsPage()
        {
            TestBase.alltabs.VerifyPage();
        }

        [When(@"I click on the Contracts tab")]
        public void WhenIClickOnTheContractsTab()
        {
            TestBase.landing.ClickOnContractsTab();
            Thread.Sleep(3000);
        }

        [Then(@"I should see the Contracts page")]
        public void ThenIShouldSeeTheContractsPage()
        {
            TestBase.contracts.VerifyPage();
        }

        [When(@"I click on the Frameworks tab")]
        public void WhenIClickOnTheFrameworksTab()
        {
            TestBase.landing.ClickOnFrameworksTab();
            Thread.Sleep(3000);
        }

        [Then(@"I should see the Frameworks page")]
        public void ThenIShouldSeeTheFrameworksPage()
        {
            TestBase.frameworks.VerifyPage();
        }

        [When(@"I click on the Reports tab")]
        public void WhenIClickOnTheReportsTab()
        {
            TestBase.landing.ClickOnReportsTab();
            Thread.Sleep(3000);
        }

        [Then(@"I should see the Reports page")]
        public void ThenIShouldSeeTheReportsPage()
        {
            TestBase.reports.VerifyPage();
        }

        [When(@"I click on the Knowledge tab")]
        public void WhenIClickOnTheKnowledgeTab()
        {
            TestBase.landing.ClickOnKnowledgeTab();
            Thread.Sleep(3000);
        }

        [Then(@"I should see the Knowledge page")]
        public void ThenIShouldSeeTheKnowledgePage()
        {
            TestBase.knowledge.VerifyPage();
        }

        [When(@"I click on the Triage Levels tab")]
        public void WhenIClickOnTheTriageLevelsTab()
        {
            TestBase.landing.ClickOnTriageLevelsTab();
            Thread.Sleep(3000);
        }

        [Then(@"I should see the Triage Levels page")]
        public void ThenIShouldSeeTheTriageLevelsPage()
        {
            TestBase.triage.VerifyPage();
        }

        [When(@"I click on the home link")]
        public void WhenIClickOnTheHomeLink()
        {
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(3000);
            TestBase.alltabs.ClickOnHomeLink();
            Thread.Sleep(3000);
        }

        [When(@"I click on the Chatter link")]
        public void WhenIClickOnTheChatterLink()
        {
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(3000);
            TestBase.alltabs.ClickOnChatterLink();
            Thread.Sleep(3000);
        }

        [When(@"I click on the Organisations link")]
        public void WhenIClickOnTheOrganisationsLink()
        {
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(3000);
            TestBase.alltabs.ClickOnOrganisationsLink();
            Thread.Sleep(3000);
        }

        [When(@"I click on the Contacts link")]
        public void WhenIClickOnTheContactsLink()
        {
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(3000);
            TestBase.alltabs.ClickOnContactsLink();
            Thread.Sleep(3000);
        }

        [When(@"I click on the Cases link")]
        public void WhenIClickOnTheCasesLink()
        {
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(3000);
            TestBase.alltabs.ClickOnCasesLink();
            Thread.Sleep(3000);
        }

        [When(@"I click on the Contracts link")]
        public void WhenIClickOnTheContractsLink()
        {
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(3000);
            TestBase.alltabs.ClickOnContractsLink();
            Thread.Sleep(3000);
        }

        [When(@"I click on the Frameworks link")]
        public void WhenIClickOnTheFrameworksLink()
        {
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(3000);
            TestBase.alltabs.ClickOnFrameworksLink();
            Thread.Sleep(3000);
        }

        [When(@"I click on the Reports link")]
        public void WhenIClickOnTheReportsLink()
        {
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(3000);
            TestBase.alltabs.ClickOnReportsLink();
            Thread.Sleep(3000);
        }

        [When(@"I click on the Knowledge link")]
        public void WhenIClickOnTheKnowledgeLink()
        {
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(3000);
            TestBase.alltabs.ClickOnKnowledgeLink();
            Thread.Sleep(3000);
        }

        [When(@"I click on the Triage Levels link")]
        public void WhenIClickOnTheTriageLevelsLink()
        {
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(3000);
            TestBase.alltabs.ClickOnTriageLevelLink();
            Thread.Sleep(3000);
        }

    }
}
