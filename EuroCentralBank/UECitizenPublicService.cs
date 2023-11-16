using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public abstract class UECitizenPublicService:IEnteAdminstrative
    {
        public string _id;
        public UECitizenPublicService(string id)
        {
           _id = id;

        }

        public abstract void WelfareService();
        public abstract void HNS(UECitizenPublicService ID);
        public abstract void EducationSystem(UECitizenPublicService ID);

        public void HNS() { }
        public void LAWSystem() { }
        public void EducationSystem() { }

    }
}
