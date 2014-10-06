﻿using System;
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
           string testResult = "Från Allabolag.se Mattias Asplund Aktiebolag";
            Assert.AreEqual(testResult, testVar.findNameByOrgID(testId));

        }

        [TestMethod]
        public void TestHittaToSeeIfPredetermendIdReturnsCorrectName()
        {
            var testVar = new ClassScrapeHitta();
           string testResult = "Från Hitta.se Asplund Software";
            Assert.AreEqual(testResult, testVar.findNameByOrgID(testId));

        }

        [TestMethod]
        public void TestEniroToSeeIfPredetermendIdReturnsCorrectName()
        {
            var testVar = new ClassScrapeEniro();
            string testResult = "Från Eniro.se Mattias Asplund AB";
            Assert.AreEqual(testResult,testVar.findNameByOrgID(testId));
        }
    }
}
