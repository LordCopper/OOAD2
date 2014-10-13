using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductAdapterLib;

namespace UnitTestForAdapter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProduct()
        {
            Product testProduct = new Product(10, "ABC123", "Sausage");
            Decimal expectedPrice = 10;
            string expectedBarCode = "ABC123";
            string expectedTitle = "Sausage";

            Assert.AreEqual(expectedBarCode,testProduct.BarCode);
            Assert.AreEqual(expectedPrice,testProduct.UnitPrice);
            Assert.AreEqual(expectedTitle,testProduct.Title);
        }

        [TestMethod]
        public void TestSomeExternalVendorProduct()
        {
            SomeExternalVendorProduct testExternalVendorProduct = new SomeExternalVendorProduct{Description = "Cheese", EANCode = "ABC123", PricePerUnit = 12};

            Decimal expectedPrice = 12;
            string expectedDescription = "Cheese";
            string expectedEANCode = "ABC123";
            
            SomeExternalVendorProductAdapter adapting = new SomeExternalVendorProductAdapter(testExternalVendorProduct);

            Assert.AreEqual(expectedPrice, adapting.UnitPrice);
            Assert.AreEqual(expectedDescription, adapting.Title);
            Assert.AreEqual(expectedEANCode, adapting.BarCode);
        }
    }
}
