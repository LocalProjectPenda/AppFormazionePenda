using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    internal class Regione: AreaGeo, IEnte
    {
        public Regione(string nameGeo, decimal area):base(nameGeo, area) 
        {
        }
        
    }
}
