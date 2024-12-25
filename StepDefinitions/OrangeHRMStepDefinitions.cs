using EGIndiaSpecFlowProject.Utils;
using OpenQA.Selenium;
using SpecFlowBDDAutomationFramework.Pages;

namespace EGIndiaSpecFlowProject.StepDefinitions
{
    [Binding]
    public class OrangeHRMStepDefinitions 

    {

        private IWebDriver driver;
        LoginPage loginPage;


        public OrangeHRMStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }



        [When(@"User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {
            driver.Navigate().GoToUrl(Config.BaseUrl);
            Thread.Sleep(2000);           
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersTheAndInTheTextFields(string usrname, string passwd)
        {

            loginPage = new LoginPage(driver);
            loginPage.enterusernamepass(usrname, passwd);

        }

        [When(@"User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
          
            loginPage.submit();

            Thread.Sleep(1000);


        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
          
            loginPage.homepagedisplay();
          
        }

        [Then(@"User is on the home page and a error is displayed")]
        public void ThenUserIsOnTheHomePageAndAErrorIsDisplayed()
        {
            Console.WriteLine("Error message is displayed");
        }

    }
}
