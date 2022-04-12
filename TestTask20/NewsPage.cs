/*
 * Task20, Rimvydas Vainutis
 * 2022-04-11
 * Training
 */

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestTask20
{
    public class Tests
    {
        private WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestLogin()
        {
            driver.Navigate().GoToUrl("https://www.bbc.com/");
            IWebElement consentAccept = driver.FindElement(By.XPath("//div[1]/div[2]/div[2]/button[1]/p"));
            consentAccept.Click();
            Thread.Sleep(1000);
            IWebElement agreeCookies = driver.FindElement(By.CssSelector("#bbccookies-continue-button > span:nth-child(2)"));
            agreeCookies.Click();
            Thread.Sleep(1000);
            IWebElement yourAccountButton = driver.FindElement(By.CssSelector("#idcta-link"));
            yourAccountButton.Click();
            Thread.Sleep(1000);
            IWebElement userEmail = driver.FindElement(By.CssSelector("#user-identifier-input"));
            userEmail.SendKeys("nurtohitra@vusra.com");
            Thread.Sleep(1000);
            IWebElement userPassword = driver.FindElement(By.CssSelector("#password-input"));
            userPassword.SendKeys("testingLearning2022");
            Thread.Sleep(1000);
            IWebElement submitButton = driver.FindElement(By.CssSelector("#submit-button"));
            submitButton.Click();
            Thread.Sleep(1000);
            IWebElement yourAccount = driver.FindElement(By.CssSelector("#idcta-username"));
            Assert.AreEqual(yourAccount.Text, "Your account");
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}