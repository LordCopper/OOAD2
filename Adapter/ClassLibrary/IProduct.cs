using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public interface IProduct
    {
        decimal UnitPrice { get; set; }
        string BarCode { get; set; }
        string Title { get; set; }
    }
}
