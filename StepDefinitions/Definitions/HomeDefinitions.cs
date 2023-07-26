using NUnit.Framework;
using SpecFlowTAF.Steps;
using TechTalk.SpecFlow;

namespace SpecFlowTAF.Definitions
{
    [Binding]
    public class HomeDefinitions
    {
        HomeSteps homeSteps = new HomeSteps();

        [When(@"I navigate to the tracking site")]
        public void WhenINavigateToTrackingSite()
        {
            homeSteps.NavigateToHome();
        }

        [Then(@"I logged in successfully")]
        public void ThenIAmOnTheLoginPage()
        {
            Assert.IsTrue(homeSteps.IsHomeHeaderDisplayed());
        }
    }
}
