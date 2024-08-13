using OpenQA.Selenium;

namespace IdeaCenterSeleniumTests.Pages
{
    public class EditIdeaPage : BasePage
    {
        public EditIdeaPage(IWebDriver driver) : base(driver)
        {
        }

        public string Url = BaseUrl + "/Ideas/Edit";

        public IWebElement TitleInput => driver.FindElement(By.XPath("//input[@name='Title']"));
        public IWebElement AddPictureInput => driver.FindElement(By.XPath("//input[@name='Url']"));
        public IWebElement DescriptionInput => driver.FindElement(By.XPath("//textarea[@name='Description']"));
        public IWebElement EditButton => driver.FindElement(By.XPath("//button[text()='Edit']"));

    }
}
