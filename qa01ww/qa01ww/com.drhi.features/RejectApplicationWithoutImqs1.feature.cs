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
    [TechTalk.SpecRun.FeatureAttribute("Reject applications with no IMQS", new string[] {
            "NoImqs",
            "Browser_Chrome",
            "Regression"}, Description="\tAs an applicant\r\n\tI want new applications to be rejected when submitted without " +
        "IMQS", SourceFile="com.drhi.features\\RejectApplicationWithoutImqs.feature", SourceLine=2)]
    public partial class RejectApplicationsWithNoIMQSFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RejectApplicationWithoutImqs.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Reject applications with no IMQS", "\tAs an applicant\r\n\tI want new applications to be rejected when submitted without " +
                    "IMQS", ProgrammingLanguage.CSharp, new string[] {
                        "NoImqs",
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
        
        public virtual void ToRejectExternalApplicationsWithoutIMQS(string technology, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("To reject external applications without IMQS", exampleTags);
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
testRunner.Given(string.Format("I am completing the \"{0}\" application process", technology), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
testRunner.When("I answer NO for IMQs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
testRunner.And("I click submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
testRunner.Then("application should be rejected for No IMQ\'s", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
testRunner.And("an email should not be sent to the applicant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external applications without IMQS, A", SourceLine=15)]
        public virtual void ToRejectExternalApplicationsWithoutIMQS_A()
        {
#line 8
this.ToRejectExternalApplicationsWithoutIMQS("A", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external applications without IMQS, B", SourceLine=15)]
        public virtual void ToRejectExternalApplicationsWithoutIMQS_B()
        {
#line 8
this.ToRejectExternalApplicationsWithoutIMQS("B", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external applications without IMQS, C", SourceLine=15)]
        public virtual void ToRejectExternalApplicationsWithoutIMQS_C()
        {
#line 8
this.ToRejectExternalApplicationsWithoutIMQS("C", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external applications without IMQS, G", SourceLine=15)]
        public virtual void ToRejectExternalApplicationsWithoutIMQS_G()
        {
#line 8
this.ToRejectExternalApplicationsWithoutIMQS("G", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external applications without IMQS, H", SourceLine=15)]
        public virtual void ToRejectExternalApplicationsWithoutIMQS_H()
        {
#line 8
this.ToRejectExternalApplicationsWithoutIMQS("H", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external applications without IMQS, W", SourceLine=15)]
        public virtual void ToRejectExternalApplicationsWithoutIMQS_W()
        {
#line 8
this.ToRejectExternalApplicationsWithoutIMQS("W", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external applications without IMQS, X", SourceLine=15)]
        public virtual void ToRejectExternalApplicationsWithoutIMQS_X()
        {
#line 8
this.ToRejectExternalApplicationsWithoutIMQS("X", ((string[])(null)));
#line hidden
        }
        
        public virtual void ToRejectExternalOrganisationsApplicationsWithoutIMQS(string technology, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("To reject external organisations applications without IMQS", exampleTags);
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
testRunner.Given(string.Format("I am completing the \"{0}\" application process as an organisation", technology), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
testRunner.When("I answer NO for IMQs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
testRunner.And("I click submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
testRunner.Then("application should be rejected for No IMQ\'s", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
testRunner.And("an email should not be sent to the applicant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external organisations applications without IMQS, A", SourceLine=32)]
        public virtual void ToRejectExternalOrganisationsApplicationsWithoutIMQS_A()
        {
#line 25
this.ToRejectExternalOrganisationsApplicationsWithoutIMQS("A", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external organisations applications without IMQS, B", SourceLine=32)]
        public virtual void ToRejectExternalOrganisationsApplicationsWithoutIMQS_B()
        {
#line 25
this.ToRejectExternalOrganisationsApplicationsWithoutIMQS("B", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external organisations applications without IMQS, C", SourceLine=32)]
        public virtual void ToRejectExternalOrganisationsApplicationsWithoutIMQS_C()
        {
#line 25
this.ToRejectExternalOrganisationsApplicationsWithoutIMQS("C", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external organisations applications without IMQS, G", SourceLine=32)]
        public virtual void ToRejectExternalOrganisationsApplicationsWithoutIMQS_G()
        {
#line 25
this.ToRejectExternalOrganisationsApplicationsWithoutIMQS("G", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external organisations applications without IMQS, H", SourceLine=32)]
        public virtual void ToRejectExternalOrganisationsApplicationsWithoutIMQS_H()
        {
#line 25
this.ToRejectExternalOrganisationsApplicationsWithoutIMQS("H", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external organisations applications without IMQS, W", SourceLine=32)]
        public virtual void ToRejectExternalOrganisationsApplicationsWithoutIMQS_W()
        {
#line 25
this.ToRejectExternalOrganisationsApplicationsWithoutIMQS("W", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject external organisations applications without IMQS, X", SourceLine=32)]
        public virtual void ToRejectExternalOrganisationsApplicationsWithoutIMQS_X()
        {
#line 25
this.ToRejectExternalOrganisationsApplicationsWithoutIMQS("X", ((string[])(null)));
#line hidden
        }
        
        public virtual void ToRejectAdditionalApplicationsWithoutIMQS(string technology, string additionalTechnology, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("To reject additional applications without IMQS", exampleTags);
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
testRunner.Given(string.Format("I have created a \"{0}\" application and logged in", technology), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
testRunner.When(string.Format("I create a metered \"{0}\" additional application", additionalTechnology), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
testRunner.And("I answer NO for IMQs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
testRunner.And("I click submit additional application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
testRunner.Then("application should be rejected for No IMQ\'s", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
testRunner.And("I Sign out from MyRHI successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications without IMQS, A", SourceLine=50)]
        public virtual void ToRejectAdditionalApplicationsWithoutIMQS_A()
        {
#line 42
this.ToRejectAdditionalApplicationsWithoutIMQS("A", "A", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications without IMQS, B", SourceLine=50)]
        public virtual void ToRejectAdditionalApplicationsWithoutIMQS_B()
        {
#line 42
this.ToRejectAdditionalApplicationsWithoutIMQS("B", "B", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications without IMQS, C", SourceLine=50)]
        public virtual void ToRejectAdditionalApplicationsWithoutIMQS_C()
        {
#line 42
this.ToRejectAdditionalApplicationsWithoutIMQS("C", "C", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications without IMQS, G", SourceLine=50)]
        public virtual void ToRejectAdditionalApplicationsWithoutIMQS_G()
        {
#line 42
this.ToRejectAdditionalApplicationsWithoutIMQS("G", "G", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications without IMQS, H", SourceLine=50)]
        public virtual void ToRejectAdditionalApplicationsWithoutIMQS_H()
        {
#line 42
this.ToRejectAdditionalApplicationsWithoutIMQS("H", "H", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications without IMQS, W", SourceLine=50)]
        public virtual void ToRejectAdditionalApplicationsWithoutIMQS_W()
        {
#line 42
this.ToRejectAdditionalApplicationsWithoutIMQS("W", "W", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications without IMQS, X", SourceLine=50)]
        public virtual void ToRejectAdditionalApplicationsWithoutIMQS_X()
        {
#line 42
this.ToRejectAdditionalApplicationsWithoutIMQS("X", "X", ((string[])(null)));
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
