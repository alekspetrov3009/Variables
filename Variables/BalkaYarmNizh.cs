using Kompas6API5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class BalkaYarmNizh
    {
        public void editBalkaYarmNizh(ksPart transfer, VariableCollection a)
        {
            ksVariable L1 = a.GetByName("L1", true, true);
            ksVariable L2 = a.GetByName("L1", true, true);
            ksVariable L3 = a.GetByName("L1", true, true);

            L1.value = 200;
            L2.value = 250;
            L3.value = 500;


            transfer.RebuildModel();
        }
    }
}
