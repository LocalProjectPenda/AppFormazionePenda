using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public class ONU: IONU
    {
        Organisation _organisation;
        public ONU(Organisation organisation)
        {
            _organisation = organisation;
        }

        public void territoryDefense()
        {

        }
      public  void populationControl()
        {

        }
    }
}
