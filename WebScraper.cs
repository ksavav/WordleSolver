using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebScrap
{
    class WebScraper
    {
        private static IWebDriver driver;

        public WebScraper()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.nytimes.com/games/wordle/index.html");

            var discoverRejectButton = driver.FindElement(By.Id("pz-gdpr-btn-reject"));
            discoverRejectButton.Click();

            var discoverXButton = driver.FindElement(By.ClassName("Modal-module_closeIcon__TcEKb"));
            discoverXButton.Click();
        }

        public Dictionary<int, string[]> GetDataFromWeb(int attempt)
        {
            var row = new Dictionary<int, string[]>();
            for (int i = 0; i < 5; i++)
            {
                var collectedData = FindElement(attempt, i + 1);//(By.ClassName("Row-module_row__pwpBq"));
                string[] data = { collectedData.Text, collectedData.GetDomAttribute("data-state") };
                row.Add(i + 1, data);
                Console.WriteLine($"letter: {collectedData.Text} Presents: {collectedData.GetAttribute("data-state")}");
            }

            return row;
        }

        private IWebElement FindElement(int attempt, int xd)
        {
            var xpath = $@"//*[@id=""wordle-app-game""]/div[1]/div/div[{attempt}]/div[{xd}]/div";
            var element = driver.FindElement(By.XPath(xpath));

            return element;
        }
    }
}


/* TODO
 * przeniesienie webscrapa do oddzielnej klasy
 * przetwarzanie informacji
 * dodanie slownika
 * logika wybierania slowa
 */