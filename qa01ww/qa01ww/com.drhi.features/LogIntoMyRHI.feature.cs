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
    [TechTalk.SpecRun.FeatureAttribute("Log into an accredited application", new string[] {
            "MyRHI_Login",
            "Browser_Chrome",
            "SmokeTest"}, Description="    Create a fresh application \r\n\tAssert the tabs when applicant logs into a accr" +
        "edited application ", SourceFile="com.drhi.features\\LogIntoMyRHI.feature", SourceLine=4)]
    public partial class LogIntoAnAccreditedApplicationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LogIntoMyRHI.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Log into an accredited application", "    Create a fresh application \r\n\tAssert the tabs when applicant logs into a accr" +
                    "edited application ", ProgrammingLanguage.CSharp, new string[] {
                        "MyRHI_Login",
                        "Browser_Chrome",
                        "SmokeTest"});
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
        
        public virtual void ToCheckAllCTASPresentOnLogin(string technology, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("To check all CTAS present on login", exampleTags);
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
testRunner.Given(string.Format("I have created a \"{0}\" application and logged in", technology), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
testRunner.And("the application  status is accredited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
testRunner.Then("I expect to see all CTAS present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
testRunner.And("I Sign out from MyRHI successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To check all CTAS present on login, A", SourceLine=16)]
        public virtual void ToCheckAllCTASPresentOnLogin_A()
        {
#line 10
this.ToCheckAllCTASPresentOnLogin("A", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To check all CTAS present on login, B", SourceLine=16)]
        public virtual void ToCheckAllCTASPresentOnLogin_B()
        {
#line 10
this.ToCheckAllCTASPresentOnLogin("B", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To check all CTAS present on login, C", SourceLine=16)]
        public virtual void ToCheckAllCTASPresentOnLogin_C()
        {
#line 10
this.ToCheckAllCTASPresentOnLogin("C", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To check all CTAS present on login, G", SourceLine=16)]
        public virtual void ToCheckAllCTASPresentOnLogin_G()
        {
#line 10
this.ToCheckAllCTASPresentOnLogin("G", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To check all CTAS present on login, H", SourceLine=16)]
        public virtual void ToCheckAllCTASPresentOnLogin_H()
        {
#line 10
this.ToCheckAllCTASPresentOnLogin("H", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To check all CTAS present on login, W", SourceLine=16)]
        public virtual void ToCheckAllCTASPresentOnLogin_W()
        {
#line 10
this.ToCheckAllCTASPresentOnLogin("W", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To check all CTAS present on login, X", SourceLine=16)]
        public virtual void ToCheckAllCTASPresentOnLogin_X()
        {
#line 10
this.ToCheckAllCTASPresentOnLogin("X", ((string[])(null)));
#line hidden
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
