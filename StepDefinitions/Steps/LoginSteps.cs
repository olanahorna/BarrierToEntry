using SpecFlowTAF.Drivers;
using SpecFlowTAF.Pages;

namespace SpecFlowTAF.Steps
{
    public class LoginSteps
    {
        private LoginPage loginPage = new LoginPage();

        public void LoginIntoTheApplication(string userName, string password)
        {
            var firstNameInput = DriverHolder.Driver.FindElement(loginPage.UserNameField);
            firstNameInput.SendKeys(userName);
            var passwordInput = DriverHolder.Driver.FindElement(loginPage.PasswordField);
            passwordInput.SendKeys(password);

            DriverHolder.Driver
                    .FindElement(loginPage.LoginButton)
                    .Click();
        }

        public bool IsLoginHeaderDisplayed()
        {
            return DriverHolder.Driver.FindElement(loginPage.Header).Displayed;
        }
    }
}
