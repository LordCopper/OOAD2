using System;
using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuilderProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAssignTeacher()
        {
            var testMethod = new Nackademin();
            string expected ="1";
            string actual = testMethod.AssignTeacher();
            Assert.AreEqual(expected, actual);
        }
        public void TestInviteStudents()
        {
        
        }
        public void TestProcessStudentFeedback()
        {
        
        }
    }
}
