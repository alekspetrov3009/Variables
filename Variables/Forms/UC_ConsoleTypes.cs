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
    public partial class UC_ConsoleTypes : UserControl
    {
        public UC_ConsoleTypes()
        {
            InitializeComponent();
        }

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelTypes.Controls.Clear();
            panelTypes.Controls.Add(userControl);
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
                case "balkaType1":
                    addUserControls(new UC_BalkaNizNN());
                    panelType1.BackColor = Color.FromArgb((25), (179), (110));
                    break;

                case "balkaType2":
                    addUserControls(new UC_ConsoleTypes());
                    panelType2.BackColor = Color.FromArgb((25), (179), (110));
                    break;

                case "balkaType3":
                    addUserControls(new UC_ConsoleTypes());
                    panelType3.BackColor = Color.FromArgb((25), (179), (110));
                    break;

                case "balkaType4":
                    addUserControls(new UC_ConsoleTypes());
                    panelType4.BackColor = Color.FromArgb((25), (179), (110));
                    break;

            }
        }
    }
}
