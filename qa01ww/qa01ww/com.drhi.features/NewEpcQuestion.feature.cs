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
    [TechTalk.SpecRun.FeatureAttribute("New EPC Question", new string[] {
            "NewEpcQuestion",
            "Browser_Chrome",
            "Regression"}, Description="\tIn order to reduce reviews \r\n\tAs a applicant \r\n\tI want the application to be rej" +
        "ected if I answered No for EPC exemption", SourceFile="com.drhi.features\\NewEpcQuestion.feature", SourceLine=2)]
    public partial class NewEPCQuestionFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NewEpcQuestion.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "New EPC Question", "\tIn order to reduce reviews \r\n\tAs a applicant \r\n\tI want the application to be rej" +
                    "ected if I answered No for EPC exemption", ProgrammingLanguage.CSharp, new string[] {
                        "NewEpcQuestion",
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
        
        public virtual void ToRejectIndividualsWhoAnswerNoToNewQuestion(string mcsnumber, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("To reject Individuals who answer No to new question", exampleTags);
#line 9
this.ScenarioSetup(scenarioInfo);
#line 11
testRunner.Given("I have completed the first page of the application form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
testRunner.And("I am not with an Investor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
testRunner.When(string.Format("I enter {0} for a given technology", mcsnumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
testRunner.And("I create a deemed application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.And("I select The property as England", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
testRunner.And("I click on Start application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
testRunner.And("I complete the second page of the application form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
testRunner.And("I select No for  Epc recommendation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
testRunner.And("I click submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
testRunner.Then("application  should be rejected for No Epc", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
testRunner.And("an email should not be sent to the applicant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject Individuals who answer No to new question, A", SourceLine=23)]
        public virtual void ToRejectIndividualsWhoAnswerNoToNewQuestion_A()
        {
#line 9
this.ToRejectIndividualsWhoAnswerNoToNewQuestion("A", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject Individuals who answer No to new question, B", SourceLine=23)]
        public virtual void ToRejectIndividualsWhoAnswerNoToNewQuestion_B()
        {
#line 9
this.ToRejectIndividualsWhoAnswerNoToNewQuestion("B", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject Individuals who answer No to new question, C", SourceLine=23)]
        public virtual void ToRejectIndividualsWhoAnswerNoToNewQuestion_C()
        {
#line 9
this.ToRejectIndividualsWhoAnswerNoToNewQuestion("C", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject Individuals who answer No to new question, G", SourceLine=23)]
        public virtual void ToRejectIndividualsWhoAnswerNoToNewQuestion_G()
        {
#line 9
this.ToRejectIndividualsWhoAnswerNoToNewQuestion("G", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject Individuals who answer No to new question, H", SourceLine=23)]
        public virtual void ToRejectIndividualsWhoAnswerNoToNewQuestion_H()
        {
#line 9
this.ToRejectIndividualsWhoAnswerNoToNewQuestion("H", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject Individuals who answer No to new question, W", SourceLine=23)]
        public virtual void ToRejectIndividualsWhoAnswerNoToNewQuestion_W()
        {
#line 9
this.ToRejectIndividualsWhoAnswerNoToNewQuestion("W", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject Individuals who answer No to new question, X", SourceLine=23)]
        public virtual void ToRejectIndividualsWhoAnswerNoToNewQuestion_X()
        {
#line 9
this.ToRejectIndividualsWhoAnswerNoToNewQuestion("X", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject Individuals who answer No to new question, S", SourceLine=23)]
        public virtual void ToRejectIndividualsWhoAnswerNoToNewQuestion_S()
        {
#line 9
this.ToRejectIndividualsWhoAnswerNoToNewQuestion("S", ((string[])(null)));
#line hidden
        }
        
        public virtual void ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion(string technology, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("To reject organisations who answer No to new EPC question", exampleTags);
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
testRunner.Given(string.Format("I am completing the \"{0}\" application process as an organisation", technology), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
testRunner.When("I select No for  Epc recommendation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
testRunner.And("I click submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
testRunner.Then("application  should be rejected for No Epc", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
testRunner.And("an email should not be sent to the applicant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject organisations who answer No to new EPC question, A", SourceLine=41)]
        public virtual void ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion_A()
        {
#line 34
this.ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion("A", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject organisations who answer No to new EPC question, B", SourceLine=41)]
        public virtual void ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion_B()
        {
#line 34
this.ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion("B", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject organisations who answer No to new EPC question, C", SourceLine=41)]
        public virtual void ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion_C()
        {
#line 34
this.ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion("C", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject organisations who answer No to new EPC question, G", SourceLine=41)]
        public virtual void ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion_G()
        {
#line 34
this.ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion("G", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject organisations who answer No to new EPC question, H", SourceLine=41)]
        public virtual void ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion_H()
        {
#line 34
this.ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion("H", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject organisations who answer No to new EPC question, W", SourceLine=41)]
        public virtual void ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion_W()
        {
#line 34
this.ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion("W", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject organisations who answer No to new EPC question, X", SourceLine=41)]
        public virtual void ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion_X()
        {
#line 34
this.ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion("X", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject organisations who answer No to new EPC question, S", SourceLine=41)]
        public virtual void ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion_S()
        {
#line 34
this.ToRejectOrganisationsWhoAnswerNoToNewEPCQuestion("S", ((string[])(null)));
#line hidden
        }
        
        public virtual void ToRejectAdditionalApplicationsWhoAnswerNoToEpc(string technology, string additionalTechnology, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("To reject additional applications who answer No to Epc", exampleTags);
#line 52
this.ScenarioSetup(scenarioInfo);
#line 53
testRunner.Given(string.Format("I have created a \"{0}\" application and logged in", technology), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 54
testRunner.When(string.Format("I create a metered \"{0}\" additional application", additionalTechnology), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
testRunner.And("I select No for  Epc recommendation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
testRunner.And("I click submit additional application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
testRunner.Then("application  should be rejected for No Epc", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
testRunner.And("I Sign out from MyRHI successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications who answer No to Epc, A", SourceLine=60)]
        public virtual void ToRejectAdditionalApplicationsWhoAnswerNoToEpc_A()
        {
#line 52
this.ToRejectAdditionalApplicationsWhoAnswerNoToEpc("A", "A", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications who answer No to Epc, B", SourceLine=60)]
        public virtual void ToRejectAdditionalApplicationsWhoAnswerNoToEpc_B()
        {
#line 52
this.ToRejectAdditionalApplicationsWhoAnswerNoToEpc("B", "B", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications who answer No to Epc, C", SourceLine=60)]
        public virtual void ToRejectAdditionalApplicationsWhoAnswerNoToEpc_C()
        {
#line 52
this.ToRejectAdditionalApplicationsWhoAnswerNoToEpc("C", "C", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications who answer No to Epc, G", SourceLine=60)]
        public virtual void ToRejectAdditionalApplicationsWhoAnswerNoToEpc_G()
        {
#line 52
this.ToRejectAdditionalApplicationsWhoAnswerNoToEpc("G", "G", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications who answer No to Epc, H", SourceLine=60)]
        public virtual void ToRejectAdditionalApplicationsWhoAnswerNoToEpc_H()
        {
#line 52
this.ToRejectAdditionalApplicationsWhoAnswerNoToEpc("H", "H", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications who answer No to Epc, W", SourceLine=60)]
        public virtual void ToRejectAdditionalApplicationsWhoAnswerNoToEpc_W()
        {
#line 52
this.ToRejectAdditionalApplicationsWhoAnswerNoToEpc("W", "W", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To reject additional applications who answer No to Epc, X", SourceLine=60)]
        public virtual void ToRejectAdditionalApplicationsWhoAnswerNoToEpc_X()
        {
#line 52
this.ToRejectAdditionalApplicationsWhoAnswerNoToEpc("X", "X", ((string[])(null)));
#line hidden
        }
        
        public virtual void EpcQuestionShouldBeNotBeShownForScotlandAsLoftCavityReturnsFalse(string technology, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Epc question should be not be shown for Scotland as Loft/cavity returns False", exampleTags);
#line 69
this.ScenarioSetup(scenarioInfo);
#line 70
testRunner.Given(string.Format("I am completing the \"{0}\" application process", technology), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 71
testRunner.Then("new Epc question should not be present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Epc question should be not be shown for Scotland as Loft/cavity returns False, A", SourceLine=73)]
        public virtual void EpcQuestionShouldBeNotBeShownForScotlandAsLoftCavityReturnsFalse_A()
        {
#line 69
this.EpcQuestionShouldBeNotBeShownForScotlandAsLoftCavityReturnsFalse("A", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Epc question should be not be shown for Scotland as Loft/cavity returns False, B", SourceLine=73)]
        public virtual void EpcQuestionShouldBeNotBeShownForScotlandAsLoftCavityReturnsFalse_B()
        {
#line 69
this.EpcQuestionShouldBeNotBeShownForScotlandAsLoftCavityReturnsFalse("B", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Epc question should be not be shown for Scotland as Loft/cavity returns False, S", SourceLine=73)]
        public virtual void EpcQuestionShouldBeNotBeShownForScotlandAsLoftCavityReturnsFalse_S()
        {
#line 69
this.EpcQuestionShouldBeNotBeShownForScotlandAsLoftCavityReturnsFalse("S", ((string[])(null)));
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

