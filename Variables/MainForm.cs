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
using Variables.Consoles;
using static System.Net.WebRequestMethods;

namespace Variables
{
    public partial class MainForm : Form
    {
        public static ksPart transfer;
        public static VariableCollection a;

        public MainForm()
        {
            InitializeComponent();
        }


        //private void RebuildBalkaYarmNizh_Click(object sender, EventArgs e)
        //{
        //    GetVariables getVariables = new GetVariables();
        //    getVariables.variables(@"\Швеллер\Балка ярмовая нижняя.a3d");

        //    BalkaNizhNN balkaYarmNizh = new BalkaNizhNN();

        //    BalkaNizhNN.mezhOsev = Convert.ToDouble(textBox36.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    BalkaNizhNN.L1 = Convert.ToDouble(textBox37.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    BalkaNizhNN.L2 = Convert.ToDouble(textBox38.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    BalkaNizhNN.L3 = Convert.ToDouble(textBox39.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            
        //    if (OtvDlyaKrepBrusa.Checked== true)
        //    {
        //        BalkaNizhNN.L4 = Convert.ToDouble(textBox40.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //        BalkaNizhNN.diamOtvBrus = Convert.ToDouble(textBox41.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //        BalkaNizhNN.mezhOsevOtvBrus = Convert.ToDouble(textBox42.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //        BalkaNizhNN.Bplastini = Convert.ToDouble(textBox43.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //        BalkaNizhNN.Hplastini = Convert.ToDouble(textBox44.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //        BalkaNizhNN.Splastini = Convert.ToDouble(textBox45.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    }

        //    balkaYarmNizh.editBalkaYarmNizh(transfer, a);
        //}

        //private void rebuildKosinka_Click(object sender, EventArgs e)
        //{
        //    getVariables getVariables = new getVariables();
        //    getVariables.variables(@"\Швеллер\Ребро.m3d");

        //    Kosinka kosinka = new Kosinka();

        //    Kosinka.hRebra = Convert.ToDouble(textBox22.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    Kosinka.bRebraVerh = Convert.ToDouble(textBox23.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    Kosinka.bRebraNiz = Convert.ToDouble(textBox24.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    Kosinka.hFaski = Convert.ToDouble(textBox25.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    Kosinka.bFaski = Convert.ToDouble(textBox26.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    Kosinka.sRebra = Convert.ToDouble(textBox27.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);

        //    kosinka.editKosinka(transfer, a);
        //}

        //private void rebuidUpor_Click(object sender, EventArgs e)
        //{
        //    getVariables getVariables = new getVariables();
        //    getVariables.variables(@"\Швеллер\Упор.m3d");

        //    Upor upor = new Upor();

        //    Upor.hRebra = Convert.ToDouble(textBox28.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    Upor.bRebra = Convert.ToDouble(textBox29.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    Upor.hFaski = Convert.ToDouble(textBox30.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    Upor.bFaski = Convert.ToDouble(textBox31.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    Upor.hVistupa = Convert.ToDouble(textBox32.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    Upor.vnutrShir = Convert.ToDouble(textBox33.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    Upor.angle = Convert.ToDouble(textBox34.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        //    Upor.sRebra = Convert.ToDouble(textBox35.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);

        //    upor.editUpor(transfer, a);
        //}

        //private void OtvDlyaKrepBrusa_CheckedChanged(object sender, EventArgs e)
        //{
        //    textBox40.ReadOnly = true;
        //    textBox41.ReadOnly = true;
        //    textBox42.ReadOnly = true;
        //    textBox43.ReadOnly = true;
        //    textBox44.ReadOnly = true;
        //    textBox45.ReadOnly = true;


        //    if (OtvDlyaKrepBrusa.Checked == true)
        //    {
        //        BalkaNizhNN.boolOB = 1;
        //        BalkaNizhNN.boolPOM = 1;

        //        textBox40.ReadOnly = false;
        //        textBox41.ReadOnly = false;
        //        textBox42.ReadOnly = false;
        //        textBox43.ReadOnly = false;
        //        textBox44.ReadOnly = false;
        //        textBox45.ReadOnly = false;

        //    }
        //    else 
        //        BalkaNizhNN.boolOB = 0;

        //}

        //private void PlastinaPodObmotki_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (PlastinaPodObmotki.Checked == true) 
        //    {
        //        BalkaNizhNN.boolPOM = 1;
        //    }
        //    else
        //        BalkaNizhNN.boolPOM = 0;

        //}

       



        private void addUserControls(UserControl userControl) 
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public static void addUserControlsConsoles(UserControl userControl)
        {
            UC_Consoles consoles = new UC_Consoles();

            userControl.Dock = DockStyle.Fill;
            consoles.consolesPanel.Controls.Clear();
            consoles.consolesPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        

        private void BtnClick(object sender, EventArgs e)
        {
            foreach(var pnl in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            }

            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "consolesButton":
                    addUserControls(new UC_Consoles());
                    
                    break;

                case "inputDataButton":
                    addUserControls(new UC_InputData());
                    break;

                case "btnBalkaNizNN":
                    addUserControlsConsoles(new UC_Shveller());
                    //panelBalkaNizNN.BackColor = Color.FromArgb((20), (67), (97));
                    break;

                default: 
                    break;
            }
        }



        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }







        //private void inputData_Click(object sender, EventArgs e)
        //{
        //    newForm<InputMagnitForm>();
        //    //inputDataButton.BackColor = Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));

        //}

        //private void newForm<MiForm>() where MiForm : Form, new()
        //{
        //    Form newForm;
        //    newForm = mainPanel.Controls.OfType<MiForm>().FirstOrDefault();
        //    if (newForm == null)
        //    {
        //        newForm = new MiForm();
        //        newForm.TopLevel = false;
        //        newForm.FormBorderStyle = FormBorderStyle.None;
        //        newForm.Dock = DockStyle.Fill;
        //        mainPanel.Controls.Add(newForm);
        //        mainPanel.Tag = newForm;
        //        newForm.Show();
        //        newForm.BringToFront();
        //       // formulario.FormClosed += new FormClosedEventHandler(CloseForms);
        //    }
        //    else
        //    {
        //        newForm.BringToFront();
        //    }
        //}

        //private void consolesButton_Click(object sender, EventArgs e)
        //{
        //    newForm<ConsolesForm>();
        //}


        //private void CloseForms(object sender, FormClosedEventArgs e)
        //{
        //    if (System.Windows.Forms.Application.OpenForms["Form1"] == null)
        //        button1.BackColor = Color.FromArgb(4, 41, 68);
        //    if (System.Windows.Forms.Application.OpenForms["Form2"] == null)
        //        button2.BackColor = Color.FromArgb(4, 41, 68);
        //    if (System.Windows.Forms.Application.OpenForms["Form3"] == null)
        //        button3.BackColor = Color.FromArgb(4, 41, 68);
        //}
    }
}

