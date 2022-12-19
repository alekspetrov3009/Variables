using Kompas6API5;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public class Shveller : Form
    {
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


        //Form1 Form1 = new Form1();
        public void editShveller(ksPart transfer, VariableCollection a)
        {
            ksVariable tolschinaShvellera = a.GetByName("SM_Thickness", true, true);
            ksVariable dlinaShvellera = a.GetByName("Dlina_shvellera", true, true);
            ksVariable shirinaVerhPolki = a.GetByName("shirinaVerhPolki", true, true);
            ksVariable shirinaNizhPolki = a.GetByName("shirinaNizhPolki", true, true);
            ksVariable radiusVerhPolki = a.GetByName("Radius_Verh_Polki", true, true);
            ksVariable radiusNizhPolki = a.GetByName("Radius_Nizh_Polki", true, true);
            ksVariable MO = a.GetByName("MO", true, true);
            ksVariable visotaOknaBandazha = a.GetByName("visotaOknaBandazha", true, true);
            ksVariable dlinaOknaBandazha = a.GetByName("dlinaOknaBandazha", true, true);
            ksVariable glubinaOknaBandazha = a.GetByName("glubinaOknaBandazha", true, true);
            ksVariable radiusSkrugleniyaOkonBandazha = a.GetByName("radiusSkrugleniyaOkonBandazha", true, true);
            ksVariable diamSmotrOtv = a.GetByName("diamSmotrOtv", true, true);
            ksVariable moOtvPodMost = a.GetByName("moOtvPodMost", true, true);
            ksVariable diamOtvPodMost = a.GetByName("diamOtvPodMost", true, true);
            ksVariable diamOtvLapa = a.GetByName("diamOtvLapa", true, true);
            ksVariable moOtvLapa = a.GetByName("moOtvLapa", true, true);
            ksVariable rasstPolkaLapa = a.GetByName("rasstPolkaLapa", true, true);
            ksVariable boolOknaBandazha = a.GetByName("boolOknaBandazha", true, true);
            ksVariable boolSmotrOtv = a.GetByName("boolSmotrOtv", true, true);
            ksVariable boolOtvPodMost = a.GetByName("boolOtvPodMost", true, true);
            ksVariable boolOtvLapa = a.GetByName("boolOtvLapa", true, true);



            tolschinaShvellera.value = 12;              /* Толщина швеллера */
            dlinaShvellera.value = 1800;                /* Длина швеллера */
            shirinaVerhPolki.value = 200;               /* Ширина верхней полки */
            shirinaNizhPolki.value = 200;               /* Ширина нижней полки */
            radiusVerhPolki.value = 15;                 /* Радиус скругления верхней полки */
            radiusNizhPolki.value = 15;                 /* Радиус скругления нижней полки */
            MO.value = 890;                             /* Межосевое расстояние */

            visotaOknaBandazha.value = vOB;                     /* Высота окна под полубандаж */
            dlinaOknaBandazha.value = dOB;                       /* Длина окна под полубандаж */
            glubinaOknaBandazha.value = hOB;                    /* Глубина выреза окна под полубандаж */
            radiusSkrugleniyaOkonBandazha.value = radiusSOB;    /* Радиус скругления окна под полубандаж */

            diamSmotrOtv.value = diamSO;                        /* Диаметр смотрового отверстия */

            moOtvPodMost.value = moOPM;                           /* Межосевое расстояние отверстий под мосты */
            diamOtvPodMost.value = diamOPM;                          /* Диаметр отверстия под мост */

            diamOtvLapa.value = diamOL;                             /* Диаметр отверстия под лапу */
            moOtvLapa.value = moOL;                              /* Межосевое расстояние отверстий под лапы */
            rasstPolkaLapa.value = polkaLapa;                          /* Расстояние от отверстия под лапы до задней стенки */

            boolOknaBandazha.value = boolOB;                   /* Наличие окон под полубандаж */
            boolSmotrOtv.value = boolSO;                        /* Наличие смотровых отверстий */
            boolOtvPodMost.value = boolOPM;                     /* Наличие отверстий под мосты */
            boolOtvLapa.value = boolOl;                         /* Наличие отверстий под лапы */


            transfer.RebuildModel();

        }
    }
}
