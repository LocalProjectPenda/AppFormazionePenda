using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public class OTAN
    {
       public OTANState _OTANState;
       public OTAN()
        {

        }
        public void AddOTANState(OTANState otanState)
        {
            _OTANState = otanState;
        }
        public void RemoveOTANState()
        {
            
            _OTANState = null;
        }
    }
}
