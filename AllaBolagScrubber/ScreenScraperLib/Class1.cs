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


    public class ClassScrape : IScrapeService
    {

        public string findNameByOrgID(string OrgID)
        {
            var getHtmlWeb = new HtmlWeb();

            string url = "http://www.allabolag.se/" + OrgID.Replace("-", "");
            string orgName = "";
            HtmlDocument document = getHtmlWeb.Load(url);

            var nodes = document.DocumentNode.SelectNodes("//*[@id='printTitle']");

            foreach (var name in nodes)
            {
                orgName = name.InnerText;
            }

            return orgName;
        }
    }
}
