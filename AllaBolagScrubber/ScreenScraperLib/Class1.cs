using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ScreenScraperLib
{
    public interface IScrapeService
    {
        string findNameByOrgID(string OrgID);
    }


    public class ClassScrapeHitta : IScrapeService
    {

        public string findNameByOrgID(string OrgID)
        {
            var getHtmlWeb = new HtmlWeb();

            string url = "http://www.hitta.se/sök?vad=" + OrgID.Replace("-", "");

            string orgName = string.Empty;
            string whereToSelect = "//*[@id='item-details']/div[1]/h1";


            HtmlDocument document = getHtmlWeb.Load(url);

            var nodes = document.DocumentNode.SelectNodes(whereToSelect);

            foreach (var name in nodes)
            {
                orgName = "Från Hitta.se " + name.InnerText;
            }

            return orgName;
        }
    }
    public class ClassScrapeAllaBolag : IScrapeService
    {
    public string findNameByOrgID(string OrgID)
        {
            var getHtmlWeb = new HtmlWeb();

            string url = "http://www.allabolag.se/" + OrgID.Replace("-", "");

            string orgName = string.Empty;
            string whereToSelect = "//*[@id='printTitle']";


            HtmlDocument document = getHtmlWeb.Load(url);

            var nodes = document.DocumentNode.SelectNodes(whereToSelect);

            foreach (var name in nodes)
            {
                orgName = "Från Allabolag.se " + name.InnerText;
            }

            return orgName;
        }
    }

    public class ClassScrapeEniro : IScrapeService
    {

        public string findNameByOrgID(string OrgID)
        {
            var getHtmlWeb = new HtmlWeb();

            string url = "http://gulasidorna.eniro.se/hitta:" + OrgID.Replace("-", "");

            string orgName = string.Empty;
            string whereToSelect = "//*[@id='hit-list']/li/article/header/div[2]/h2/span/a";


            HtmlDocument document = getHtmlWeb.Load(url);

            var nodes = document.DocumentNode.SelectNodes(whereToSelect);

            foreach (var name in nodes)
            {
                orgName = "Från Eniro.se " + name.InnerText;
            }

            return orgName;
        }
    }
}
