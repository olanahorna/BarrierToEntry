using SpecFlowTAF.Drivers;
using SpecFlowTAF.Pages;
using SpecFlowTAF.Support.Utils;

namespace SpecFlowTAF.Steps
{
    public class HomeSteps
    {
        private HomePage homePage = new HomePage();

        public void NavigateToHome()
        {
            DriverHolder.Driver.Url = ApplicationConfig.HomeBaseUrl;
            DriverHolder.Driver.Manage().Window.Maximize();
            DriverHolder.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        public bool IsHomeHeaderDisplayed()
        {
            return DriverHolder.Driver.FindElement(homePage.HomePageHeader).Displayed;
        }
    }
}
