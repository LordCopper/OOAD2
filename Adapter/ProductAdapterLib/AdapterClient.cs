using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ProductAdapterLib
{

    public class AdapterClient : Product
    {
        public AdapterClient(SomeExternalVendorProduct someExternalVendorProduct)
            : base(someExternalVendorProduct.PricePerUnit,
                someExternalVendorProduct.EANCode,
                someExternalVendorProduct.Description)
        {

        }
    }
}
