using System.Net;

namespace ScrapeLibrary
{
    public class Scrape
    {

        public string ScrapeWebPage(string url)
        {
            return GetWebpage(url);

        }
        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebpage(url);
            File.WriteAllText(filepath, reply);
            return reply;
        }
        private string GetWebpage(string url)
        {
            WebClient client = new();
      
            String content = client.DownloadString(url);
            return content + "THATS ALL MY GUY"; 
           
        }
    }
}