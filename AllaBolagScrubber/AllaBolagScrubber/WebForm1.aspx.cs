using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HtmlAgilityPack;

namespace AllaBolagScrubber
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        protected void Button1_Click(object sender, EventArgs e)
        {

            var getHtmlWeb = new HtmlWeb();
            string url = "";
            string whereToSelect = "";
            if (DropDownList1.SelectedValue == "Hitta.se ")
            {
                url = "http://www.hitta.se/asplund+software/tyres%C3%B6/~MsXvGKucE?vad=" + Text1.Value.Replace("-", "");
                whereToSelect = "//*[@id='item-details']/div[1]/h1";
            }
            else if (DropDownList1.SelectedValue == "Allabolag.se ")
            {
                url = "http://www.allabolag.se/" + Text1.Value.Replace("-", "");
                whereToSelect="//*[@id='printTitle']";
            }
            else
            {
                mindiv.InnerHtml = "Välj leverantör";
            }

            HtmlDocument document = getHtmlWeb.Load(url);

            var nodes = document.DocumentNode.SelectNodes(whereToSelect);

            foreach (var name in nodes)
            {
                mindiv.InnerHtml = "Från " + DropDownList1.SelectedValue+ " " + name.InnerText;
            }
                

        }
    }
}