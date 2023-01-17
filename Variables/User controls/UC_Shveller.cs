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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Variables.Forms
{
    public partial class UC_Shveller : UserControl
    {

        public UC_Shveller()
        {
            InitializeComponent();
        }

        public void getValuesShveller()
        {
            Shveller shveller  = new Shveller();
            shveller.tolSchv = Convert.ToDouble(tbTolSchv.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            shveller.dlSchv = Convert.ToDouble(tbDlSchv.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            shveller.shirPolki = Convert.ToDouble(tbShirPolki.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            shveller.radiusSkrugl = Convert.ToDouble(tbRadiusSkrugl.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            shveller.mezhOsev = Convert.ToDouble(tbMO.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);


            //if (cbOtverstiyaPodPolubandazh.Checked == true)
            //{
            //    Shveller.vOB = Convert.ToDouble(tbvOB.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            //    Shveller.dOB = Convert.ToDouble(tbdOB.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            //    Shveller.hOB = Convert.ToDouble(tbhOB.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            //    Shveller.radiusSOB = Convert.ToDouble(tbRadiusSOB.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            //    Shveller.boolOB = 1;
            //}
            //else
            //    Shveller.boolOB = 0;
                


            //if (cbSmotovieOtverstiya.Checked == true)
            //{
            //    Shveller.diamSO = Convert.ToDouble(tbDiamSO.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            //    Shveller.boolSO = 1;
            //}
            //else
            //    Shveller.boolSO = 0;


            //if (cbOtverstiyaPodMost.Checked == true)
            //{
            //    Shveller.moOPM = Convert.ToDouble(tbMoOPM.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            //    Shveller.diamOPM = Convert.ToDouble(tbDiamOPM.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            //    Shveller.boolOPM = 1;
            //}
            //else
            //    Shveller.boolOPM = 0;


            //if (cbOtverstiyaPodLapi.Checked == true)
            //{
            //    Shveller.diamOL = Convert.ToDouble(tbDiamOL.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            //    Shveller.moOL = Convert.ToDouble(tbMoOL.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            //    Shveller.polkaLapa = Convert.ToDouble(tbPolkaLapa.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            //    Shveller.boolOl = 1;
            //}
            //else
            //    Shveller.boolOl = 0;
        }

        private void rebuildShveller_Click(object sender, EventArgs e)
        {
            getValuesShveller();
            Shveller shveller= new Shveller();
            shveller.editShveller();
        }
        public static void enablePanel(Control parent)
        {

            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(Panel))
                    c.Enabled = true;
                //else
                //    c.Enabled = false;
            }
        }
        private void enablePanelHandler(object sender, EventArgs e)
        {
            enablePanel(this);
        }

    }
}
