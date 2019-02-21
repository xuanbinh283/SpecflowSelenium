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
namespace MSTestProject.AutomatedScripts
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class NavigationFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Navigation.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Navigation", null, ProgrammingLanguage.CSharp, new string[] {
                        "JIRA_VISAI778",
                        "NAVIGATION"});
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Navigation")))
            {
                global::MSTestProject.AutomatedScripts.NavigationFeature.FeatureSetup(null);
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
    testRunner.Given("I go to the VSMC site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
    testRunner.Then("I should see the VSMC login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
    testRunner.And("I successfully login as a SYSADMIN", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Navigation around the VSMC by menu and browser (uid:f2c9110d-5d63-4bc5-8942-5a9a3" +
            "03af079)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Navigation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JIRA_VISAI778")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("NAVIGATION")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AUTO_READY")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("NAVIGATION")]
        public virtual void NavigationAroundTheVSMCByMenuAndBrowserUidF2C9110D_5D63_4Bc5_8942_5A9A303Af079()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigation around the VSMC by menu and browser (uid:f2c9110d-5d63-4bc5-8942-5a9a3" +
                    "03af079)", null, new string[] {
                        "AUTO_READY",
                        "NAVIGATION"});
#line 11
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line 12
    testRunner.And("I should see the Search Engines page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
    testRunner.And("I click the BACK button on the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
    testRunner.And("I should see the Search Engines page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
    testRunner.And("I refresh the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
    testRunner.And("I should see the Search Engines page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
    testRunner.And("I click the Admin drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
    testRunner.And("I select the Users entry in the Admin drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
    testRunner.And("I should see the Users main page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
    testRunner.And("I click the BACK button on the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
    testRunner.And("I should see the Search Engines page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
    testRunner.And("I click the FORWARD button on the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
    testRunner.And("I should see the Users main page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
    testRunner.And("I refresh the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
    testRunner.And("I should see the Users main page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
    testRunner.And("I click the Search drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
    testRunner.And("I select the Search Engines entry in the Search drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
    testRunner.And("I should see the Search Engines page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
    testRunner.And("I log out of the system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
    testRunner.And("I should see the VSMC login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
    testRunner.And("I click the BACK button on the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
    testRunner.And("I should see the VSMC login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion