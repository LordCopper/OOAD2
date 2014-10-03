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
        public void TestAllaBolagToSeeIfPredetermendIDReturnsCorrectName()
        {
            var testVar = new ClassScrapeAllaBolag();
            string testId = "5565995239";
            string testResult = "Från Allabolag.se Mattias Asplund Aktiebolag";
            Assert.AreEqual(testResult, testVar.findNameByOrgID(testId));

        }

        [TestMethod]
        public void TestHittaToSeeIfPredetermendIDReturnsCorrectName()
        {
            var testVar = new ClassScrapeHitta();
            string testId = "5565995239";
            string testResult = "Från Hitta.se Asplund Software";

            Assert.AreEqual(testResult, testVar.findNameByOrgID(testId));

        }
    }
}
