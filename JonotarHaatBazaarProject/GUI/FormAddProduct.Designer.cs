namespace JonotarHaatBazaarProject.GUI
{
    partial class FormAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProduct));
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblExpiaryDate = new System.Windows.Forms.Label();
            this.lblManufactureDate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblExpiaryError = new System.Windows.Forms.Label();
            this.lblManufactureError = new System.Windows.Forms.Label();
            this.lblQuantityError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblCategoryError = new System.Windows.Forms.Label();
            this.lblUnitPriceError = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCreatedError = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiaryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Location = new System.Drawing.Point(130, 404);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(65, 21);
            this.chkIsActive.TabIndex = 35;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(185, 269);
            this.txtCategoryName.MaxLength = 17;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(265, 23);
            this.txtCategoryName.TabIndex = 32;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(185, 119);
            this.txtQuantity.MaxLength = 100;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(265, 23);
            this.txtQuantity.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(185, 75);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 23);
            this.txtName.TabIndex = 28;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(278, 489);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(95, 489);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 35);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save Product";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(30, 404);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 17);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(30, 269);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(129, 17);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "Category Name :";
            // 
            // lblExpiaryDate
            // 
            this.lblExpiaryDate.AutoSize = true;
            this.lblExpiaryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiaryDate.Location = new System.Drawing.Point(30, 219);
            this.lblExpiaryDate.Name = "lblExpiaryDate";
            this.lblExpiaryDate.Size = new System.Drawing.Size(110, 17);
            this.lblExpiaryDate.TabIndex = 14;
            this.lblExpiaryDate.Text = "Expiary Date :";
            // 
            // lblManufactureDate
            // 
            this.lblManufactureDate.AutoSize = true;
            this.lblManufactureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufactureDate.Location = new System.Drawing.Point(30, 169);
            this.lblManufactureDate.Name = "lblManufactureDate";
            this.lblManufactureDate.Size = new System.Drawing.Size(147, 17);
            this.lblManufactureDate.TabIndex = 13;
            this.lblManufactureDate.Text = "Manufacture Date :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(30, 119);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 17);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 17);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(125, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 29);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Add/update Product";
            // 
            // lblExpiaryError
            // 
            this.lblExpiaryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiaryError.ForeColor = System.Drawing.Color.Red;
            this.lblExpiaryError.Location = new System.Drawing.Point(130, 244);
            this.lblExpiaryError.Name = "lblExpiaryError";
            this.lblExpiaryError.Size = new System.Drawing.Size(320, 15);
            this.lblExpiaryError.TabIndex = 25;
            // 
            // lblManufactureError
            // 
            this.lblManufactureError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufactureError.ForeColor = System.Drawing.Color.Red;
            this.lblManufactureError.Location = new System.Drawing.Point(130, 194);
            this.lblManufactureError.Name = "lblManufactureError";
            this.lblManufactureError.Size = new System.Drawing.Size(320, 15);
            this.lblManufactureError.TabIndex = 24;
            // 
            // lblQuantityError
            // 
            this.lblQuantityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityError.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityError.Location = new System.Drawing.Point(130, 144);
            this.lblQuantityError.Name = "lblQuantityError";
            this.lblQuantityError.Size = new System.Drawing.Size(320, 15);
            this.lblQuantityError.TabIndex = 23;
            // 
            // lblNameError
            // 
            this.lblNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(130, 101);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(320, 15);
            this.lblNameError.TabIndex = 22;
            // 
            // lblCategoryError
            // 
            this.lblCategoryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryError.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryError.Location = new System.Drawing.Point(130, 294);
            this.lblCategoryError.Name = "lblCategoryError";
            this.lblCategoryError.Size = new System.Drawing.Size(320, 15);
            this.lblCategoryError.TabIndex = 26;
            // 
            // lblUnitPriceError
            // 
            this.lblUnitPriceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPriceError.ForeColor = System.Drawing.Color.Red;
            this.lblUnitPriceError.Location = new System.Drawing.Point(130, 335);
            this.lblUnitPriceError.Name = "lblUnitPriceError";
            this.lblUnitPriceError.Size = new System.Drawing.Size(320, 15);
            this.lblUnitPriceError.TabIndex = 39;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(185, 309);
            this.txtUnitPrice.MaxLength = 17;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(265, 23);
            this.txtUnitPrice.TabIndex = 40;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(30, 309);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(89, 17);
            this.lblUnitPrice.TabIndex = 38;
            this.lblUnitPrice.Text = "Unit Price :";
            // 
            // lblCreatedError
            // 
            this.lblCreatedError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedError.ForeColor = System.Drawing.Color.Red;
            this.lblCreatedError.Location = new System.Drawing.Point(130, 380);
            this.lblCreatedError.Name = "lblCreatedError";
            this.lblCreatedError.Size = new System.Drawing.Size(320, 15);
            this.lblCreatedError.TabIndex = 42;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.Location = new System.Drawing.Point(30, 354);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(114, 17);
            this.lblCreatedDate.TabIndex = 41;
            this.lblCreatedDate.Text = "Created Date :";
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Location = new System.Drawing.Point(185, 354);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(265, 20);
            this.dtpCreatedDate.TabIndex = 43;
            // 
            // dtpExpiaryDate
            // 
            this.dtpExpiaryDate.Location = new System.Drawing.Point(185, 219);
            this.dtpExpiaryDate.Name = "dtpExpiaryDate";
            this.dtpExpiaryDate.Size = new System.Drawing.Size(265, 20);
            this.dtpExpiaryDate.TabIndex = 44;
            // 
            // dtpManufactureDate
            // 
            this.dtpManufactureDate.Location = new System.Drawing.Point(185, 169);
            this.dtpManufactureDate.Name = "dtpManufactureDate";
            this.dtpManufactureDate.Size = new System.Drawing.Size(265, 20);
            this.dtpManufactureDate.TabIndex = 45;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(185, 43);
            this.txtId.MaxLength = 100;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(265, 23);
            this.txtId.TabIndex = 47;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(30, 43);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 17);
            this.lblId.TabIndex = 46;
            this.lblId.Text = "Id :";
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(494, 551);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dtpManufactureDate);
            this.Controls.Add(this.dtpExpiaryDate);
            this.Controls.Add(this.dtpCreatedDate);
            this.Controls.Add(this.lblCreatedError);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.lblUnitPriceError);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.lblQuantityError);
            this.Controls.Add(this.lblManufactureError);
            this.Controls.Add(this.lblExpiaryError);
            this.Controls.Add(this.lblCategoryError);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblExpiaryDate);
            this.Controls.Add(this.lblManufactureDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Update Product";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblExpiaryDate;
        private System.Windows.Forms.Label lblManufactureDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblExpiaryError;
        private System.Windows.Forms.Label lblManufactureError;
        private System.Windows.Forms.Label lblQuantityError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblCategoryError;
        private System.Windows.Forms.Label lblUnitPriceError;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCreatedError;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.DateTimePicker dtpExpiaryDate;
        private System.Windows.Forms.DateTimePicker dtpManufactureDate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}