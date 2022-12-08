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
using System.IO.Ports;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Variables;

namespace Variables
{
    public partial class Form1 : Form
    {
        public static ksPart transfer;
        public static VariableCollection a;

        public Form1()
        {
            InitializeComponent();
        }

        public class getVariables
        {
            //string path = Environment.CurrentDirectory;
            readonly string path = @"D:\PROJECTS\Kompas C#\Variables";

            public void variables(string detailPath)
            {
                Form1 form1 = new Form1();
                string progId = "KOMPAS.Application.5";
                KompasObject kompas = (KompasObject)Marshal.GetActiveObject(progId);
                _Application My7Komp = (_Application)kompas.ksGetApplication7();

                //Пропустить сообщения
                My7Komp.HideMessage = ksHideMessageEnum.ksHideMessageNo;

                //IKompasDocument3D docOpen = (IKompasDocument3D)My7Komp.Documents.Open(@"D:\PROJECTS\Kompas C#\Variables\Швеллер\Швеллер.m3d", true, true);
                IKompasDocument3D docOpen = (IKompasDocument3D)My7Komp.Documents.Open($@"{path}{detailPath}", true, true);

                IPart7 part7 = docOpen.TopPart;

                transfer = kompas.TransferInterface(part7, 1, 0);

                //Получаем коллекцию внешних переменных
                a = transfer.VariableCollection();

                //обновляем коллекцию внешних переменных
                a.refresh();
            }
        }


        public void rebuildShveller_Click(object sender, EventArgs e)
        {
            getVariables getVariables = new getVariables();
            getVariables.variables(@"\Швеллер\Швеллер.m3d");

            Shveller shveller = new Shveller();
            shveller.editShveller(transfer, a);
        }

        private void rebuildRebroPodObmotki_Click(object sender, EventArgs e)
        {
            getVariables getVariables = new getVariables();
            getVariables.variables(@"\Швеллер\Ребро 2.m3d");

            RebroPodObmotki rebroPodObmotki = new RebroPodObmotki();
            rebroPodObmotki.editRebroPodObmotki(transfer, a);
        }

        private void rebuildKosinka_Click(object sender, EventArgs e)
        {
            getVariables getVariables = new getVariables();
            getVariables.variables(@"\Швеллер\Ребро.m3d");

            Kosinka kosinka = new Kosinka();
            kosinka.editKosinka(transfer, a);
        }

        private void rebuildUpor_Click(object sender, EventArgs e)
        {
            getVariables getVariables = new getVariables();
            getVariables.variables(@"\Швеллер\Упор.m3d");

            Upor upor = new Upor();
            upor.editUpor(transfer, a);
        }
    }
}

