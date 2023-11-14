using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
   public abstract class AreaGeo
    {
        public string _nameGeo;
        public decimal _area;

      public  AreaGeo(string nameGeo, decimal area) 
        {
            _nameGeo = nameGeo;
            _area = area;
        
        }
        public virtual void getInfo()
        {
            Console.WriteLine($"{_nameGeo} {_area}");
        }

    }
}
