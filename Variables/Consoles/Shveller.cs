using Kompas6API5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class Shveller
    {
        public static double tolSchv;
        public static double dlSchv;
        public static double shirPolki;
        public static double radiusSkrugl;
        public static double mezhOsev;


        public static double vOB;
        public static double dOB;
        public static double hOB;
        public static double radiusSOB;

        public static double diamSO;

        public static double moOPM;
        public static double diamOPM;

        public static double diamOL;
        public static double moOL;
        public static double polkaLapa;

        public static int boolOB;
        public static int boolSO;
        public static int boolOPM;
        public static int boolOl;

        public static ksPart transfer;
        public static VariableCollection varCol;

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

        public void editShveller()
        {
            getVar(@"\Швеллер\Швеллер.m3d");

            ksVariable tolschinaShvellera = varCol.GetByName("SM_Thickness", true, true);
            ksVariable dlinaShvellera = varCol.GetByName("Dlina_shvellera", true, true);
            ksVariable shirinaVerhPolki = varCol.GetByName("shirinaVerhPolki", true, true);
            ksVariable shirinaNizhPolki = varCol.GetByName("shirinaNizhPolki", true, true);
            ksVariable radiusVerhPolki = varCol.GetByName("Radius_Verh_Polki", true, true);
            ksVariable radiusNizhPolki = varCol.GetByName("Radius_Nizh_Polki", true, true);
            ksVariable MO = varCol.GetByName("MO", true, true);
            ksVariable visotaOknaBandazha = varCol.GetByName("visotaOknaBandazha", true, true);
            ksVariable dlinaOknaBandazha = varCol.GetByName("dlinaOknaBandazha", true, true);
            ksVariable glubinaOknaBandazha = varCol.GetByName("glubinaOknaBandazha", true, true);
            ksVariable radiusSkrugleniyaOkonBandazha = varCol.GetByName("radiusSkrugleniyaOkonBandazha", true, true);
            ksVariable diamSmotrOtv = varCol.GetByName("diamSmotrOtv", true, true);
            ksVariable moOtvPodMost = varCol.GetByName("moOtvPodMost", true, true);
            ksVariable diamOtvPodMost = varCol.GetByName("diamOtvPodMost", true, true);
            ksVariable diamOtvLapa = varCol.GetByName("diamOtvLapa", true, true);
            ksVariable moOtvLapa = varCol.GetByName("moOtvLapa", true, true);
            ksVariable rasstPolkaLapa = varCol.GetByName("rasstPolkaLapa", true, true);
            ksVariable boolOknaBandazha = varCol.GetByName("boolOknaBandazha", true, true);
            ksVariable boolSmotrOtv = varCol.GetByName("boolSmotrOtv", true, true);
            ksVariable boolOtvPodMost = varCol.GetByName("boolOtvPodMost", true, true);
            ksVariable boolOtvLapa = varCol.GetByName("boolOtvLapa", true, true);



            tolschinaShvellera.value = tolSchv;                     /* Толщина швеллера */
            dlinaShvellera.value = dlSchv;                          /* Длина швеллера */
            shirinaVerhPolki.value = shirPolki;                     /* Ширина верхней полки */
            shirinaNizhPolki.value = shirPolki;                     /* Ширина нижней полки */
            radiusVerhPolki.value = radiusSkrugl;                   /* Радиус скругления верхней полки */
            radiusNizhPolki.value = radiusSkrugl;                   /* Радиус скругления нижней полки */
            MO.value = mezhOsev;                                    /* Межосевое расстояние */

            visotaOknaBandazha.value = vOB;                         /* Высота окна под полубандаж */
            dlinaOknaBandazha.value = dOB;                          /* Длина окна под полубандаж */
            glubinaOknaBandazha.value = hOB;                        /* Глубина выреза окна под полубандаж */
            radiusSkrugleniyaOkonBandazha.value = radiusSOB;        /* Радиус скругления окна под полубандаж */

            diamSmotrOtv.value = diamSO;                            /* Диаметр смотрового отверстия */

            moOtvPodMost.value = moOPM;                             /* Межосевое расстояние отверстий под мосты */
            diamOtvPodMost.value = diamOPM;                         /* Диаметр отверстия под мост */

            diamOtvLapa.value = diamOL;                             /* Диаметр отверстия под лапу */
            moOtvLapa.value = moOL;                                 /* Межосевое расстояние отверстий под лапы */
            rasstPolkaLapa.value = polkaLapa;                       /* Расстояние от отверстия под лапы до задней стенки */

            boolOknaBandazha.value = boolOB;                        /* Наличие окон под полубандаж */
            boolSmotrOtv.value = boolSO;                            /* Наличие смотровых отверстий */
            boolOtvPodMost.value = boolOPM;                         /* Наличие отверстий под мосты */
            boolOtvLapa.value = boolOl;                             /* Наличие отверстий под лапы */

            rebuild();
        }
    }
}
