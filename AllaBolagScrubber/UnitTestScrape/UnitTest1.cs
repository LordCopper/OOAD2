using System;
using System.Globalization;
using ScreenScraperLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScreenScraperLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToSeeIfPredetermendIDReturnsCorrectName()
        {
            var testVar = new ClassScrape();
            string testId = "5565995239";
            string testResult = "Mattias Asplund Aktiebolag";

            Assert.AreEqual(testResult, testVar.findNameByOrgID(testId));

        }
    }
}
