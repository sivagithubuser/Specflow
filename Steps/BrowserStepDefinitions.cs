using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject1.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class BrowserStepDefinitions
    {

        

        private readonly ScenarioContext _scenarioContext;
        public IWebDriver driver;
        public LoginPage login = null;
        public BrowserStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"user launches the application")]
        public void GivenUserLaunchesTheApplication()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://automationpractice.com/index.php";
            login = new LoginPage(driver);
        }

        [Given(@"click on contact button")]
        public void GivenClickOnContactButton()
        {
            login.clickContact();
        }

        [Then(@"user will see the contact us heading")]
        public void ThenUserWillSeeTheContactUsHeading()
        {
            login.assertHeading();
        }

        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            if(driver != null)
            {
                driver.Quit();
            }
        }


    }
}
