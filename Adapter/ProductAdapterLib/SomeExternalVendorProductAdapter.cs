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

        public SomeExternalVendorProductAdapter(SomeExternalVendorProduct someExternalVendorProduct)

        {
           
        }

        public decimal UnitPrice
        {
            get { return 20; }
        }

        public string BarCode
        {
            get { return "12345"; }
        }

        public string Title
        {
            get { return "Ost"; }
        }
    }
}

