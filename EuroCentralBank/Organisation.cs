using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public class Organisation : State
    {
        ONU _ONU;
        UE _UE;
        public Organisation(string bandiera, string moneta, bool esercizi, int costi, int confine, string nameGeo, decimal area)
            :base(bandiera, moneta, esercizi, costi, confine, nameGeo, area)
        {
            _ONU = new ONU(this);
            _UE = new UE(this);
        }
        
        
    }
}
