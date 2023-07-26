using NUnit.Framework;
using SpecFlowTAF.Steps;
using TechTalk.SpecFlow;

namespace SpecFlowTAF.Definitions
{
    [Binding]
    public class LoginDefinitions
    {
        LoginSteps loginSteps = new LoginSteps();

        [Given(@"I login into the site with the following credentials - '([^']*)', '([^']*)'")]
        public void GivenILoginIntoTheSite(string userName, string password)
        {
            loginSteps.LoginIntoTheApplication(userName, password);
        }

        [Then(@"I am presented with the loggining screen")]
        public void ThenIAmOnTheLoginPage()
        {
            Assert.IsTrue(loginSteps.IsLoginHeaderDisplayed());
        }
    }
}
