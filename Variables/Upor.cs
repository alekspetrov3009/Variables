using Kompas6API5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Upor
    {
        public void editUpor(ksPart transfer, VariableCollection a)
        {
            ksVariable visotaRebra = a.GetByName("visotaRebra", true, true);
            ksVariable shirinaRebra = a.GetByName("shirinaRebra", true, true);
            ksVariable shirinaFaski = a.GetByName("shirinaFaski", true, true);
            ksVariable visotaFaski = a.GetByName("visotaFaski", true, true);
            ksVariable visotaVistupa = a.GetByName("visotaVistupa", true, true);
            ksVariable vnutrShirina = a.GetByName("vnutrShirina", true, true);
            ksVariable ugol = a.GetByName("ugol", true, true);

            ksVariable tolschinaRebra = a.GetByName("tolschinaRebra", true, true);


            visotaRebra.value = 500;
            shirinaRebra.value = 200;
            shirinaFaski.value = 20;
            visotaFaski.value = 15;
            visotaVistupa.value = 10;
            vnutrShirina.value = 50;
            ugol.value = 50;
            tolschinaRebra.value = 100;


            transfer.RebuildModel();
        }
    }
}
