using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
   public class UEState:State, IUnionEuropea
    {
        public UE _UE;
        public UEState(string bandiera, string moneta, bool esercizi, int costi, int confine, string nameGeo, decimal area, UE ue) 
            :base(bandiera, moneta, esercizi, costi, confine, nameGeo, area)
        {
            _UE = ue;
            ue.AddUEState(this);
        }

      
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
