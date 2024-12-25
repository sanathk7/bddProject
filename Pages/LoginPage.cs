using OpenQA.Selenium;
using SpecFlowBDDAutomationFramework.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SpecFlowBDDAutomationFramework.Pages
{

    public class LoginPage
    {

        private IWebDriver driver;

       public LoginPage(IWebDriver driver)
        {
          this.driver = driver;
        }

        
        By usernameField = By.XPath("//input[@name = 'username']");
        By passwordField = By.XPath("//input[@name = 'password']");
        By loginFormLocator = By.XPath("//button[@type = 'submit']");
        By homepagedisplayed = By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]");

      
        public void launchbrowser()
        {

            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }


        public void enterusernamepass(String username, String password)
        {


            driver.FindElement(usernameField).SendKeys(username);
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void submit()
        {

            driver.FindElement(loginFormLocator).Click();

        }

        public void homepagedisplay()
        {

            IWebElement homepage = driver.FindElement(homepagedisplayed);

            if (homepage.Displayed) {
                Console.WriteLine("Home page is displayed");
            }
            else
            {

                Console.WriteLine("Home page is not displayed");
            }

        }


    }


}

