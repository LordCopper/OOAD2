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
        //private decimal unitPrice;
        //private string barCode;
        //private string title;
        private SomeExternalVendorProduct _someExternalVendorProduct;

        public SomeExternalVendorProductAdapter(SomeExternalVendorProduct someExternalVendorProduct)
        {
            _someExternalVendorProduct = someExternalVendorProduct;
            //unitPrice = someExternalVendorProduct.PricePerUnit;
            //barCode = someExternalVendorProduct.EANCode;
            //title = someExternalVendorProduct.Description;
        }

        public decimal UnitPrice
        {
            get { return _someExternalVendorProduct.PricePerUnit; }
        }

        public string BarCode
        {
            get { return _someExternalVendorProduct.EANCode; }
        }

        public string Title
        {
            get { return _someExternalVendorProduct.Description; }

        }
    }
}

