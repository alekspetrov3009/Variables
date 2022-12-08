using Kompas6API5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Kosinka
    {
        public void editKosinka(ksPart transfer, VariableCollection a)
        {
            ksVariable visotaRebra = a.GetByName("visotaRebra", true, true);
            ksVariable shirinaRebraVerh = a.GetByName("shirinaRebraVerh", true, true);
            ksVariable shirinaRebraNiz = a.GetByName("shirinaRebraNiz", true, true);
            ksVariable shirinaFaski = a.GetByName("shirinaFaski", true, true);
            ksVariable visotaFaski = a.GetByName("visotaFaski", true, true);
            ksVariable tolschinaRebra = a.GetByName("tolschinaRebra", true, true);


            visotaRebra.value = 500;
            shirinaRebraVerh.value = 200;
            shirinaRebraNiz.value = 100;
            shirinaFaski.value = 20;
            visotaFaski.value = 15;
            tolschinaRebra.value = 100;


            transfer.RebuildModel();
        }
    }
}
