using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using SpecFlowTAF.Drivers;
using SpecFlowTAF.Support.Utils;
using TechTalk.SpecFlow;

namespace TAF.Tests
{
    [Binding]
    public class TestRunner 
    {
        [BeforeFeature]
        public static void StartBrowser()
        {
        IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("Test.config.json")
                    .AddEnvironmentVariables()
                    .Build();

        DriverSettings settings = config.GetRequiredSection(nameof(DriverSettings)).Get<DriverSettings>(); ;

        DriverHolder.InitDriver(settings);

        DriverHolder.Driver.Url = ApplicationConfig.BaseUrl;

        DriverHolder.Driver.Manage().Window.Maximize();
        DriverHolder.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        
        [AfterFeature]
        public static void CloseBrowser()
        {  
            DriverHolder.Cleanup();
        }
    }
}
