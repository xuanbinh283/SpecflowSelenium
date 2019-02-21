using MSTestProject.Core;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace MSTestProject
{
    [Binding]
    public sealed class StepDefinitionsHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("BeforeTestRun");

        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Driver.StartBrowser(BrowserTypes.Chrome);

            //setup our DI
            //var serviceProvider = new ServiceCollection()
            //    .AddLogging()
            //    .AddTransient<SignInPage>()
            //    .AddSingleton<IWebDriver>(Driver.Browser)
            //    .BuildServiceProvider();

        }
        [AfterScenario]
        public static void AfterScenario()
        {
            Driver.StopBrowser();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("AfterTestRun");

        }
    }
}
