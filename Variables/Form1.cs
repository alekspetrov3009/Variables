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

        private void RebuildBalkaYarmNizh_Click(object sender, EventArgs e)
        {
            getVariables getVariables = new getVariables();
            getVariables.variables(@"\Швеллер\Балка ярмовая нижняя.a3d");

            BalkaYarmNizh balkaYarmNizh = new BalkaYarmNizh();

            BalkaYarmNizh.mezhOsev = Convert.ToDouble(textBox36.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            BalkaYarmNizh.L1 = Convert.ToDouble(textBox37.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            BalkaYarmNizh.L2 = Convert.ToDouble(textBox38.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            BalkaYarmNizh.L3 = Convert.ToDouble(textBox39.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            
            if (OtvDlyaKrepBrusa.Checked== true)
            {
                BalkaYarmNizh.L4 = Convert.ToDouble(textBox40.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                BalkaYarmNizh.diamOtvBrus = Convert.ToDouble(textBox41.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                BalkaYarmNizh.mezhOsevOtvBrus = Convert.ToDouble(textBox42.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                BalkaYarmNizh.Bplastini = Convert.ToDouble(textBox43.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                BalkaYarmNizh.Hplastini = Convert.ToDouble(textBox44.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                BalkaYarmNizh.Splastini = Convert.ToDouble(textBox45.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            }

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

        private void rebuildRebroPodObmotki_Click(object sender, EventArgs e)
        {
            getVariables getVariables = new getVariables();
            getVariables.variables(@"\Швеллер\Ребро 2.m3d");

            RebroPodObmotki rebroPodObmotki = new RebroPodObmotki();

            RebroPodObmotki.hRebra = Convert.ToDouble(textBox16.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            RebroPodObmotki.bRebraVerh = Convert.ToDouble(textBox17.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            RebroPodObmotki.bRebraNiz = Convert.ToDouble(textBox18.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            RebroPodObmotki.hFaski = Convert.ToDouble(textBox19.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            RebroPodObmotki.bFaski = Convert.ToDouble(textBox20.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            RebroPodObmotki.sRebra = Convert.ToDouble(textBox21.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);

            rebroPodObmotki.editRebroPodObmotki(transfer, a);

        }

        private void rebuildKosinka_Click(object sender, EventArgs e)
        {
            getVariables getVariables = new getVariables();
            getVariables.variables(@"\Швеллер\Ребро.m3d");

            Kosinka kosinka = new Kosinka();

            Kosinka.hRebra = Convert.ToDouble(textBox22.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Kosinka.bRebraVerh = Convert.ToDouble(textBox23.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Kosinka.bRebraNiz = Convert.ToDouble(textBox24.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Kosinka.hFaski = Convert.ToDouble(textBox25.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Kosinka.bFaski = Convert.ToDouble(textBox26.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Kosinka.sRebra = Convert.ToDouble(textBox27.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);

            kosinka.editKosinka(transfer, a);
        }

        private void rebuidUpor_Click(object sender, EventArgs e)
        {
            getVariables getVariables = new getVariables();
            getVariables.variables(@"\Швеллер\Упор.m3d");

            Upor upor = new Upor();

            Upor.hRebra = Convert.ToDouble(textBox28.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Upor.bRebra = Convert.ToDouble(textBox29.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Upor.hFaski = Convert.ToDouble(textBox30.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Upor.bFaski = Convert.ToDouble(textBox31.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Upor.hVistupa = Convert.ToDouble(textBox32.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Upor.vnutrShir = Convert.ToDouble(textBox33.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Upor.angle = Convert.ToDouble(textBox34.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            Upor.sRebra = Convert.ToDouble(textBox35.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);

            upor.editUpor(transfer, a);
        }

        private void OtvDlyaKrepBrusa_CheckedChanged(object sender, EventArgs e)
        {
            textBox40.ReadOnly = true;
            textBox41.ReadOnly = true;
            textBox42.ReadOnly = true;
            textBox43.ReadOnly = true;
            textBox44.ReadOnly = true;
            textBox45.ReadOnly = true;


            if (OtvDlyaKrepBrusa.Checked == true)
            {
                BalkaYarmNizh.boolOB = 1;
                BalkaYarmNizh.boolPOM = 1;

                textBox40.ReadOnly = false;
                textBox41.ReadOnly = false;
                textBox42.ReadOnly = false;
                textBox43.ReadOnly = false;
                textBox44.ReadOnly = false;
                textBox45.ReadOnly = false;

            }
            else 
                BalkaYarmNizh.boolOB = 0;

        }

        private void PlastinaPodObmotki_CheckedChanged(object sender, EventArgs e)
        {
            if (PlastinaPodObmotki.Checked == true) 
            {
                BalkaYarmNizh.boolPOM = 1;
            }
            else
                BalkaYarmNizh.boolPOM = 0;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.pictureBox1.Image = pictureBox1.Image;
            form.ShowDialog();
        }


        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            textBox11.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.pictureBox1.Image = pictureBox2.Image;
            form.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.pictureBox1.Image = pictureBox3.Image;
            form.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.pictureBox1.Image = pictureBox4.Image;
            form.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.pictureBox1.Image = pictureBox5.Image;
            form.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.pictureBox1.Image = pictureBox6.Image;
            form.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.pictureBox1.Image = pictureBox7.Image;
            form.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.pictureBox1.Image = pictureBox8.Image;
            form.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.pictureBox1.Image = pictureBox9.Image;
            form.ShowDialog();
        }
    }
}

