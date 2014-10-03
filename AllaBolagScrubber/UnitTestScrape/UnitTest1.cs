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
            var testVar = new ClassScrape();
            string testId = "5565995239";
            string testResult = "Från Allabolag.se Mattias Asplund Aktiebolag";
            string testFromWhatPage = "Allabolag.se";
            Assert.AreEqual(testResult, testVar.findNameByOrgID(testId, testFromWhatPage));

        }

        [TestMethod]
        public void TestEniroToSeeIfPredetermendIDReturnsCorrectName()
        {
            var testVar = new ClassScrape();
            string testId = "5565995239";
            string testResult = "Från Hitta.se Asplund Software";
            string testFromWhatPage = "Hitta.se";
            Assert.AreEqual(testResult, testVar.findNameByOrgID(testId, testFromWhatPage));

        }
    }
}
