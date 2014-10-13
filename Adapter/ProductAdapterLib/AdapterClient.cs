using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ProductAdapterLib
{

    public class AdapterClient : IProduct
    {
       
        public AdapterClient(SomeExternalVendorProduct someExternalVendorProduct)
            : base(someExternalVendorProduct.PricePerUnit,
                someExternalVendorProduct.EANCode,
                someExternalVendorProduct.Description)
        {

        }

        public decimal UnitPrice { get; set; }

        public string BarCode { get; set; }
        
        public string Title { get; set; }
    }
}
