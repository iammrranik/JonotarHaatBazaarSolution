namespace JonotarHaatBazaarProject.GUI
{
    partial class FormAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUser));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblPasswordInfo = new System.Windows.Forms.Label();
            this.lblFullNameError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.lblMobileError = new System.Windows.Forms.Label();
            this.lblNidError = new System.Windows.Forms.Label();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.lblRoleError = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNid = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNid = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LemonChiffon;
            this.pnlMain.Controls.Add(this.lblPasswordInfo);
            this.pnlMain.Controls.Add(this.lblFullNameError);
            this.pnlMain.Controls.Add(this.lblEmailError);
            this.pnlMain.Controls.Add(this.lblUsernameError);
            this.pnlMain.Controls.Add(this.lblMobileError);
            this.pnlMain.Controls.Add(this.lblNidError);
            this.pnlMain.Controls.Add(this.lblAddressError);
            this.pnlMain.Controls.Add(this.lblRoleError);
            this.pnlMain.Controls.Add(this.chkIsActive);
            this.pnlMain.Controls.Add(this.cmbRole);
            this.pnlMain.Controls.Add(this.txtAddress);
            this.pnlMain.Controls.Add(this.txtNid);
            this.pnlMain.Controls.Add(this.txtMobile);
            this.pnlMain.Controls.Add(this.txtUsername);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.txtFullName);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.lblStatus);
            this.pnlMain.Controls.Add(this.lblRole);
            this.pnlMain.Controls.Add(this.lblAddress);
            this.pnlMain.Controls.Add(this.lblNid);
            this.pnlMain.Controls.Add(this.lblMobile);
            this.pnlMain.Controls.Add(this.lblUsername);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.lblFullName);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(494, 551);
            this.pnlMain.TabIndex = 0;
            // 
            // lblPasswordInfo
            // 
            this.lblPasswordInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordInfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPasswordInfo.Location = new System.Drawing.Point(211, 432);
            this.lblPasswordInfo.Name = "lblPasswordInfo";
            this.lblPasswordInfo.Size = new System.Drawing.Size(264, 41);
            this.lblPasswordInfo.TabIndex = 0;
            this.lblPasswordInfo.Text = "Password will be automatically generated as: username@mobile_last_4_digits\r\n";
            // 
            // lblFullNameError
            // 
            this.lblFullNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameError.ForeColor = System.Drawing.Color.Red;
            this.lblFullNameError.Location = new System.Drawing.Point(140, 97);
            this.lblFullNameError.Name = "lblFullNameError";
            this.lblFullNameError.Size = new System.Drawing.Size(320, 15);
            this.lblFullNameError.TabIndex = 0;
            // 
            // lblEmailError
            // 
            this.lblEmailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(140, 147);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(320, 15);
            this.lblEmailError.TabIndex = 0;
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameError.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameError.Location = new System.Drawing.Point(140, 197);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(320, 15);
            this.lblUsernameError.TabIndex = 0;
            // 
            // lblMobileError
            // 
            this.lblMobileError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileError.ForeColor = System.Drawing.Color.Red;
            this.lblMobileError.Location = new System.Drawing.Point(140, 247);
            this.lblMobileError.Name = "lblMobileError";
            this.lblMobileError.Size = new System.Drawing.Size(320, 15);
            this.lblMobileError.TabIndex = 0;
            // 
            // lblNidError
            // 
            this.lblNidError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNidError.ForeColor = System.Drawing.Color.Red;
            this.lblNidError.Location = new System.Drawing.Point(140, 297);
            this.lblNidError.Name = "lblNidError";
            this.lblNidError.Size = new System.Drawing.Size(320, 15);
            this.lblNidError.TabIndex = 0;
            // 
            // lblAddressError
            // 
            this.lblAddressError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(140, 364);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(320, 15);
            this.lblAddressError.TabIndex = 0;
            // 
            // lblRoleError
            // 
            this.lblRoleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleError.ForeColor = System.Drawing.Color.Red;
            this.lblRoleError.Location = new System.Drawing.Point(140, 417);
            this.lblRoleError.Name = "lblRoleError";
            this.lblRoleError.Size = new System.Drawing.Size(320, 15);
            this.lblRoleError.TabIndex = 0;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Location = new System.Drawing.Point(140, 442);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(65, 21);
            this.chkIsActive.TabIndex = 8;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(140, 392);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(320, 24);
            this.cmbRole.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(140, 322);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(320, 40);
            this.txtAddress.TabIndex = 6;
            // 
            // txtNid
            // 
            this.txtNid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNid.Location = new System.Drawing.Point(140, 272);
            this.txtNid.MaxLength = 17;
            this.txtNid.Name = "txtNid";
            this.txtNid.Size = new System.Drawing.Size(320, 23);
            this.txtNid.TabIndex = 5;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(140, 222);
            this.txtMobile.MaxLength = 11;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(320, 23);
            this.txtMobile.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(140, 172);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 23);
            this.txtUsername.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(140, 122);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(140, 72);
            this.txtFullName.MaxLength = 100;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(320, 23);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(262, 492);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(140, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save User";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(40, 442);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 17);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(40, 392);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 17);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(40, 322);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 17);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address:";
            // 
            // lblNid
            // 
            this.lblNid.AutoSize = true;
            this.lblNid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNid.Location = new System.Drawing.Point(40, 272);
            this.lblNid.Name = "lblNid";
            this.lblNid.Size = new System.Drawing.Size(39, 17);
            this.lblNid.TabIndex = 0;
            this.lblNid.Text = "NID:";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(40, 222);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(60, 17);
            this.lblMobile.TabIndex = 0;
            this.lblMobile.Text = "Mobile:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(40, 172);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(40, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(40, 72);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(85, 17);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(140, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New User";
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 551);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New User - Jonotar Haat Bazaar";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblNid;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtNid;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label lblPasswordInfo;
        private System.Windows.Forms.Label lblFullNameError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Label lblMobileError;
        private System.Windows.Forms.Label lblNidError;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.Label lblRoleError;
    }
} 