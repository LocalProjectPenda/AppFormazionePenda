using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
   public interface IUEEnteAdministration : IEnteAdminstrative
    {
        string BorderReDefinition(Parlement parlement);
        void WelfareService();

        public void  HNS() { }
       public void LAWSystem() { }
       public void EducationSystem() { }

    }
}
