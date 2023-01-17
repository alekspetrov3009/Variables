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
        public static double hRebra;
        public static double bRebra;
        
        public static double hFaski;
        public static double bFaski;

        public static double hVistupa;
        public static double vnutrShir;

        public static double angle;

        public static double sRebra;


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


            visotaRebra.value = hRebra;         /* Высота ребра */
            shirinaRebra.value = bRebra;        /* Ширина ребра */

            visotaFaski.value = hFaski;         /* Высота фаски */
            shirinaFaski.value = bFaski;        /* Ширина фаски */

            visotaVistupa.value = hVistupa;     /* Высота выступа */
            vnutrShirina.value = vnutrShir;     /* Внутренняя ширина */

            ugol.value = angle;                 /* Угол */

            tolschinaRebra.value = sRebra;      /* Толщина ребра */


            transfer.RebuildModel();
        }
    }
}
