// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MSTestProject.AutomatedScripts.Users
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class EditUserFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "EditUser.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Edit User", null, ProgrammingLanguage.CSharp, new string[] {
                        "JIRA_VISAI778"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Edit User")))
            {
                global::MSTestProject.AutomatedScripts.Users.EditUserFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
  #line 6
    testRunner.And("I go to the VSMC site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 7
    testRunner.And("I should see the VSMC login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 8
    testRunner.And("I successfully login as a SYSADMIN", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Cancel edits to a user (uid:58c2dea8-641b-4e2a-b909-2573854e00dc)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Edit User")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JIRA_VISAI778")]
        public virtual void CancelEditsToAUserUid58C2Dea8_641B_4E2A_B909_2573854E00Dc()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancel edits to a user (uid:58c2dea8-641b-4e2a-b909-2573854e00dc)", null, ((string[])(null)));
#line 10
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Make a user inactive (uid:8ecf3c77-634b-4944-a4e1-ca78c9afe204)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Edit User")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JIRA_VISAI778")]
        public virtual void MakeAUserInactiveUid8Ecf3C77_634B_4944_A4E1_Ca78C9Afe204()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make a user inactive (uid:8ecf3c77-634b-4944-a4e1-ca78c9afe204)", null, ((string[])(null)));
#line 12
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Make the user a non-super user (uid:9a5184b4-be89-43a4-ab9f-50783ca71ac5)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Edit User")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JIRA_VISAI778")]
        public virtual void MakeTheUserANon_SuperUserUid9A5184B4_Be89_43A4_Ab9F_50783Ca71Ac5()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make the user a non-super user (uid:9a5184b4-be89-43a4-ab9f-50783ca71ac5)", null, ((string[])(null)));
#line 14
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required fields for edit user details (uid:4d0c924d-be28-48ed-88ff-d07722bb40e3)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Edit User")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JIRA_VISAI778")]
        public virtual void RequiredFieldsForEditUserDetailsUid4D0C924D_Be28_48Ed_88Ff_D07722Bb40E3()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Required fields for edit user details (uid:4d0c924d-be28-48ed-88ff-d07722bb40e3)", null, ((string[])(null)));
#line 16
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
