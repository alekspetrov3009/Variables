using Kompas6API5;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//using ;
namespace Variables
{
    public class Shveller : Form
    {
        Form1 Form1 = new Form1();
        public void editShveller(ksPart transfer, VariableCollection a, int boolOB, int boolSO, int boolOPM, int boolOL)
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

             
            //Form1.textBox1.Text = double.Parse(Form1.textBox1.Text);

            tolschinaShvellera.value = 12;              /* Толщина швеллера */
            dlinaShvellera.value = 1800;                /* Длина швеллера */
            shirinaVerhPolki.value = 200;               /* Ширина верхней полки */
            shirinaNizhPolki.value = 200;               /* Ширина нижней полки */
            radiusVerhPolki.value = 15;                 /* Радиус скругления верхней полки */
            radiusNizhPolki.value = 15;                 /* Радиус скругления нижней полки */
            MO.value = 890;                             /* Межосевое расстояние */

            //visotaOknaBandazha.value = 100;              /* Высота окна под полубандаж */
            //double v = (double)Form1.numericUpDown1.Value;
            //Console.WriteLine(v);

            //string v = Form1.textBox1.Text;

            //Console.WriteLine(v);

            visotaOknaBandazha.value = 50;             /* Высота окна под полубандаж */
            dlinaOknaBandazha.value = 60;               /* Длина окна под полубандаж */
            glubinaOknaBandazha.value = 50;             /* Глубина выреза окна под полубандаж */
            radiusSkrugleniyaOkonBandazha.value = 5;    /* Радиус скругления окна под полубандаж */
            diamSmotrOtv.value = 20;                    /* Диаметр смотрового отверстия */
            moOtvPodMost.value = 500;                   /* Межосевое расстояние отверстий под мосты */
            diamOtvPodMost.value = 10;                  /* Диаметр отверстия под мост */
            diamOtvLapa.value = 20;                     /* Диаметр отверстия под лапу */
            moOtvLapa.value = 100;                      /* Межосевое расстояние отверстий под лапы */
            rasstPolkaLapa.value = 50;                  /* Расстояние от отверстия под лапы до задней стенки */
         
            boolOknaBandazha.value = boolOB ;           /* Наличие окон под полубандаж */
            boolSmotrOtv.value = boolSO;                /* Наличие смотровых отверстий */
            boolOtvPodMost.value = boolOPM;             /* Наличие отверстий под мосты */
            boolOtvLapa.value = boolOL;                 /* Наличие отверстий под лапы */


            transfer.RebuildModel();
            
        }
    }
}
