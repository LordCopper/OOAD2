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
            if (DropDownList1.SelectedValue == "Eniro")
            {
                Eniro();
                
            }
            else if (DropDownList1.SelectedValue == "Allabolag")
            {
                Allabolag();
            }

            else
            {
                mindiv.InnerHtml = "Välj leverantör";
            }

        }

        void Allabolag()
        {
            var getHtmlWeb = new HtmlWeb();

            string url = "http://www.allabolag.se/" + Text1.Value.Replace("-", "");

            HtmlDocument document = getHtmlWeb.Load(url);

            var nodes = document.DocumentNode.SelectNodes("//*[@id='printTitle']");

            foreach (var name in nodes)
            {
                mindiv.InnerHtml = "Från eniro" + name.InnerText;
            }
            
        }

        void Eniro()
        {
            var getHtmlWeb = new HtmlWeb();

            string url = "http://gulasidorna.eniro.se/hitta:" + Text1.Value.Replace("-", "");

            HtmlDocument document = getHtmlWeb.Load(url);

            var nodes = document.DocumentNode.SelectNodes("//span[@class='hit-company-name-ellipsis']");

            foreach (var name in nodes)
            {
                mindiv.InnerHtml = "Från allabolag" + name.InnerText;
            }
            

        }


        

    }
}