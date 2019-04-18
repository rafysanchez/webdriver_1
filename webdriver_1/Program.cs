using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace webdriver_1
{
    class Program
    {
        static void Main(string[] args)
        {
           openFacebook();
           // openJCP();
        }

        static void openJCP()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.jcpvipexecutivo.com";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
 
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/ul/li[2]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/ul/li[3]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/ul/li[3]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/ul/li[4]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            System.Threading.Thread.Sleep(4000);

            driver.Close();
           
        }

        static void openFacebook()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.facebook.com";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // acesso com usuario e senha
            driver.FindElement(By.Id("email")).SendKeys("rafysanchez@hotmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("Sanc622!" + Keys.Enter);

            // abrir link de amigos - friends 

            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div[2]/div[1]/div/div/div/div/div[1]/ul/li/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Alt + "n").Build().Perform();
            action.SendKeys(Keys.Escape).Build().Perform();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[1]/div/div[3]/div/div[2]/div[2]/ul/li[3]/a")).Click();
            action.SendKeys(Keys.Escape);

            IList<IWebElement> iWebElement = driver.FindElements(By.XPath("*//div[@class='fsl fwb fcb']/a"));

            Console.WriteLine("Total de links de amigos: " + iWebElement.Count());

            for (int i = 0; i < iWebElement.Count(); i++)
            {
                Console.WriteLine(iWebElement[i].Text);
            }

            driver.Close();
        }
    }
}
