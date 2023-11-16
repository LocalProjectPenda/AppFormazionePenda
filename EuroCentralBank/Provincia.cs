using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public class Provincia :AreaGeo, UEPublicAdministration
    {
       public Provincia(string nameGeo, decimal area):base(nameGeo, area) { }

        public override void WelfareService() { }
        public abstract void HNS(UECitizenPublicService ID) { }
        public abstract void EducationSystem(UECitizenPublicService ID) { }


        public void HNS() { }
        public void LAWSystem() { }
        public void EducationSystem() { }
    }
}
