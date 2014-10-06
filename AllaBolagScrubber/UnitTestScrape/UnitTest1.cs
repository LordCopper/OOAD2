using System;
using System.Globalization;
using ScreenScraperLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScreenScraperLib
{
    [TestClass]
    public class UnitTest1
    {
        string testId = "5565995239";
        [TestMethod]
        public void TestAllaBolagToSeeIfPredetermendIdReturnsCorrectName()
        {
            var testVar = new ClassScrapeAllaBolag();
            string expected = "Från Allabolag.se Mattias Asplund Aktiebolag";
            string actual = testVar.findNameByOrgID(testId);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestHittaToSeeIfPredetermendIdReturnsCorrectName()
        {
            var testVar = new ClassScrapeHitta();
           string expected = "Från Hitta.se Asplund Software";
           string actual = testVar.findNameByOrgID(testId);
           Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestEniroToSeeIfPredetermendIdReturnsCorrectName()
        {
            var testVar = new ClassScrapeEniro();
            string expected = "Från Eniro.se Mattias Asplund AB";
            string actual = testVar.findNameByOrgID(testId);
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TestUpplysningToSeeIfPredetermendIdReturnsCorrectName()
        {
            var testVar = new ClassScrapeUpplysning();
            string expected = "Från Upplysning.se Mattias Asplund Aktiebolag";
            string actual = testVar.findNameByOrgID(testId);
            Assert.AreEqual(expected, actual);
        }
    }
}
