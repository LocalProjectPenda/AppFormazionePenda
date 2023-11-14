using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    internal class Provincia:AreaGeo, IEnte
    {
       public Provincia(string nameGeo, decimal area):base(nameGeo, area) { }
    }
}
