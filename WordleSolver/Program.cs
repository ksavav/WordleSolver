using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebScrap
{
    class Program
    {
        static public int _attempt = 1;

        static void Main(string[] args)
        {
            var w = new WebScraper();

            Thread.Sleep(10000);

            var xd = w.GetDataFromWeb(_attempt);

            foreach (var item in xd)
            {
                Console.WriteLine(item);
            }
        }

    }
}


/* TODO
 * przeniesienie webscrapa do oddzielnej klasy DONE
 * przetwarzanie informacji
 * dodanie slownika
 * logika wybierania slowa
 */