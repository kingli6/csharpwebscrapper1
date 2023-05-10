using HtmlAgilityPack;
using System;
using System.Net.Http;

namespace WebScraper
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");
            String url = "https://www.studentum.se/skola/kyh/kyh-goteborg/internet-of-things-developer-884949";
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url).Result;
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            // get a item1
            var item1 = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='emg-summary__title']");
            var title = item1.InnerText.Trim();

            Console.WriteLine("title : " + title);
            // get a item2
            // var item2 = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='emg-serp-item__title-text']");
            // get a item3



        }

    }

}

// See https://aka.ms/new-console-template for more information
