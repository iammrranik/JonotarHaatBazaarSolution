namespace JonotarHaatBazaarProject.GUI
{
    partial class UserControlAdmin
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jonotarHaatBazaarDataSet = new JonotarHaatBazaarProject.JonotarHaatBazaarDataSet();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.jonotarHaatBazaarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jonotarHaatBazaarDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jonotarHaatBazaarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jonotarHaatBazaarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jonotarHaatBazaarDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(894, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(584, 5);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(103, 18);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search Name:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchName.Location = new System.Drawing.Point(688, 5);
            this.txtSearchName.MaxLength = 100;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(200, 20);
            this.txtSearchName.TabIndex = 14;
            this.txtSearchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchName_KeyDown);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdmin.ColumnHeadersHeight = 25;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.full_name,
            this.email,
            this.username,
            this.role_id,
            this.mobile,
            this.nid,
            this.address,
            this.created_date,
            this.is_active});
            this.dgvAdmin.DataSource = this.jonotarHaatBazaarDataSet;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdmin.Location = new System.Drawing.Point(0, 32);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(1002, 353);
            this.dgvAdmin.TabIndex = 18;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick);
            this.dgvAdmin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "Full name";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // role_id
            // 
            this.role_id.DataPropertyName = "role_name";
            this.role_id.HeaderText = "Role";
            this.role_id.Name = "role_id";
            this.role_id.ReadOnly = true;
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "Mobile";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            // 
            // nid
            // 
            this.nid.DataPropertyName = "nid";
            this.nid.HeaderText = "Nid";
            this.nid.Name = "nid";
            this.nid.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 140;
            // 
            // created_date
            // 
            this.created_date.DataPropertyName = "created_date";
            this.created_date.HeaderText = "Joining";
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
            // jonotarHaatBazaarDataSet
            // 
            this.jonotarHaatBazaarDataSet.DataSetName = "JonotarHaatBazaarDataSet";
            this.jonotarHaatBazaarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUser.BackColor = System.Drawing.Color.Gold;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(89, 5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(82, 23);
            this.btnAddUser.TabIndex = 19;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(3, 5);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(80, 23);
            this.btnShowAll.TabIndex = 20;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveUser.BackColor = System.Drawing.Color.Gold;
            this.btnRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.Location = new System.Drawing.Point(177, 5);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(94, 23);
            this.btnRemoveUser.TabIndex = 21;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSelection.Location = new System.Drawing.Point(277, 5);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(80, 23);
            this.btnClearSelection.TabIndex = 30;
            this.btnClearSelection.Text = "Clear Selection";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // jonotarHaatBazaarDataSetBindingSource
            // 
            this.jonotarHaatBazaarDataSetBindingSource.DataSource = this.jonotarHaatBazaarDataSet;
            this.jonotarHaatBazaarDataSetBindingSource.Position = 0;
            // 
            // jonotarHaatBazaarDataSetBindingSource1
            // 
            this.jonotarHaatBazaarDataSetBindingSource1.DataSource = this.jonotarHaatBazaarDataSet;
            this.jonotarHaatBazaarDataSetBindingSource1.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Double click on row for user Update";
            // 
            // UserControlAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlAdmin";
            this.Size = new System.Drawing.Size(1005, 385);
            this.Load += new System.EventHandler(this.UserAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jonotarHaatBazaarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jonotarHaatBazaarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jonotarHaatBazaarDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_active;
        private JonotarHaatBazaarDataSet jonotarHaatBazaarDataSet;
        private System.Windows.Forms.BindingSource jonotarHaatBazaarDataSetBindingSource;
        private System.Windows.Forms.BindingSource jonotarHaatBazaarDataSetBindingSource1;
        private System.Windows.Forms.Label label1;
    }
}
