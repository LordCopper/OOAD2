using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ProductAdapterLib
{

    public class SomeExternalVendorProductAdapter : IProduct
    {
        private decimal unitPrice;
        private string barCode;
        private string title;

        public SomeExternalVendorProductAdapter(SomeExternalVendorProduct someExternalVendorProduct)
        {
            unitPrice = someExternalVendorProduct.PricePerUnit;
            barCode = someExternalVendorProduct.EANCode;
            title = someExternalVendorProduct.Description;
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

