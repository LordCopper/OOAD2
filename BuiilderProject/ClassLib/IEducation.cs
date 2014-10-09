using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public interface IEducation 
    {
        string InviteStudents { get; set; }
        string AssignTeacher { get; set; }
        string ProcessStudentFeedback { get; set; }
    }
}
