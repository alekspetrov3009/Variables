using KAPITypes;
using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string progId = "KOMPAS.Application.5";
            KompasObject kompas = (KompasObject)Marshal.GetActiveObject(progId);
            _Application My7Komp = (_Application)kompas.ksGetApplication7();

            //Пропустить сообщения
            My7Komp.HideMessage = ksHideMessageEnum.ksHideMessageNo;

            IKompasDocument3D docOpen = (IKompasDocument3D)My7Komp.Documents.Open(@"D:\PROJECTS\Kompas C#\Variables\Швеллер\Сборка.a3d", true, true);

            IPart7 part7 = docOpen.TopPart;

            ksPart transfer = kompas.TransferInterface(part7, 1, 0);

            //Получаем коллекцию внешних переменных
            VariableCollection a = transfer.VariableCollection();

            //обновляем коллекцию внешних переменных
            a.refresh();

            ksVariable tolschinaShvellera = a.GetByName("SM_Thickness", true, true);
            ksVariable dlinaShvellera = a.GetByName("Dlina_shvellera", true, true);
            ksVariable dlinaVerhPolki = a.GetByName("Dlina_Verh_Polki", true, true);
            ksVariable dlinaNizhPolki = a.GetByName("Dlina_Nizh_Polki", true, true);
            ksVariable radiusVerhPolki = a.GetByName("Radius_Verh_Polki", true, true);
            ksVariable radiusNizhPolki = a.GetByName("Radius_Nizh_Polki", true, true);

            tolschinaShvellera.value = 12;
            dlinaShvellera.value = 1040;
            dlinaVerhPolki.value = 200;
            dlinaNizhPolki.value= 200;
            radiusVerhPolki.value = 15;
            radiusNizhPolki.value = 15;

            transfer.RebuildModel();
            Console.WriteLine(a.ToString());
        }
    }
}
