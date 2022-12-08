using Kompas6API5;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ;
namespace Variables
{
    public class Shveller
    {
        public void editShveller(ksPart transfer, VariableCollection a)
        {
            ksVariable tolschinaShvellera = a.GetByName("SM_Thickness", true, true);
            ksVariable dlinaShvellera = a.GetByName("Dlina_shvellera", true, true);
            ksVariable dlinaVerhPolki = a.GetByName("Dlina_Verh_Polki", true, true);
            ksVariable dlinaNizhPolki = a.GetByName("Dlina_Nizh_Polki", true, true);
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

            tolschinaShvellera.value = 12;
            dlinaShvellera.value = 1040;
            dlinaVerhPolki.value = 200;
            dlinaNizhPolki.value = 200;
            radiusVerhPolki.value = 15;
            radiusNizhPolki.value = 15;
            MO.value = 890;
            visotaOknaBandazha.value = 80;
            dlinaOknaBandazha.value = 60;
            glubinaOknaBandazha.value = 50;
            radiusSkrugleniyaOkonBandazha.value = 0;
            diamSmotrOtv.value = 0;
            moOtvPodMost.value = 500;
            diamOtvPodMost.value = 10;
            diamOtvLapa.value = 20;
            moOtvLapa.value = 100;
            rasstPolkaLapa.value = 50;

            transfer.RebuildModel();
        }
    }
}
