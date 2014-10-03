using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HtmlAgilityPack;
using ScreenScraperLib;

namespace AllaBolagScrubber
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        protected void Button1_Click(object sender, EventArgs e)
        {


         
            IScrapeService o = ScrapeServiceFactory.CreateScrapeService(DropDownList1.SelectedValue);
           
           mindiv.InnerHtml = o.findNameByOrgID(Text1.Value);


            //if (DropDownList1.SelectedValue == "Hitta.se")
            //{
            //    ClassScrapeHitta newScrape = new ClassScrapeHitta();

            //    mindiv.InnerHtml = newScrape.findNameByOrgID(Text1.Value);
            //}
            //else if (DropDownList1.SelectedValue == "Allabolag.se")
            //{
            //    ClassScrapeAllaBolag newScrape = new ClassScrapeAllaBolag();

            //    mindiv.InnerHtml = newScrape.findNameByOrgID(Text1.Value);
            //}


            //HtmlDocument document = getHtmlWeb.Load(url);

            //var nodes = document.DocumentNode.SelectNodes(whereToSelect);

            //foreach (var name in nodes)
            //{
            //    mindiv.InnerHtml = "Från " + DropDownList1.SelectedValue + " " + name.InnerText;
            //}


        }
    }

    public static class ScrapeServiceFactory
    {
        public static IScrapeService CreateScrapeService(string type)
        {
            IScrapeService service = null;
            switch (type)
            {
                case "Hitta.se": 
                    service = new ClassScrapeHitta();
                    break;
                case "Allabolag.se":
                    service = new ClassScrapeAllaBolag();
                    break;

                    }

            return service;
        }
    }
}