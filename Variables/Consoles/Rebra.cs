using Kompas6API5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variables.Forms;
using static Variables.Shveller;

namespace Variables
{
    internal class Rebra
    {
        public double hRebra;
        public double bRebraVerh;
        public double bRebraNiz;
        public double hFaski;
        public double bFaski;
        public double sRebra;

        public ksPart transfer;
        public VariableCollection varCol;

        public void getVar(string path)
        {
            GetVariables getVariables = new GetVariables();
            getVariables.variables(path);
            transfer = GetVariables.transfer;
            varCol = GetVariables.varCol;
        }

        public void rebuild()
        {
            transfer.RebuildModel();
        }

        public void editRebroPodObmotki()
        {
            getVar(@"\Швеллер\Ребро 2.m3d");

            ksVariable visotaRebra = varCol.GetByName("visotaRebra", true, true);
            ksVariable shirinaRebraVerh = varCol.GetByName("shirinaRebraVerh", true, true);
            ksVariable shirinaRebraNiz = varCol.GetByName("shirinaRebraNiz", true, true);
            ksVariable shirinaFaski = varCol.GetByName("shirinaFaski", true, true);
            ksVariable visotaFaski = varCol.GetByName("visotaFaski", true, true);
            ksVariable tolschinaRebra = varCol.GetByName("tolschinaRebra", true, true);

            visotaRebra.value = hRebra;                                 /* Высота ребра */
            shirinaRebraVerh.value = bRebraVerh;                        /* Ширина ребра верхняя */
            shirinaRebraNiz.value = bRebraNiz;                          /* Ширина ребра нижняя */
            visotaFaski.value = hFaski;                                 /* Высота фаски */
            shirinaFaski.value = bFaski;                                /* Ширина фаски */
            tolschinaRebra.value = sRebra;                              /* Толщина ребра */


            rebuild();
        }
    }
}
