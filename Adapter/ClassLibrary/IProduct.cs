using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public interface IProduct
    {
        decimal UnitPrice { get; }
        string BarCode { get; }
        string Title { get; }
    }
}
