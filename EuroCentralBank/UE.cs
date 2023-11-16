using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public class UE
    {
        public UEState _UEState ;
       
        public UE()
        {
           
        }
        public void AddUEState(UEState ueState)
        {
            _UEState = ueState;
        }
        public void RemoveUEState()
        {

            _UEState = null;
        }
    }
}

