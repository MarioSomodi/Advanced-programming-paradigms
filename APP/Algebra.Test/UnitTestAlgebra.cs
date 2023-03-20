using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Algebra.Test;

[TestClass]
public class UnitTestAlgebra
{ 
    IWebDriver driver = new ChromeDriver();

    [TestMethod]
    public void TestGoogleSearchResult()
    {
        driver.Url = "https://www.google.com";

        IWebElement acceptButton = driver.FindElement(By.XPath("//*[@id=\"L2AGLb\"]/div"));
        acceptButton.Click();

        IWebElement searchBox = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));
        searchBox.SendKeys("algebra");

        IWebElement searchButton = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]"));
        searchButton.Click();

        IWebElement firstResult = driver.FindElement(By.XPath("/html/body/div[7]/div/div[11]/div[1]/div[2]/div[2]/div/div/div[1]/div/div/div/div/div/div/div[1]/a/h3"));

        Assert.AreEqual(firstResult.Text, "Algebra: Naslovnica");

        driver.Quit();
    }

    [TestMethod]
    public void TestIfWrongLoginToInfoedukaWillThrowErrorMessage()
    {
        driver.Url = "https://student.racunarstvo.hr/";

        IWebElement usernameTextBox = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
        usernameTextBox.SendKeys("blabla");

        IWebElement passwordTextBox = driver.FindElement(By.XPath("//*[@id=\"pass\"]"));
        passwordTextBox.SendKeys("blabla");

        IWebElement submitButton = driver.FindElement(By.XPath("//*[@id=\"form_login\"]/div/center/table/tbody/tr/td[2]/fieldset/table/tbody/tr[6]/td/p/input"));
        submitButton.Click();

        IWebElement errorMessage = driver.FindElement(By.XPath("//*[@id=\"form_login\"]/div/center/table/tbody/tr/td[2]/fieldset/table/tbody/tr[2]/td"));
        
        Assert.AreEqual(errorMessage.Text, "Greska 001: Korisnièko ime i/ili lozinka nije toèna.");

        driver.Quit();
    }
}