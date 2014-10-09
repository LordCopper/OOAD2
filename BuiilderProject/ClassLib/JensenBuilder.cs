using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
   public class JensenBuilder : EducationBuilder
   {
       public override IEducation Education = new JensenEducation();
       public override string InviteStudents()
       {
          
       }

       public override string AssignTeacher()
       {
           return base.AssignTeacher();
       }

       public override string ProcessStudentFeedback()
       {
           return base.ProcessStudentFeedback();
       }
    }
}
