﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace qa01ww.Com_Drhi_Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Investor bank Details Form", new string[] {
            "InvestorBankForm",
            "Browser_Chrome",
            "Regression"}, Description="\tAs a registered user in Rhita\r\n\tI want to enter Investor bank details \r\n\tSo that" +
        " they go into sun payment system ", SourceFile="com.drhi.features\\InvestorBankDetailsForm.feature", SourceLine=5)]
    public partial class InvestorBankDetailsFormFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "InvestorBankDetailsForm.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Investor bank Details Form", "\tAs a registered user in Rhita\r\n\tI want to enter Investor bank details \r\n\tSo that" +
                    " they go into sun payment system ", ProgrammingLanguage.CSharp, new string[] {
                        "InvestorBankForm",
                        "Browser_Chrome",
                        "Regression"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
#line 12
 #line 13
    testRunner.Given("I am logged in as DA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.And("I am on Rhita", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.When("I navigate to administration page in RHITA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
    testRunner.When("I click the Inv bank details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("DA to enter bank details", SourceLine=17)]
        public virtual void DAToEnterBankDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DA to enter bank details", ((string[])(null)));
#line 18
 this.ScenarioSetup(scenarioInfo);
#line 12
 this.FeatureBackground();
#line 19
 testRunner.Then("I should see the Investor form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Investor ID present in dropdown", SourceLine=20)]
        public virtual void InvestorIDPresentInDropdown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Investor ID present in dropdown", ((string[])(null)));
#line 21
    this.ScenarioSetup(scenarioInfo);
#line 12
 this.FeatureBackground();
#line 22
 testRunner.When("I click on the dropdown InvestorID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("I should see a list of Investors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Complete Investor form", SourceLine=24)]
        public virtual void CompleteInvestorForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Complete Investor form", ((string[])(null)));
#line 25
 this.ScenarioSetup(scenarioInfo);
#line 12
 this.FeatureBackground();
#line 26
 testRunner.When("I click on the dropdown InvestorID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
    testRunner.And("I complete the Investor form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("I click on Update Investor bank details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.Then("the Investor Bank details should be added successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion

