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

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
        }

        private void btnSalesBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSalesBooks);
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
