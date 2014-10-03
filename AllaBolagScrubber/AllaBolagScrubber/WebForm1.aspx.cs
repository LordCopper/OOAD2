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
        protected void Page_Load(object sender, EventArgs e)
        {
           


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var getHtmlWeb = new HtmlWeb();

            string url = "http://www.allabolag.se/"+Text1.Value;

            HtmlDocument document = getHtmlWeb.Load(url);

            var nodes = document.DocumentNode.SelectNodes("//*[@id='printTitle']");

            foreach (var name in nodes)
            {
                mindiv.InnerHtml = name.InnerText;
            }

        }

    }
}