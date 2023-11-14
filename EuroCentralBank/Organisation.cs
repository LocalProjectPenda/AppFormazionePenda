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
        public Organisation(string bandiera, string moneta, bool esercizi, int costi, int confine)
            :base(bandiera, moneta, esercizi, costi, confine)
        {
            _ONU = new ONU(this);
        }
        
        
    }
}
