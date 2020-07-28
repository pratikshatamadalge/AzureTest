using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture]
    public class TestScena
    {
        IWebDriver driver;
        [OneTimeSetUp]
        [Obsolete]
        public void Init()
        {
            string USERNAME = "pratikshatamadal1";
            string AUTOMATE_KEY = "7XB2ZtUUhie5psXNyiTM";
            // driver = new ChromeDriver();

            DesiredCapabilities caps = new DesiredCapabilities();

            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "80");
            caps.SetCapability("browserstack.user", USERNAME);
            caps.SetCapability("browserstack.key", AUTOMATE_KEY);
            caps.SetCapability("name", "pratikshatamadal1's First Test");

            driver = new RemoteWebDriver(new Uri("https://hub-cloud.browserstack.com/wd/hub/"), caps);
            driver.Navigate().GoToUrl("http://www.facebook.com");
            Console.WriteLine(driver.Title);

            
        }

        [Test]
        public void Login()
        {
            Class1 page = new Class1(driver);
            page.Login1();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("F:\\VS\\DummyTester\\Test\\Screenshot\\facebook.png", ScreenshotImageFormat.Png);

        }

        [OneTimeTearDown]
        public void tearDown()
        {
            driver.Quit();
        }
    }
}
