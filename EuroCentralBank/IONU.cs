﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    internal interface IONU : IPoliticalOrg
    {
        void territoryDefense();
        void populationControl();
    }
}
