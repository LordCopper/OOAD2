using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public abstract class EducationBuilder
    {
       public virtual void AssignTeacher(){}
       public virtual void InviteStudents(){}
       public virtual void ProcessStudentFeedback(){}
       public abstract IEducation Education { get;  }

    }
}