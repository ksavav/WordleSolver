using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WordleSolver;

namespace WebScrap
{
    class Program
    {
        static public int _attempt = 1;
        static bool isOver = false;
        const string startingWord = "ramen";
        //tares, crane
        static void Main(string[] args)
        {
            var w = new WebScraper();

            Thread.Sleep(2000);

            var path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "words.txt");
            var words = new List<string>(File.ReadAllLines(path));
            
            var upperWords = new List<string>();
            foreach (var word in words)
            {
                upperWords.Add(word.ToUpper());
            }

            var xd = new CheckPresents();
            xd.FirstWord(startingWord.ToUpper());
            Thread.Sleep(2000);

            while (isOver == false)
            {
                var data = w.GetDataFromWeb(_attempt);
                isOver = xd.CheckPresentsAndPassNewWordToType(data, upperWords);

                _attempt++;
                Thread.Sleep(2000);
            }
        }
    }
}