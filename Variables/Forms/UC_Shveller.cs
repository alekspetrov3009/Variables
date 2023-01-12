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
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Variables;
using Variables.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Variables.Forms
{
    public partial class UC_Shveller : UserControl
    {
        public static ksPart transfer;
        public static VariableCollection a;


        public UC_Shveller()
        {
            InitializeComponent();
        }

        public class getVariables
        {
            //string path = Environment.CurrentDirectory;
            readonly string path = @"D:\PROJECTS\Kompas C#\Variables";

            public void variables(string detailPath)
            {
                MainForm form1 = new MainForm();
                string progId = "KOMPAS.Application.5";
                KompasObject kompas = (KompasObject)Marshal.GetActiveObject(progId);
                _Application My7Komp = (_Application)kompas.ksGetApplication7();

                //Пропустить сообщения
                My7Komp.HideMessage = ksHideMessageEnum.ksHideMessageNo;

                //IKompasDocument3D docOpen = (IKompasDocument3D)My7Komp.Documents.Open(@"D:\PROJECTS\Kompas C#\Variables\Швеллер\Швеллер.m3d", true, true);
                IKompasDocument3D docOpen = (IKompasDocument3D)My7Komp.Documents.Open($@"{path}{detailPath}", true, false);

                IPart7 part7 = docOpen.TopPart;

                transfer = kompas.TransferInterface(part7, 1, 0);

                //Получаем коллекцию внешних переменных
                a = transfer.VariableCollection();

                //обновляем коллекцию внешних переменных
                a.refresh();
            }
        }
        private void rebuildShveller_Click(object sender, EventArgs e)
        {
            getVariables getVariables = new getVariables();
            getVariables.variables(@"\Швеллер\Швеллер.m3d");

            Shveller shveller = new Shveller();

            Shveller.tolSchv = Convert.ToDouble(textBox11.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Shveller.dlSchv = Convert.ToDouble(textBox12.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Shveller.shirPolki = Convert.ToDouble(textBox13.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Shveller.radiusSkrugl = Convert.ToDouble(textBox14.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Shveller.mezhOsev = Convert.ToDouble(textBox15.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);


            if (OtverstiyaPodPolubandazh.Checked == true)
            {
                Shveller.vOB = Convert.ToDouble(textBox1.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.dOB = Convert.ToDouble(textBox2.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.hOB = Convert.ToDouble(textBox3.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.radiusSOB = Convert.ToDouble(textBox4.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.boolOB = 1;
            }
            else
                Shveller.boolOB = 0;

            if (SmotovieOtverstiya.Checked == true)
            {
                Shveller.diamSO = Convert.ToDouble(textBox5.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.boolSO = 1;
            }
            else Shveller.boolSO = 0;

            if (OtverstiyaPodMost.Checked == true)
            {
                Shveller.moOPM = Convert.ToDouble(textBox6.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.diamOPM = Convert.ToDouble(textBox7.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.boolOPM = 1;
            }
            else Shveller.boolOPM = 0;

            if (OtverstiyaPodLapi.Checked == true)
            {
                Shveller.diamOL = Convert.ToDouble(textBox8.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.moOL = Convert.ToDouble(textBox9.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.polkaLapa = Convert.ToDouble(textBox10.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.boolOl = 1;
            }
            else Shveller.boolOl = 0;

            shveller.editShveller(transfer, a);
        }
    }
}
