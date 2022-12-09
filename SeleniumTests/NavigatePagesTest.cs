using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

[TestFixture]
public class NavigatePagesTest {
 
  [Test]
  public void navigatePages() {

        var options = new ChromeOptions();
        options.AddArgument("--headless");
        using IWebDriver driver = new ChromeDriver(options);


        driver.Navigate().GoToUrl("https://localhost:44370/");

        WebDriverWait _wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
        _wait.Until(d => d.FindElement(By.Id("pageIndexText")));

        Assert.That(driver.FindElement(By.Id("pageIndexText")).Text, Is.EqualTo("1 / 500"));


        _wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.Id("nextPageButton"))));
        driver.FindElement(By.Id("nextPageButton")).Click();

        Assert.That(driver.FindElement(By.Id("pageIndexText")).Text, Is.EqualTo("2 / 500"));

        _wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.Id("prevPageButton"))));
        driver.FindElement(By.Id("prevPageButton")).Click();

        Assert.That(driver.FindElement(By.Id("pageIndexText")).Text, Is.EqualTo("1 / 500"));

        driver.FindElement(By.Id("selectPageInputBox")).Click();

        driver.FindElement(By.Id("selectPageInputBox")).SendKeys("50");

        _wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.Id("selectPageButton"))));
        driver.FindElement(By.Id("selectPageButton")).Click();

        Assert.That(driver.FindElement(By.Id("pageIndexText")).Text, Is.EqualTo("50 / 500"));
        
  }
}
