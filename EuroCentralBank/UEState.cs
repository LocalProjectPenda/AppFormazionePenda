using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    class UEState:State, IUnionEuropea
    {
        public UEState(string bandiera, string moneta, bool esercizi, int costi, int confine) 
            :base(bandiera, moneta, esercizi, costi, confine)
        { }
      public  void ema()
        {

        }
      public  void constitutionIntegration()
        {

        }
        public void humanRightTribunal()
        { 


        }
       
    }
}
