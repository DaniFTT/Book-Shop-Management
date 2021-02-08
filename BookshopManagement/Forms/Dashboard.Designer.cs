namespace BookShopManagement.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnSalesBooks = new System.Windows.Forms.Button();
            this.btnPuchaseItems = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMenuBar = new System.Windows.Forms.Button();
            this.lblLogoResponsivo = new System.Windows.Forms.PictureBox();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLogoResponsivo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.btnSettings);
            this.panelLeft.Controls.Add(this.btnViewSales);
            this.panelLeft.Controls.Add(this.btnUsers);
            this.panelLeft.Controls.Add(this.btnExpenses);
            this.panelLeft.Controls.Add(this.btnPuchaseItems);
            this.panelLeft.Controls.Add(this.btnSalesBooks);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 720);
            this.panelLeft.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLogoResponsivo);
            this.panel2.Controls.Add(this.btnMenuBar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 140);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(215, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(985, 48);
            this.panel4.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.label8);
            this.panelTop.Controls.Add(this.lblTime);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(215, 48);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(985, 92);
            this.panelTop.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(11, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(203, 60);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "    Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book Shop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dan Tecnologies";
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(1, 140);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 60);
            this.panelSide.TabIndex = 3;
            // 
            // btnSalesBooks
            // 
            this.btnSalesBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesBooks.FlatAppearance.BorderSize = 0;
            this.btnSalesBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesBooks.ForeColor = System.Drawing.Color.White;
            this.btnSalesBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesBooks.Image")));
            this.btnSalesBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesBooks.Location = new System.Drawing.Point(11, 205);
            this.btnSalesBooks.Name = "btnSalesBooks";
            this.btnSalesBooks.Size = new System.Drawing.Size(203, 60);
            this.btnSalesBooks.TabIndex = 3;
            this.btnSalesBooks.Text = "    Sale Books";
            this.btnSalesBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesBooks.UseVisualStyleBackColor = true;
            this.btnSalesBooks.Click += new System.EventHandler(this.btnSalesBooks_Click);
            // 
            // btnPuchaseItems
            // 
            this.btnPuchaseItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPuchaseItems.FlatAppearance.BorderSize = 0;
            this.btnPuchaseItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuchaseItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuchaseItems.ForeColor = System.Drawing.Color.White;
            this.btnPuchaseItems.Image = ((System.Drawing.Image)(resources.GetObject("btnPuchaseItems.Image")));
            this.btnPuchaseItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuchaseItems.Location = new System.Drawing.Point(11, 270);
            this.btnPuchaseItems.Name = "btnPuchaseItems";
            this.btnPuchaseItems.Size = new System.Drawing.Size(203, 60);
            this.btnPuchaseItems.TabIndex = 3;
            this.btnPuchaseItems.Text = "    Purchase Items";
            this.btnPuchaseItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPuchaseItems.UseVisualStyleBackColor = true;
            this.btnPuchaseItems.Click += new System.EventHandler(this.btnPuchaseItems_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.ForeColor = System.Drawing.Color.White;
            this.btnExpenses.Image = ((System.Drawing.Image)(resources.GetObject("btnExpenses.Image")));
            this.btnExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.Location = new System.Drawing.Point(11, 335);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(203, 60);
            this.btnExpenses.TabIndex = 3;
            this.btnExpenses.Text = "    Expenses";
            this.btnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(12, 400);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(203, 60);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "    Users";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewSales.FlatAppearance.BorderSize = 0;
            this.btnViewSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSales.ForeColor = System.Drawing.Color.White;
            this.btnViewSales.Image = ((System.Drawing.Image)(resources.GetObject("btnViewSales.Image")));
            this.btnViewSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSales.Location = new System.Drawing.Point(12, 465);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(203, 60);
            this.btnViewSales.TabIndex = 3;
            this.btnViewSales.Text = "    View Sales";
            this.btnViewSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewSales.UseVisualStyleBackColor = true;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(12, 530);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(203, 60);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "    Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.label4.Location = new System.Drawing.Point(23, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Shop Management";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(76, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Role: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(127, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Admin";
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Dock = System.Windows.Forms.DockStyle.Right;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(933, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 48);
            this.button9.TabIndex = 3;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(871, 36);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(83, 19);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "HH:MM:SS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(128, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Daniel Santos";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMenuBar
            // 
            this.btnMenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuBar.FlatAppearance.BorderSize = 0;
            this.btnMenuBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBar.ForeColor = System.Drawing.Color.White;
            this.btnMenuBar.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuBar.Image")));
            this.btnMenuBar.Location = new System.Drawing.Point(158, -1);
            this.btnMenuBar.Name = "btnMenuBar";
            this.btnMenuBar.Size = new System.Drawing.Size(60, 41);
            this.btnMenuBar.TabIndex = 3;
            this.btnMenuBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuBar.UseVisualStyleBackColor = true;
            this.btnMenuBar.Click += new System.EventHandler(this.btnMenuBar_Click);
            // 
            // lblLogoResponsivo
            // 
            this.lblLogoResponsivo.Image = ((System.Drawing.Image)(resources.GetObject("lblLogoResponsivo.Image")));
            this.lblLogoResponsivo.Location = new System.Drawing.Point(-1, 63);
            this.lblLogoResponsivo.Name = "lblLogoResponsivo";
            this.lblLogoResponsivo.Size = new System.Drawing.Size(60, 60);
            this.lblLogoResponsivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lblLogoResponsivo.TabIndex = 5;
            this.lblLogoResponsivo.TabStop = false;
            this.lblLogoResponsivo.Visible = false;
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLogoResponsivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnPuchaseItems;
        private System.Windows.Forms.Button btnSalesBooks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMenuBar;
        private System.Windows.Forms.PictureBox lblLogoResponsivo;
        private System.Windows.Forms.Timer timerTime;
    }
}