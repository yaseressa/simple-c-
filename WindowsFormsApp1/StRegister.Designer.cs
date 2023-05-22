
namespace WindowsFormsApp1
{
    partial class StRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StRegister));
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dtDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbDepartment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnPhotoDel = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPhotoUp = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2GradientPanel8 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnInsert = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPhotoDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPhotoUp)).BeginInit();
            this.guna2GradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(728, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.Size = new System.Drawing.Size(69, 68);
            this.btnExit.TabIndex = 51;
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtDate
            // 
            this.dtDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.dtDate.BorderRadius = 7;
            this.dtDate.BorderThickness = 2;
            this.dtDate.Checked = true;
            this.dtDate.CustomFormat = "dd:MM:yyyy";
            this.dtDate.FillColor = System.Drawing.Color.Black;
            this.dtDate.FocusedColor = System.Drawing.Color.Black;
            this.dtDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtDate.Location = new System.Drawing.Point(350, 338);
            this.dtDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(253, 36);
            this.dtDate.TabIndex = 50;
            this.dtDate.Value = new System.DateTime(2023, 5, 24, 0, 0, 0, 0);
            // 
            // cmbLevel
            // 
            this.cmbLevel.BackColor = System.Drawing.Color.Transparent;
            this.cmbLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.cmbLevel.BorderRadius = 7;
            this.cmbLevel.BorderThickness = 2;
            this.cmbLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FillColor = System.Drawing.Color.Empty;
            this.cmbLevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLevel.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLevel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbLevel.ItemHeight = 30;
            this.cmbLevel.Items.AddRange(new object[] {
            "Level",
            "Freshmen",
            "Sophomore",
            "Junior",
            "Senior"});
            this.cmbLevel.Location = new System.Drawing.Point(350, 277);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(253, 36);
            this.cmbLevel.StartIndex = 0;
            this.cmbLevel.TabIndex = 49;
            this.cmbLevel.Enter += new System.EventHandler(this.cmbLevel_Enter);
            this.cmbLevel.Leave += new System.EventHandler(this.cmbLevel_Leave);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.BackColor = System.Drawing.Color.Transparent;
            this.cmbDepartment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.cmbDepartment.BorderRadius = 7;
            this.cmbDepartment.BorderThickness = 2;
            this.cmbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FillColor = System.Drawing.Color.Empty;
            this.cmbDepartment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepartment.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbDepartment.ItemHeight = 30;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Department",
            "ICT",
            "Engineering",
            "Economy",
            "Medical"});
            this.cmbDepartment.Location = new System.Drawing.Point(350, 212);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(253, 36);
            this.cmbDepartment.StartIndex = 0;
            this.cmbDepartment.TabIndex = 48;
            this.cmbDepartment.Enter += new System.EventHandler(this.cmbDepartment_Enter);
            this.cmbDepartment.Leave += new System.EventHandler(this.cmbDepartment_Leave);
            // 
            // btnPhotoDel
            // 
            this.btnPhotoDel.Image = ((System.Drawing.Image)(resources.GetObject("btnPhotoDel.Image")));
            this.btnPhotoDel.ImageRotate = 0F;
            this.btnPhotoDel.Location = new System.Drawing.Point(363, 33);
            this.btnPhotoDel.Name = "btnPhotoDel";
            this.btnPhotoDel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPhotoDel.Size = new System.Drawing.Size(36, 41);
            this.btnPhotoDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPhotoDel.TabIndex = 47;
            this.btnPhotoDel.TabStop = false;
            this.btnPhotoDel.Click += new System.EventHandler(this.btnPhotoDel_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Animated = true;
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.txtAddress.BorderRadius = 7;
            this.txtAddress.BorderThickness = 2;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "Address";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FillColor = System.Drawing.Color.Empty;
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(24, 338);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(281, 41);
            this.txtAddress.TabIndex = 46;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.txtName.BorderRadius = 7;
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "Name. Omer";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.Empty;
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(24, 277);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(281, 41);
            this.txtName.TabIndex = 45;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // btnPhotoUp
            // 
            this.btnPhotoUp.Image = ((System.Drawing.Image)(resources.GetObject("btnPhotoUp.Image")));
            this.btnPhotoUp.ImageRotate = 0F;
            this.btnPhotoUp.Location = new System.Drawing.Point(258, 33);
            this.btnPhotoUp.Name = "btnPhotoUp";
            this.btnPhotoUp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPhotoUp.Size = new System.Drawing.Size(141, 142);
            this.btnPhotoUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPhotoUp.TabIndex = 44;
            this.btnPhotoUp.TabStop = false;
            this.btnPhotoUp.Click += new System.EventHandler(this.btnPhotoUp_Click);
            // 
            // guna2GradientPanel8
            // 
            this.guna2GradientPanel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel8.BorderRadius = 10;
            this.guna2GradientPanel8.BorderThickness = 2;
            this.guna2GradientPanel8.Controls.Add(this.btnSearch);
            this.guna2GradientPanel8.Controls.Add(this.btnInsert);
            this.guna2GradientPanel8.Controls.Add(this.btnUpdate);
            this.guna2GradientPanel8.Controls.Add(this.btnDelete);
            this.guna2GradientPanel8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel8.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.guna2GradientPanel8.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel8.Location = new System.Drawing.Point(742, 128);
            this.guna2GradientPanel8.Name = "guna2GradientPanel8";
            this.guna2GradientPanel8.Size = new System.Drawing.Size(81, 251);
            this.guna2GradientPanel8.TabIndex = 43;
            this.guna2GradientPanel8.UseTransparentBackground = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageRotate = 0F;
            this.btnSearch.Location = new System.Drawing.Point(15, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 25);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 45;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageRotate = 0F;
            this.btnInsert.Location = new System.Drawing.Point(15, 82);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(25, 25);
            this.btnInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInsert.TabIndex = 44;
            this.btnInsert.TabStop = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleDescription = "btn";
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageRotate = 0F;
            this.btnUpdate.Location = new System.Drawing.Point(15, 147);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(25, 25);
            this.btnUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageRotate = 0F;
            this.btnDelete.Location = new System.Drawing.Point(15, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.Size = new System.Drawing.Size(25, 27);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 41;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtID
            // 
            this.txtID.Animated = true;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.txtID.BorderRadius = 7;
            this.txtID.BorderThickness = 2;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "ID. 293752";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FillColor = System.Drawing.Color.Empty;
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(24, 212);
            this.txtID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(281, 41);
            this.txtID.TabIndex = 42;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // StRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.btnPhotoDel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnPhotoUp);
            this.Controls.Add(this.guna2GradientPanel8);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StRegister";
            this.Text = "StRegister";
            this.Load += new System.EventHandler(this.StRegister_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StRegister_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnPhotoDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPhotoUp)).EndInit();
            this.guna2GradientPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLevel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDepartment;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnPhotoDel;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnPhotoUp;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel8;
        private Guna.UI2.WinForms.Guna2PictureBox btnUpdate;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnDelete;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2PictureBox btnSearch;
        private Guna.UI2.WinForms.Guna2PictureBox btnInsert;
    }
}