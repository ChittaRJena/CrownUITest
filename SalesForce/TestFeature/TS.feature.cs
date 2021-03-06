﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SalesForce.TestFeature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Create TC Case")]
    [NUnit.Framework.CategoryAttribute("Cases")]
    public partial class CreateTCCaseFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TS.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Create TC Case", "\tIn order to manage enquiries and other requirements \r\n\tAs a Helpdesk Agent or an" +
                    " employee in other parts of CCS entity\r\n\tI would like to be given a mechanism to" +
                    " create cases", ProgrammingLanguage.CSharp, new string[] {
                        "Cases"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
#line 8
 testRunner.Given("C on Cases page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02 Create C Tech Support Case")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        public virtual void _02CreateCTechSupportCase()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02 Create C Tech Support Case", new string[] {
                        "RegressionTest"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 12
 testRunner.When("C click on New button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("C should be navigated to Case type Selection page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When("C select case Type as \'Tech Support\' and continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("C should be presented with Case Edit screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.When(@"C populate mandatory Tech Support Case information 'Customer005', 'Technology Support', 'caseOrigin', 'Test001 Contact', 'Triage', 'Incident', 'Open', 'Green', 'eMarketplace', 'User Accounts', 'New User', 'Tech Support Case with Email', 'Tech Support Case with Email' for the case and Save the record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("C Case record be created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03 Create C Tech Support Case again")]
        [NUnit.Framework.TestCaseAttribute("Tech Support", "Phone", "Test001 Contact", "Technology Support", "Customer001", "Triage", "Incident", "Open", "Green", "eMarketplace", "User Accounts", "New User", "Tech Support Case with Email", "Tech Support Case with Email", new string[0])]
        public virtual void _03CreateCTechSupportCaseAgain(string caseType, string caseOrigin, string contactName, string technologyTeam, string orgName, string workflow, string category, string status, string priority, string supportClassification, string sCLevel1, string sCLevel2, string subject, string description, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03 Create C Tech Support Case again", exampleTags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 20
 testRunner.When("C click on New button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("C should be navigated to Case type Selection page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.When(string.Format("C select case Type as {0} and continue", caseType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("C should be presented with Case Edit screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.When(string.Format("C populate mandatory Tech Support Case information as {0},{1}, {2}, {3}, {4}, {5}" +
                        ", {6}, {7}, {8}, {9}, {10}, {11}, {12} for the case and Save the record", orgName, technologyTeam, caseOrigin, contactName, workflow, category, status, priority, supportClassification, sCLevel1, sCLevel2, subject, description), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("C Case record be created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
