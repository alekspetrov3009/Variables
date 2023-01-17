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
        public static double hRebra;
        public static double bRebraVerh;
        public static double bRebraNiz;
        public static double hFaski;
        public static double bFaski;
        public static double sRebra;

        public void editKosinka(ksPart transfer, VariableCollection a)
        {
            ksVariable visotaRebra = a.GetByName("visotaRebra", true, true);
            ksVariable shirinaRebraVerh = a.GetByName("shirinaRebraVerh", true, true);
            ksVariable shirinaRebraNiz = a.GetByName("shirinaRebraNiz", true, true);
            ksVariable shirinaFaski = a.GetByName("shirinaFaski", true, true);
            ksVariable visotaFaski = a.GetByName("visotaFaski", true, true);
            ksVariable tolschinaRebra = a.GetByName("tolschinaRebra", true, true);


            visotaRebra.value = hRebra;                                 /* Высота ребра */
            shirinaRebraVerh.value = bRebraVerh;                        /* Ширина ребра верхняя */
            shirinaRebraNiz.value = bRebraNiz;                          /* Ширина ребра нижняя */
            visotaFaski.value = hFaski;                                 /* Высота фаски */
            shirinaFaski.value = bFaski;                                /* Ширина фаски */
            tolschinaRebra.value = sRebra;                              /* Толщина ребра */


            transfer.RebuildModel();
        }
    }
}
