using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables.Forms
{
    public partial class UC_Rebra : UserControl
    {
        public UC_Rebra()
        {
            InitializeComponent();
        }
        public void getValuesRebra()
        {
            Rebra rebra= new Rebra();
            rebra.hRebra = Convert.ToDouble(tbHRebra.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            rebra.bRebraVerh = Convert.ToDouble(tbBRebraVerh.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            rebra.bRebraNiz = Convert.ToDouble(tbBRebraNiz.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            rebra.hFaski = Convert.ToDouble(tbHFaski.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            rebra.bFaski = Convert.ToDouble(tbBFaski.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            rebra.sRebra = Convert.ToDouble(tbSRebra.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
            //BalkaNizhNN.L1 = Convert.ToDouble(tbL1.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
        }

        public void setValuesRebra(object sender, EventArgs e)
        {
            Rebra rebra = new Rebra();
            tbHRebra.Text = Convert.ToString(rebra.hRebra);
            tbBRebraVerh.Text = Convert.ToString(rebra.bRebraVerh);
            tbBRebraNiz.Text = Convert.ToString(rebra.bRebraNiz);
            tbHFaski.Text = Convert.ToString(rebra.hFaski);
            tbBFaski.Text = Convert.ToString(rebra.bFaski);
            tbSRebra.Text = Convert.ToString(rebra.sRebra);
        }

        private static void CleanAllTextBoxesIn(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;

                if (c.GetType() == typeof(GroupBox))
                    CleanAllTextBoxesIn(c);
            }
        }

        private void CleanAllTextBoxesButton_Click(object sender, EventArgs e)
        {
            CleanAllTextBoxesIn(this);
        }

        private void rebuildRebroPodObmotki_Click(object sender, EventArgs e)
        {
            getValuesRebra();
            Rebra rebra = new Rebra();
            rebra.editRebroPodObmotki();
        }
    }
}
