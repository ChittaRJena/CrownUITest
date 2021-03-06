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
    [NUnit.Framework.DescriptionAttribute("04 - Create_A_Triage_Level_")]
    [NUnit.Framework.CategoryAttribute("Triage")]
    public partial class _04_Create_A_Triage_Level_Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateATriageLevel.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "04 - Create_A_Triage_Level_", "\tAs a CCS Salesforce system user\r\n\tI would like to create Triage Levels data\r\n\tSo" +
                    " that I can use the data later for other related activities", ProgrammingLanguage.CSharp, new string[] {
                        "Triage"});
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
 testRunner.Given("I am on Triage Level Edit page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Triage Level Data")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.TestCaseAttribute("Test Level 01", "0.25", "No", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Test Level 02", "0.5", "No", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Test Level 03", "1.0", "No", new string[0])]
        public virtual void CreateTriageLevelData(string triageLevel, string slaDays, string isDefault, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegressionTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Triage Level Data", @__tags);
#line 11
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 12
 testRunner.When(string.Format("I populate the field values {0}, {1} , {2}", triageLevel, slaDays, isDefault), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.And("Save the rcord", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then(string.Format("the new {0} record should be created successfully", triageLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
