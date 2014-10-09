using System;
using System.IO;
using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuilderProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAssignTeacherNackademin()
        {
            var builder = new NackademinBuilder();
            var director = new NackademinDirector();
            var education = director.Build(builder);
            string expectedteacher = "Kurt";
            string expectedstudents = "200";
            string expectedProcessStudentFeedback = "Good";

            string actualteacher = education.AssignTeacher;
            string actualstudents = education.InviteStudents;
            string actualFeedback = education.ProcessStudentFeedback;

            Assert.AreEqual(expectedteacher, actualteacher);
            Assert.AreEqual(expectedstudents, actualstudents);
            Assert.AreEqual(expectedProcessStudentFeedback, actualFeedback);
        }

        [TestMethod]
        public void TestAssignTeacherJensen()
        {
            var builder = new JensenBuilder();
            var director = new JensenDirector();
            var education = director.Build(builder);
            string expectedteacher = "Mattias";
            string expectedstudents = "300";
            string expectedProcessStudentFeedback = "The Greatest";
            string actualteacher = education.AssignTeacher;
            string actualstudents = education.InviteStudents;
            string actualFeedback = education.ProcessStudentFeedback;
            Assert.AreEqual(expectedteacher, actualteacher);
            Assert.AreEqual(expectedstudents, actualstudents);
            Assert.AreEqual(expectedProcessStudentFeedback, actualFeedback);
        }
    }
}
