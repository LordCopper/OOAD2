using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
   public class JensenBuilder : EducationBuilder
   {
       private IEducation education = new EducationJensen();

       public override void AssignTeacher()
       {
           Education.AssignTeacher = "Mattias";
       }

       public override void InviteStudents()
       {
           Education.InviteStudents = "300";
       }

       public override void ProcessStudentFeedback()
       {
           Education.ProcessStudentFeedback = "The Greatest";
       }

       public override IEducation Education
       {
           get { return education; }
       }
   }
}
