using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class NackademinBuilder : EducationBuilder
    {

        private IEducation education = new EducationNackademin();
        public override void AssignTeacher()
        {
            education.AssignTeacher = "Kurt";
        }

        public override void InviteStudents()
        {
            Education.InviteStudents = "200";
        }

        public override void ProcessStudentFeedback()
        {
            Education.ProcessStudentFeedback = "Good";
        }

        public override IEducation Education
        {
            get { return education; }
        }
    }
}
