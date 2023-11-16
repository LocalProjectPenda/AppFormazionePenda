using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public abstract class UEPublicAdministration : IUEEnteAdministration
{
       public UEPublicAdministration()
        { }

        public string BorderReDefinition(Parlement parlement)
        {
            return "ok";
        }


        public abstract void WelfareService();
        public void HNS(UECitizenPublicService ID) { }
        public void EducationSystem(UECitizenPublicService ID) { }
       
        
       public void HNS() { }
       public void LAWSystem() { }
       public void EducationSystem() { }
    }
}
