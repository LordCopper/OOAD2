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


            //var getHtmlWeb = new HtmlWeb();
            //string url = "";
            //string whereToSelect = "";
            if (DropDownList1.SelectedValue == "Hitta.se")
            {
                ClassScrapeHitta newScrape = new ClassScrapeHitta();

                mindiv.InnerHtml = newScrape.findNameByOrgID(Text1.Value);
            }
            else if (DropDownList1.SelectedValue == "Allabolag.se")
            {
                ClassScrapeAllaBolag newScrape = new ClassScrapeAllaBolag();

                mindiv.InnerHtml = newScrape.findNameByOrgID(Text1.Value);
            }
            else
            {
                mindiv.InnerHtml = "Välj leverantör";
            }

            //HtmlDocument document = getHtmlWeb.Load(url);

            //var nodes = document.DocumentNode.SelectNodes(whereToSelect);

            //foreach (var name in nodes)
            //{
            //    mindiv.InnerHtml = "Från " + DropDownList1.SelectedValue+ " " + name.InnerText;
            //}


        }
    }
}