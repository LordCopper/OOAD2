using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Product : IProduct
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

        public virtual decimal UnitPrice
        {
            get { return unitPrice; }
        }

        public virtual string BarCode
        {
            get { return barCode; }
        }

        public virtual string Title
        {
            get { return title; }

        }
    }

}
