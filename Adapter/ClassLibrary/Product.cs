using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product : IProduct
    {
        private decimal unitPrice;
        private string barCode;
        private string title;

        public Product(decimal unitPrice, string barCode, string title)
        {
            this.barCode = barCode;
            this.title = title;
            this.unitPrice = unitPrice;
        }

        public decimal UnitPrice
        {
            get { return unitPrice; }
        }

        public string BarCode
        {
            get { return barCode; }
        }

        public string Title
        {
            get { return title; }

        }
    }

}
