﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestTask20
{
    internal class AllLocators
    {
        private WebDriver driver;

        public void Chrome()
        {
            driver = new ChromeDriver();

            WebElement signInByName = (WebElement)driver.FindElement(By.Name("Your Account"));
            WebElement signInByLinkText = (WebElement)driver.FindElement(By.LinkText("Your Account"));
            WebElement signInById = (WebElement)driver.FindElement(By.Id("idcta-username"));
            WebElement signInByTagName = (WebElement)driver.FindElement(By.TagName("span"));
            WebElement yourAccountByXpath = (WebElement)driver.FindElement(By.XPath("//*[@id='idcta - link']"));
            WebElement yourAccountByClassName = (WebElement)driver.FindElement(By.ClassName("orb-nav-section orb-nav-focus"));
            WebElement yourAccountByCssSelector = (WebElement)driver.FindElement(By.CssSelector("#idcta-link"));
            WebElement yourAccountByPartialLinkText = (WebElement)driver.FindElement(By.PartialLinkText("Account"));
        }
    }
}
