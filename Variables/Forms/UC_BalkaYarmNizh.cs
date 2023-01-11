using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables.Forms
{
    public partial class UC_BalkaYarmNizh : UserControl
    {
        public UC_BalkaYarmNizh()
        {
            InitializeComponent();
        }
        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void SideBtnClick(object sender, EventArgs e)
        {
            foreach (var pnl in tableLayoutPanel2.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.FromArgb((20), (67), (97));
            }

            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "btnShveller":
                    addUserControls(new UC_Shveller());
                    sidePanel1.BackColor = Color.FromArgb((25), (179), (110));
                    break;

                case "btnRebra":
                    addUserControls(new UC_Rebra());
                    sidePanel2.BackColor = Color.FromArgb((25), (179), (110));
                    break;

                case "btnSborka":
                    addUserControls(new UC_ConsoleTypes());
                    sidePanel3.BackColor = Color.FromArgb((25), (179), (110));
                    break;


            }
        }
    }
}
