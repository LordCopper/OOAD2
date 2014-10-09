using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public abstract class EducationBuilder 
    {
        
      
        public virtual EducationDirector AssignTeacher()
        {
            return "1";
        }
        public virtual EducationDirector InviteStudents()
        {
            return "2";
        }
        public virtual EducationDirector ProcessStudentFeedback()
        {
            return "3";
        }
    }
}
