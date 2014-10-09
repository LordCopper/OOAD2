using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
   public class NackademinBuilder : EducationBuilder
    {
       public override void AssignTeacher()
       {
           Education.AssignTeacher = "1";
       }

       public override void InviteStudents()
       {
           Education.InviteStudents = "2";
       }

       public override void ProcessStudentFeedback()
       {
           Education.ProcessStudentFeedback = "3";
       }

       public override IEducation Education
       {
           get { return Education; }
       }
    }
}
