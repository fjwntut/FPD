/* 引入net和HtmlAgilityPack 程式庫 */
using HtmlAgilityPack;
using System;
using System.Text;

namespace FPDw14
{
    class Program
    {
        static void Main(string[] args)
        {

            HtmlWeb web = new HtmlWeb();
            HtmlDocument udnDoc = web.Load("https://www.udn.com/news/breaknews/");//載入網址資料
            HtmlNodeCollection udnList = udnDoc.DocumentNode.SelectNodes("//div[@class='story-list__news']");//抓取Xpath資料

            for (int i = 0; i < 10; i++)
            {
                String title = udnList[i].SelectSingleNode(".//div[@class='story-list__text']/h2/a").InnerHtml;
                String date = udnList[i].SelectSingleNode(".//time[@class='story-list__time']").InnerHtml;
                Console.WriteLine("{0}) 標題：{1} | 時間：{2}", i, title, date);
            }
        }
    }
}
