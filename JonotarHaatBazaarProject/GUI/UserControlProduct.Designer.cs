namespace JonotarHaatBazaarProject.GUI
{
    partial class UserControlProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.jonotarHaatBazaarDataSet = new JonotarHaatBazaarProject.JonotarHaatBazaarDataSet();
            this.jonotarHaatBazaarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jonotarHaatBazaarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jonotarHaatBazaarDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveProduct.BackColor = System.Drawing.Color.Gold;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(224, 3);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(111, 23);
            this.btnRemoveProduct.TabIndex = 28;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = false;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProduct.BackColor = System.Drawing.Color.Gold;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(90, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(128, 23);
            this.btnAddProduct.TabIndex = 26;
            this.btnAddProduct.Text = "Add/Update Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(4, 3);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(80, 23);
            this.btnShowAll.TabIndex = 27;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(895, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 25);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(585, 3);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(103, 18);
            this.lblSearch.TabIndex = 23;
            this.lblSearch.Text = "Search Name:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchName.Location = new System.Drawing.Point(689, 3);
            this.txtSearchName.MaxLength = 100;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(200, 20);
            this.txtSearchName.TabIndex = 22;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeight = 25;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.quantity,
            this.manufactureDate,
            this.expiryDate,
            this.categoryName,
            this.unit_price,
            this.created_date,
            this.is_active});
            this.dgvProduct.DataSource = this.jonotarHaatBazaarDataSetBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.Location = new System.Drawing.Point(0, 32);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1002, 353);
            this.dgvProduct.TabIndex = 25;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 179;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // manufactureDate
            // 
            this.manufactureDate.DataPropertyName = "manufactureDate";
            this.manufactureDate.HeaderText = "Manufacture Date";
            this.manufactureDate.Name = "manufactureDate";
            this.manufactureDate.ReadOnly = true;
            // 
            // expiryDate
            // 
            this.expiryDate.DataPropertyName = "expiryDate";
            this.expiryDate.HeaderText = "Expiary Date";
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.ReadOnly = true;
            this.expiryDate.ToolTipText = "Expiry Date";
            this.expiryDate.Width = 140;
            // 
            // categoryName
            // 
            this.categoryName.DataPropertyName = "categoryName";
            this.categoryName.HeaderText = "Category Name";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // unit_price
            // 
            this.unit_price.DataPropertyName = "unit_price";
            this.unit_price.HeaderText = "Unit Price";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            // 
            // created_date
            // 
            this.created_date.DataPropertyName = "created_date";
            this.created_date.HeaderText = "Created Date";
            this.created_date.Name = "created_date";
            this.created_date.ReadOnly = true;
            // 
            // is_active
            // 
            this.is_active.DataPropertyName = "is_active";
            this.is_active.HeaderText = "Status";
            this.is_active.Name = "is_active";
            this.is_active.ReadOnly = true;
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSelection.Location = new System.Drawing.Point(341, 3);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(80, 23);
            this.btnClearSelection.TabIndex = 29;
            this.btnClearSelection.Text = "Clear Selection";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // jonotarHaatBazaarDataSet
            // 
            this.jonotarHaatBazaarDataSet.DataSetName = "JonotarHaatBazaarDataSet";
            this.jonotarHaatBazaarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jonotarHaatBazaarDataSetBindingSource
            // 
            this.jonotarHaatBazaarDataSetBindingSource.DataSource = this.jonotarHaatBazaarDataSet;
            this.jonotarHaatBazaarDataSetBindingSource.Position = 0;
            // 
            // UserControlProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.dgvProduct);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UserControlProduct";
            this.Size = new System.Drawing.Size(1005, 385);
            this.Load += new System.EventHandler(this.UserControlProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jonotarHaatBazaarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jonotarHaatBazaarDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_active;
        private System.Windows.Forms.BindingSource jonotarHaatBazaarDataSetBindingSource;
        private JonotarHaatBazaarDataSet jonotarHaatBazaarDataSet;
    }
}
