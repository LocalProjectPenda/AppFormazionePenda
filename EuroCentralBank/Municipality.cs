using EuroCentralBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPenda
{
    public class Municipality:AreaGeo, IEnte
    {
        public decimal pil;
        public Citizen _citizen;

        public Municipality(string nameGeo, decimal area, decimal _pil)
            :base(nameGeo, area)
        {
            pil = _pil;
        }
        public override void getInfo()
        {
       
       }
        public void AddCitizen(Citizen citizen)
        {
            _citizen = citizen;
        }
        public void RemoveCirizen()
        {
            _citizen = null;
        }
    }
}
