using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPenda
{
   abstract class Ente
    {
        
        //public string nameEnte;
        //public string address;
        //protected string PIVA;
        
        
        //    protected string Regione;
        //    protected string Provincia;
        //    protected string Comune;

        public Ente()
            {
            //nameEnte = _nameEnte;
           // address = _address;
           // PIVA = _pIVA;

        }
        public virtual void getInfo()
        {
           // Console.WriteLine($"{nameEnte} {address}");
        }
        


    }
}
