using Kompas6API5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class BalkaNizhNN
    {
        public static double mezhOsev;
        public static double L1;
        public static double L2;
        public static double L3;
        public static double L4;
        public static double mezhOsevOtvBrus;
        public static double diamOtvBrus;
        public static double Bplastini;
        public static double Hplastini;
        public static double Splastini;


        public static int boolOB;
        public static int boolPOM;

        public void editBalkaYarmNizh(ksPart transfer, VariableCollection a)
        {
            ksVariable MO = a.GetByName("MO", true, true);
            ksVariable L_mezhduRebrami = a.GetByName("L1", true, true);
            ksVariable L_mezhduKosinkami = a.GetByName("L2", true, true);
            ksVariable L_mezhduOtvBrus = a.GetByName("L3", true, true);
            ksVariable L_mezhduUporami = a.GetByName("L4", true, true);
            ksVariable moOtvBrus = a.GetByName("moOtvBrus", true, true);
            ksVariable diamOB = a.GetByName("diamOtvBrus", true, true);
            ksVariable B = a.GetByName("B", true, true);
            ksVariable H = a.GetByName("H", true, true);
            ksVariable S = a.GetByName("S", true, true);


            ksVariable boolOtvBrus = a.GetByName("boolOtvBrus", true, true);
            ksVariable boolPlastPodObmotku = a.GetByName("boolPlastPodObmotku", true, true);



            MO.value = mezhOsev;
            L_mezhduRebrami.value = L1;
            L_mezhduKosinkami.value = L2;
            L_mezhduOtvBrus.value = L3;
            L_mezhduUporami.value = L4;
            moOtvBrus.value = mezhOsevOtvBrus;
            diamOB.value = diamOtvBrus;
            B.value = Bplastini;
            H.value = Hplastini;
            S.value = Splastini;

            boolOtvBrus.value = boolOB;
            boolPlastPodObmotku.value = boolPOM;


            transfer.RebuildModel();

        }

    }
   
}
