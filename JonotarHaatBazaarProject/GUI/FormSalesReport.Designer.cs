namespace JonotarHaatBazaarProject.GUI
{
    partial class FormSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesReport));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.btnThisYear = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnTodaysSales = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblAverageSale = new System.Windows.Forms.Label();
            this.lblNetSales = new System.Windows.Forms.Label();
            this.lblTotalDiscount = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTotalInvoices = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Khaki;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.Black;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1024, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(432, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sales Report";
            // 
            // pnlFilters
            // 
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.btnThisYear);
            this.pnlFilters.Controls.Add(this.btnThisMonth);
            this.pnlFilters.Controls.Add(this.btnTodaysSales);
            this.pnlFilters.Controls.Add(this.btnSearch);
            this.pnlFilters.Controls.Add(this.dtpToDate);
            this.pnlFilters.Controls.Add(this.label2);
            this.pnlFilters.Controls.Add(this.dtpFromDate);
            this.pnlFilters.Controls.Add(this.label1);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.ForeColor = System.Drawing.Color.Black;
            this.pnlFilters.Location = new System.Drawing.Point(0, 60);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1024, 60);
            this.pnlFilters.TabIndex = 1;
            // 
            // btnThisYear
            // 
            this.btnThisYear.BackColor = System.Drawing.Color.Orange;
            this.btnThisYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnThisYear.Location = new System.Drawing.Point(750, 15);
            this.btnThisYear.Name = "btnThisYear";
            this.btnThisYear.Size = new System.Drawing.Size(80, 30);
            this.btnThisYear.TabIndex = 7;
            this.btnThisYear.Text = "This Year";
            this.btnThisYear.UseVisualStyleBackColor = false;
            this.btnThisYear.Click += new System.EventHandler(this.btnThisYear_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.BackColor = System.Drawing.Color.LightBlue;
            this.btnThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnThisMonth.Location = new System.Drawing.Point(650, 15);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(90, 30);
            this.btnThisMonth.TabIndex = 6;
            this.btnThisMonth.Text = "This Month";
            this.btnThisMonth.UseVisualStyleBackColor = false;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnTodaysSales
            // 
            this.btnTodaysSales.BackColor = System.Drawing.Color.LightGreen;
            this.btnTodaysSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnTodaysSales.Location = new System.Drawing.Point(550, 15);
            this.btnTodaysSales.Name = "btnTodaysSales";
            this.btnTodaysSales.Size = new System.Drawing.Size(90, 30);
            this.btnTodaysSales.TabIndex = 5;
            this.btnTodaysSales.Text = "Today";
            this.btnTodaysSales.UseVisualStyleBackColor = false;
            this.btnTodaysSales.Click += new System.EventHandler(this.btnTodaysSales_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(450, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(320, 18);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(120, 24);
            this.dtpToDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(260, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(120, 18);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(120, 24);
            this.dtpFromDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date:";
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.LightGray;
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lblAverageSale);
            this.pnlSummary.Controls.Add(this.lblNetSales);
            this.pnlSummary.Controls.Add(this.lblTotalDiscount);
            this.pnlSummary.Controls.Add(this.lblTotalSales);
            this.pnlSummary.Controls.Add(this.lblTotalInvoices);
            this.pnlSummary.Controls.Add(this.label3);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummary.Location = new System.Drawing.Point(0, 120);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(1024, 56);
            this.pnlSummary.TabIndex = 2;
            // 
            // lblAverageSale
            // 
            this.lblAverageSale.AutoSize = true;
            this.lblAverageSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblAverageSale.ForeColor = System.Drawing.Color.Blue;
            this.lblAverageSale.Location = new System.Drawing.Point(835, 8);
            this.lblAverageSale.Name = "lblAverageSale";
            this.lblAverageSale.Size = new System.Drawing.Size(111, 36);
            this.lblAverageSale.TabIndex = 5;
            this.lblAverageSale.Text = "Average Sale:\r\n$0";
            this.lblAverageSale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNetSales
            // 
            this.lblNetSales.AutoSize = true;
            this.lblNetSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNetSales.ForeColor = System.Drawing.Color.Green;
            this.lblNetSales.Location = new System.Drawing.Point(682, 7);
            this.lblNetSales.Name = "lblNetSales";
            this.lblNetSales.Size = new System.Drawing.Size(92, 40);
            this.lblNetSales.TabIndex = 4;
            this.lblNetSales.Text = "Net Sales:\r\n$0";
            this.lblNetSales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.AutoSize = true;
            this.lblTotalDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalDiscount.ForeColor = System.Drawing.Color.Orange;
            this.lblTotalDiscount.Location = new System.Drawing.Point(473, 8);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(123, 36);
            this.lblTotalDiscount.TabIndex = 3;
            this.lblTotalDiscount.Text = "Total Discount:\r\n$0";
            this.lblTotalDiscount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalSales.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalSales.Location = new System.Drawing.Point(327, 10);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(98, 36);
            this.lblTotalSales.TabIndex = 2;
            this.lblTotalSales.Text = "Total Sales:\r\n$0";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalInvoices
            // 
            this.lblTotalInvoices.AutoSize = true;
            this.lblTotalInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalInvoices.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalInvoices.Location = new System.Drawing.Point(164, 10);
            this.lblTotalInvoices.Name = "lblTotalInvoices";
            this.lblTotalInvoices.Size = new System.Drawing.Size(118, 36);
            this.lblTotalInvoices.TabIndex = 1;
            this.lblTotalInvoices.Text = "Total Invoices:\r\n0";
            this.lblTotalInvoices.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(20, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Summary:- ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 176);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 313);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvInvoices);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice List";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvInvoices.Location = new System.Drawing.Point(3, 20);
            this.dgvInvoices.MultiSelect = false;
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(1018, 150);
            this.dgvInvoices.TabIndex = 0;
            this.dgvInvoices.SelectionChanged += new System.EventHandler(this.dgvInvoices_SelectionChanged);
            this.dgvInvoices.DoubleClick += new System.EventHandler(this.dgvInvoices_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvInvoiceDetails);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1024, 136);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice Details";
            // 
            // dgvInvoiceDetails
            // 
            this.dgvInvoiceDetails.AllowUserToAddRows = false;
            this.dgvInvoiceDetails.AllowUserToDeleteRows = false;
            this.dgvInvoiceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvInvoiceDetails.Location = new System.Drawing.Point(3, 20);
            this.dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            this.dgvInvoiceDetails.ReadOnly = true;
            this.dgvInvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceDetails.Size = new System.Drawing.Size(1018, 113);
            this.dgvInvoiceDetails.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.label4);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnDeleteInvoice);
            this.pnlButtons.Controls.Add(this.btnPrintInvoice);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 489);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1024, 72);
            this.pnlButtons.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Row for see invoice Details & Double click for invoice Edit";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(891, 29);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.LightBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(476, 29);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteInvoice.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteInvoice.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(150, 29);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(140, 30);
            this.btnDeleteInvoice.TabIndex = 2;
            this.btnDeleteInvoice.Text = "Delete Invoice";
            this.btnDeleteInvoice.UseVisualStyleBackColor = false;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrintInvoice.BackColor = System.Drawing.Color.LightGreen;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrintInvoice.Location = new System.Drawing.Point(24, 29);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(120, 30);
            this.btnPrintInvoice.TabIndex = 0;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // FormSalesReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1040, 600);
            this.Name = "FormSalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.FormSalesReport_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblTotalInvoices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalDiscount;
        private System.Windows.Forms.Label lblNetSales;
        private System.Windows.Forms.Label lblAverageSale;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvInvoiceDetails;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTodaysSales;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnThisYear;
        private System.Windows.Forms.Label label4;
    }
} 