using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    class EuroZoneState :UEState, IBankCentral
    {
       // public bool euro {  get; set; }

        public EuroZoneState(string bandiera, string moneta, bool esercizi, int costi, int confine, string nameGeo, decimal area) 
            :base(bandiera, moneta, esercizi, costi, confine, nameGeo, area) 
            { }
        public void monentaUnica() { }
        public void calcSpread()
        {

            Console.WriteLine("Spread");
        }
        public void stateEuro()
        {

             Console.WriteLine("euro zone");
        }
    }
}
