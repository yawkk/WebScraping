using ScrapeLibrary;

namespace ScrapeClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Scrape myScrape = new();
            string value = myScrape.ScrapeWebPage("https://learn.microsoft.com/");
            Console.WriteLine(value);

        }
    }
}