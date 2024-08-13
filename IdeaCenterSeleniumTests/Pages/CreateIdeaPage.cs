using OpenQA.Selenium;

namespace IdeaCenterSeleniumTests.Pages
{
    public class CreateIdeaPage : BasePage
    {
        public CreateIdeaPage(IWebDriver driver) : base(driver)
        {
        }

        public string Url = BaseUrl + "/Ideas/Create";

        public IWebElement TitleInput => driver.FindElement(By.XPath("//input[@name='Title']"));
        public IWebElement AddPictureInput => driver.FindElement(By.XPath("//input[@name='Url']"));
        public IWebElement DescriptionInput => driver.FindElement(By.XPath("//textarea[@name='Description']"));
        public IWebElement CreateButton => driver.FindElement(By.XPath("//button[text()='Create']"));
        public IWebElement MainErrorMessage => driver.FindElement(By.XPath("//div[@class= 'text-danger validation-summary-errors']//li"));
        public IWebElement TitleErrorMessage => driver.FindElements(By.XPath("//span[@class='text-danger field-validation-error']"))[0];
        public IWebElement DescriptionErrorMessage => driver.FindElements(By.XPath("//span[@class='text-danger field-validation-error']"))[1];

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(Url);
        }
        public void CreateIdea(string title, string imageUrl, string description)
        {
            TitleInput.SendKeys(title);
            AddPictureInput.SendKeys(imageUrl);
            DescriptionInput.SendKeys(description);
            CreateButton.Click();
        }

        public void AssertErrorMessages()
        {
            Assert.That(MainErrorMessage.Text.Equals("Unable to create new Idea!"), "Main message is not as expected");
            Assert.That(TitleErrorMessage.Text.Equals("The Title field is required."), "Title message is not as expected");
            Assert.That(DescriptionErrorMessage.Text.Equals("The Description field is required."), "Description message is not as expected");
        }
    }
}
