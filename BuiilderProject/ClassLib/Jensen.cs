using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
   public class Jensen : EducationBuilder
    {
       public override string InviteStudents()
       {
           return base.InviteStudents();
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
