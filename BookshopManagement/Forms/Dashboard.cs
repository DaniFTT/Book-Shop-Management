using BookShopManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Home ucHome = new UC_Home();
            AddControlsToPanel(ucHome);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                lblLogoResponsivo.Visible = false;
                panelLeft.Width += 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width -= 10;

                if (panelLeft.Width <= 60)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    lblLogoResponsivo.Visible = true;
                    this.Refresh();
                }
            }
        }

        private void btnMenuBar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }


        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UC_Home ucHome = new UC_Home();
            AddControlsToPanel(ucHome);
        }

        private void btnSalesBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSalesBooks);
            UC_Sales ucSales = new UC_Sales();
            AddControlsToPanel(ucSales);
        }

        private void btnPuchaseItems_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPuchaseItems);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnExpenses);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnViewSales);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSettings);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:MM:ss");
        }
    }
}
