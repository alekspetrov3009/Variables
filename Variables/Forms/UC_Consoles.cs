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
    public partial class UC_Consoles : UserControl
    {
        public UC_Consoles()
        {
            InitializeComponent();
        }

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            consolesPanel.Controls.Clear();
            consolesPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void BtnClick(object sender, EventArgs e)
        {
            foreach (var pnl in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            }

            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "btnBalkaNizNN":
                    addUserControls(new UC_BalkaNizNN());
                    panelBalkaNizNN.BackColor = Color.FromArgb((25), (179), (110));
                    break; 

                case "btnBalkaNizVN":
                    addUserControls(new UC_ConsoleTypes());
                    panelBalkaNizVN.BackColor = Color.FromArgb((25), (179), (110));
                    break; 

            }
        }
    }
    
}
