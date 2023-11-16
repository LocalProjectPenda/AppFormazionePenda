using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
   public abstract class State: AreaGeo,IONU, IEnteAdminstrative
    {
        public string bandiera { get; set; }
        public string moneta { get; set; }
        public bool esercizi { get; set; }
        public int costi { get; set; }
        public int confine { get; set; }

        public State(string bandiera, string moneta, bool esercizi, int costi, int confine, string nameGeo, decimal area)
            :base(nameGeo, area)
        {
            this.bandiera = bandiera;
            this.moneta = moneta;
            this.esercizi = esercizi;
            this.costi = costi;
            this.confine = confine;
        }

        public void territoryDefense() { }
        public void populationControl() { }

        public void HNS()
        {
           
        }

        public void LAWSystem()
        {
         
        }

        public void EducationSystem()
        {
            
        }
        // public virtual bool euro() {
        //     return true;
        // }
    }
}
