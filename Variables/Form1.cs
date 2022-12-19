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
using static System.Net.WebRequestMethods;

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
                IKompasDocument3D docOpen = (IKompasDocument3D)My7Komp.Documents.Open($@"{path}{detailPath}", true, false);

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

            if (OtverstiyaPodPolubandazh.Checked == true)
            {
                Shveller.vOB = Convert.ToDouble(textBox1.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.dOB = Convert.ToDouble(textBox2.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.hOB = Convert.ToDouble(textBox3.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.radiusSOB = Convert.ToDouble(textBox4.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            }
            
            if (SmotovieOtverstiya.Checked == true)
            {
                Shveller.diamSO = Convert.ToDouble(textBox5.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            }

            if (OtverstiyaPodMost.Checked == true)
            {
                Shveller.moOPM = Convert.ToDouble(textBox6.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.diamOPM = Convert.ToDouble(textBox7.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            }

            if (OtverstiyaPodLapi.Checked == true)
            {
                Shveller.diamOL = Convert.ToDouble(textBox8.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.moOL = Convert.ToDouble(textBox9.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                Shveller.polkaLapa = Convert.ToDouble(textBox10.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);

            }

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RebuildBalkaYarmNizh_Click(object sender, EventArgs e)
        {
            getVariables getVariables = new getVariables();
            getVariables.variables(@"\Швеллер\Балка ярмовая нижняя.a3d");

            BalkaYarmNizh balkaYarmNizh = new BalkaYarmNizh();
            balkaYarmNizh.editBalkaYarmNizh(transfer, a);
        }

        private void OtverstiyaPodPolubandazh_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;

            if (OtverstiyaPodPolubandazh.Checked == true)
            {
                Shveller.boolOB = 1;
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
            else
                Shveller.boolOB = 0;
        }

        private void SmotrovieOtverstiya_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.ReadOnly = true;

            if (SmotovieOtverstiya.Checked == true)
            {
                Shveller.boolSO = 1;
                textBox5.ReadOnly = false;
            }
            else Shveller.boolSO = 0;
        }

        private void OtverstiyaPodMost_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;

            if (OtverstiyaPodMost.Checked == true)
            {
                Shveller.boolOPM = 1;
                textBox6.ReadOnly = false;
                textBox7.ReadOnly = false;
            }
            else Shveller.boolOPM = 0;
        }

        private void OtverstiyaPodLapi_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;

            if (OtverstiyaPodLapi.Checked == true)
            {
                Shveller.boolOl = 1;
                textBox8.ReadOnly = false;
                textBox9.ReadOnly = false;
                textBox10.ReadOnly = false;
            }
            else Shveller.boolOl = 0;
        }

   
    }
}

