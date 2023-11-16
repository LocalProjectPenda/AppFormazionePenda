using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public class OTANState : IOTAN
    {
        public OTAN _OTAN;

       public OTANState(OTAN otan)
        {
            _OTAN = otan;
            otan.AddOTANState(this);
        }

        public decimal SpesaMilitary(decimal spese)
        {
            decimal quota = spese * 2 / 100;
            return quota;
        }

        

    }
}
