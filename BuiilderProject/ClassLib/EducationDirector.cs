using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
  public abstract class EducationDirector
  {
      public abstract IEducation Build(EducationBuilder builder);
  }
}
