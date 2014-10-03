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
        string findNameByOrgID(string OrgID, string fromWhatPage);
    }


    public class ClassScrape : IScrapeService
    {

        public string findNameByOrgID(string OrgID, string fromWhatPage)
        {
            var getHtmlWeb = new HtmlWeb();

            string url = "";

            string orgName = "";
            string whereToSelect = "";

            if (fromWhatPage == "Hitta.se")
            {
                url = "http://www.hitta.se/sök?vad=" + OrgID.Replace("-", "");
                whereToSelect = "//*[@id='item-details']/div[1]/h1";
            }
            else if (fromWhatPage == "Allabolag.se")
            {
                url = "http://www.allabolag.se/" + OrgID.Replace("-", "");
               whereToSelect= "//*[@id='printTitle']";
            }
            else
            {
                return "Välj leverantör";
            }
            
            HtmlDocument document = getHtmlWeb.Load(url);

            var nodes = document.DocumentNode.SelectNodes(whereToSelect);

            foreach (var name in nodes)
            {
                orgName = "Från " +fromWhatPage+ " " + name.InnerText;
            }

            return orgName;
        }
    }
}
