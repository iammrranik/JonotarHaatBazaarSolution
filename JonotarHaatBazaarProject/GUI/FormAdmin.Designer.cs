namespace JonotarHaatBazaarProject.GUI
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addSellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellReportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlUserControl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Khaki;
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1024, 108);
            this.pnlTop.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::JonotarHaatBazaarProject.Properties.Resources.LogoTitleFull;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(432, 45);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(173, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Admin";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(19, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 53);
            this.panel2.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.Location = new System.Drawing.Point(888, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 28);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.manageProductsToolStripMenuItem1,
            this.invoicesToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(6, 12);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(339, 26);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage User\'s";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // manageProductsToolStripMenuItem1
            // 
            this.manageProductsToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.manageProductsToolStripMenuItem1.Name = "manageProductsToolStripMenuItem1";
            this.manageProductsToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.manageProductsToolStripMenuItem1.Text = "Manage Products";
            this.manageProductsToolStripMenuItem1.Click += new System.EventHandler(this.manageProductsToolStripMenuItem1_Click);
            // 
            // invoicesToolStripMenuItem1
            // 
            this.invoicesToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.invoicesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSellToolStripMenuItem,
            this.sellReportsToolStripMenuItem1});
            this.invoicesToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.invoicesToolStripMenuItem1.Name = "invoicesToolStripMenuItem1";
            this.invoicesToolStripMenuItem1.Size = new System.Drawing.Size(74, 22);
            this.invoicesToolStripMenuItem1.Text = "Invoices";
            // 
            // addSellToolStripMenuItem
            // 
            this.addSellToolStripMenuItem.Name = "addSellToolStripMenuItem";
            this.addSellToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addSellToolStripMenuItem.Text = "Add Sell";
            this.addSellToolStripMenuItem.Click += new System.EventHandler(this.addSellToolStripMenuItem_Click);
            // 
            // sellReportsToolStripMenuItem1
            // 
            this.sellReportsToolStripMenuItem1.Name = "sellReportsToolStripMenuItem1";
            this.sellReportsToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.sellReportsToolStripMenuItem1.Text = "Sell Report\'s";
            this.sellReportsToolStripMenuItem1.Click += new System.EventHandler(this.sellReportsToolStripMenuItem1_Click);
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserControl.Location = new System.Drawing.Point(19, 161);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.Size = new System.Drawing.Size(1005, 385);
            this.pnlUserControl.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 438);
            this.panel1.TabIndex = 2;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 546);
            this.Controls.Add(this.pnlUserControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1040, 585);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlUserControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addSellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellReportsToolStripMenuItem1;
    }
}