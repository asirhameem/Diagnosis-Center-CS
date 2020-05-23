namespace HMSProject.Application_Layer
{
    partial class ManageDoctor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new MetroFramework.Controls.MetroPanel();
            this.cmbFilter = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.mgvDoctor = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlDoctor = new MetroFramework.Controls.MetroPanel();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnLogoutD = new MetroFramework.Controls.MetroButton();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtDspeciality = new MetroFramework.Controls.MetroTextBox();
            this.txtDavailable = new MetroFramework.Controls.MetroTextBox();
            this.txtDage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtDphone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtDsex = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtDaddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtDreference = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnAback = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.txtDname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvDoctor)).BeginInit();
            this.pnlDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.cmbFilter);
            this.pnlMain.Controls.Add(this.metroLabel4);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.txtPhone);
            this.pnlMain.Controls.Add(this.metroLabel3);
            this.pnlMain.Controls.Add(this.txtId);
            this.pnlMain.Controls.Add(this.metroLabel2);
            this.pnlMain.Controls.Add(this.btnLogout);
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.btnEdit);
            this.pnlMain.Controls.Add(this.mgvDoctor);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.metroLabel1);
            this.pnlMain.HorizontalScrollbarBarColor = true;
            this.pnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMain.HorizontalScrollbarSize = 10;
            this.pnlMain.Location = new System.Drawing.Point(23, 63);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1155, 483);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.VerticalScrollbarBarColor = true;
            this.pnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMain.VerticalScrollbarSize = 10;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.ItemHeight = 24;
            this.cmbFilter.Items.AddRange(new object[] {
            "Male",
            "Female",
            "ENT",
            "Arthopedic",
            "Dental",
            "Urology",
            "Skin",
            "Gynocology",
            "Eye"});
            this.cmbFilter.Location = new System.Drawing.Point(111, 204);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(199, 30);
            this.cmbFilter.TabIndex = 29;
            this.cmbFilter.UseSelectable = true;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 214);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 20);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Filter By:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(555, 418);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 32);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(707, 418);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 32);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(111, 139);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(199, 30);
            this.txtPhone.TabIndex = 25;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(31, 149);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 20);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Phone:";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(111, 19);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(199, 30);
            this.txtId.TabIndex = 23;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(60, 28);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(23, 20);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Id:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1011, 418);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(117, 32);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(31, 298);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 32);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(862, 418);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 32);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // mgvDoctor
            // 
            this.mgvDoctor.AllowUserToResizeRows = false;
            this.mgvDoctor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvDoctor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvDoctor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvDoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.age,
            this.sex,
            this.reference,
            this.speciality,
            this.available,
            this.time,
            this.address,
            this.phone});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvDoctor.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgvDoctor.EnableHeadersVisualStyles = false;
            this.mgvDoctor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvDoctor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvDoctor.Location = new System.Drawing.Point(316, 19);
            this.mgvDoctor.Name = "mgvDoctor";
            this.mgvDoctor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvDoctor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgvDoctor.RowHeadersWidth = 51;
            this.mgvDoctor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvDoctor.RowTemplate.Height = 24;
            this.mgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvDoctor.Size = new System.Drawing.Size(823, 356);
            this.mgvDoctor.TabIndex = 18;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "Sex";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // reference
            // 
            this.reference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reference.DataPropertyName = "reference";
            this.reference.HeaderText = "Reference";
            this.reference.MinimumWidth = 6;
            this.reference.Name = "reference";
            this.reference.ReadOnly = true;
            // 
            // speciality
            // 
            this.speciality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.speciality.DataPropertyName = "speciality";
            this.speciality.HeaderText = "Speciality";
            this.speciality.MinimumWidth = 6;
            this.speciality.Name = "speciality";
            // 
            // available
            // 
            this.available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.available.DataPropertyName = "available";
            this.available.HeaderText = "Available";
            this.available.MinimumWidth = 6;
            this.available.Name = "available";
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Time";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(189, 298);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 32);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(111, 78);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(199, 30);
            this.txtName.TabIndex = 16;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 20);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Name:";
            // 
            // pnlDoctor
            // 
            this.pnlDoctor.Controls.Add(this.dtpTime);
            this.pnlDoctor.Controls.Add(this.btnLogoutD);
            this.pnlDoctor.Controls.Add(this.metroLabel14);
            this.pnlDoctor.Controls.Add(this.metroLabel13);
            this.pnlDoctor.Controls.Add(this.metroLabel12);
            this.pnlDoctor.Controls.Add(this.txtDspeciality);
            this.pnlDoctor.Controls.Add(this.txtDavailable);
            this.pnlDoctor.Controls.Add(this.txtDage);
            this.pnlDoctor.Controls.Add(this.metroLabel10);
            this.pnlDoctor.Controls.Add(this.txtDphone);
            this.pnlDoctor.Controls.Add(this.metroLabel7);
            this.pnlDoctor.Controls.Add(this.txtDsex);
            this.pnlDoctor.Controls.Add(this.metroLabel8);
            this.pnlDoctor.Controls.Add(this.txtDaddress);
            this.pnlDoctor.Controls.Add(this.metroLabel9);
            this.pnlDoctor.Controls.Add(this.txtDreference);
            this.pnlDoctor.Controls.Add(this.metroLabel5);
            this.pnlDoctor.Controls.Add(this.txtDid);
            this.pnlDoctor.Controls.Add(this.metroLabel6);
            this.pnlDoctor.Controls.Add(this.btnAback);
            this.pnlDoctor.Controls.Add(this.btnUpdate);
            this.pnlDoctor.Controls.Add(this.txtDname);
            this.pnlDoctor.Controls.Add(this.metroLabel11);
            this.pnlDoctor.HorizontalScrollbarBarColor = true;
            this.pnlDoctor.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDoctor.HorizontalScrollbarSize = 10;
            this.pnlDoctor.Location = new System.Drawing.Point(23, 63);
            this.pnlDoctor.Name = "pnlDoctor";
            this.pnlDoctor.Size = new System.Drawing.Size(1151, 483);
            this.pnlDoctor.TabIndex = 30;
            this.pnlDoctor.VerticalScrollbarBarColor = true;
            this.pnlDoctor.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDoctor.VerticalScrollbarSize = 10;
            this.pnlDoctor.Visible = false;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm tt";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(704, 356);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(264, 30);
            this.dtpTime.TabIndex = 55;
            // 
            // btnLogoutD
            // 
            this.btnLogoutD.Location = new System.Drawing.Point(847, 423);
            this.btnLogoutD.Name = "btnLogoutD";
            this.btnLogoutD.Size = new System.Drawing.Size(121, 32);
            this.btnLogoutD.TabIndex = 54;
            this.btnLogoutD.Text = "Logout";
            this.btnLogoutD.UseSelectable = true;
            this.btnLogoutD.Click += new System.EventHandler(this.btnLogoutD_Click);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(599, 356);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(43, 20);
            this.metroLabel14.TabIndex = 53;
            this.metroLabel14.Text = "Time:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(575, 286);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(67, 20);
            this.metroLabel13.TabIndex = 52;
            this.metroLabel13.Text = "Available:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(573, 211);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(69, 20);
            this.metroLabel12.TabIndex = 51;
            this.metroLabel12.Text = "Speciality:";
            // 
            // txtDspeciality
            // 
            // 
            // 
            // 
            this.txtDspeciality.CustomButton.Image = null;
            this.txtDspeciality.CustomButton.Location = new System.Drawing.Point(226, 2);
            this.txtDspeciality.CustomButton.Name = "";
            this.txtDspeciality.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDspeciality.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDspeciality.CustomButton.TabIndex = 1;
            this.txtDspeciality.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDspeciality.CustomButton.UseSelectable = true;
            this.txtDspeciality.CustomButton.Visible = false;
            this.txtDspeciality.Lines = new string[0];
            this.txtDspeciality.Location = new System.Drawing.Point(704, 191);
            this.txtDspeciality.MaxLength = 32767;
            this.txtDspeciality.Name = "txtDspeciality";
            this.txtDspeciality.PasswordChar = '\0';
            this.txtDspeciality.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDspeciality.SelectedText = "";
            this.txtDspeciality.SelectionLength = 0;
            this.txtDspeciality.SelectionStart = 0;
            this.txtDspeciality.ShortcutsEnabled = true;
            this.txtDspeciality.Size = new System.Drawing.Size(264, 40);
            this.txtDspeciality.TabIndex = 50;
            this.txtDspeciality.UseSelectable = true;
            this.txtDspeciality.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDspeciality.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDavailable
            // 
            // 
            // 
            // 
            this.txtDavailable.CustomButton.Image = null;
            this.txtDavailable.CustomButton.Location = new System.Drawing.Point(226, 2);
            this.txtDavailable.CustomButton.Name = "";
            this.txtDavailable.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDavailable.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDavailable.CustomButton.TabIndex = 1;
            this.txtDavailable.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDavailable.CustomButton.UseSelectable = true;
            this.txtDavailable.CustomButton.Visible = false;
            this.txtDavailable.Lines = new string[0];
            this.txtDavailable.Location = new System.Drawing.Point(704, 266);
            this.txtDavailable.MaxLength = 32767;
            this.txtDavailable.Name = "txtDavailable";
            this.txtDavailable.PasswordChar = '\0';
            this.txtDavailable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDavailable.SelectedText = "";
            this.txtDavailable.SelectionLength = 0;
            this.txtDavailable.SelectionStart = 0;
            this.txtDavailable.ShortcutsEnabled = true;
            this.txtDavailable.Size = new System.Drawing.Size(264, 40);
            this.txtDavailable.TabIndex = 49;
            this.txtDavailable.UseSelectable = true;
            this.txtDavailable.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDavailable.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDage
            // 
            // 
            // 
            // 
            this.txtDage.CustomButton.Image = null;
            this.txtDage.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.txtDage.CustomButton.Name = "";
            this.txtDage.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDage.CustomButton.TabIndex = 1;
            this.txtDage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDage.CustomButton.UseSelectable = true;
            this.txtDage.CustomButton.Visible = false;
            this.txtDage.Lines = new string[0];
            this.txtDage.Location = new System.Drawing.Point(167, 191);
            this.txtDage.MaxLength = 32767;
            this.txtDage.Name = "txtDage";
            this.txtDage.PasswordChar = '\0';
            this.txtDage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDage.SelectedText = "";
            this.txtDage.SelectionLength = 0;
            this.txtDage.SelectionStart = 0;
            this.txtDage.ShortcutsEnabled = true;
            this.txtDage.Size = new System.Drawing.Size(254, 40);
            this.txtDage.TabIndex = 47;
            this.txtDage.UseSelectable = true;
            this.txtDage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(83, 191);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(37, 20);
            this.metroLabel10.TabIndex = 46;
            this.metroLabel10.Text = "Age:";
            // 
            // txtDphone
            // 
            // 
            // 
            // 
            this.txtDphone.CustomButton.Image = null;
            this.txtDphone.CustomButton.Location = new System.Drawing.Point(226, 2);
            this.txtDphone.CustomButton.Name = "";
            this.txtDphone.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDphone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDphone.CustomButton.TabIndex = 1;
            this.txtDphone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDphone.CustomButton.UseSelectable = true;
            this.txtDphone.CustomButton.Visible = false;
            this.txtDphone.Lines = new string[0];
            this.txtDphone.Location = new System.Drawing.Point(704, 123);
            this.txtDphone.MaxLength = 32767;
            this.txtDphone.Name = "txtDphone";
            this.txtDphone.PasswordChar = '\0';
            this.txtDphone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDphone.SelectedText = "";
            this.txtDphone.SelectionLength = 0;
            this.txtDphone.SelectionStart = 0;
            this.txtDphone.ShortcutsEnabled = true;
            this.txtDphone.Size = new System.Drawing.Size(264, 40);
            this.txtDphone.TabIndex = 45;
            this.txtDphone.UseSelectable = true;
            this.txtDphone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDphone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(533, 143);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(109, 20);
            this.metroLabel7.TabIndex = 44;
            this.metroLabel7.Text = "Phone Number:";
            // 
            // txtDsex
            // 
            // 
            // 
            // 
            this.txtDsex.CustomButton.Image = null;
            this.txtDsex.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.txtDsex.CustomButton.Name = "";
            this.txtDsex.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDsex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDsex.CustomButton.TabIndex = 1;
            this.txtDsex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDsex.CustomButton.UseSelectable = true;
            this.txtDsex.CustomButton.Visible = false;
            this.txtDsex.Lines = new string[0];
            this.txtDsex.Location = new System.Drawing.Point(167, 266);
            this.txtDsex.MaxLength = 32767;
            this.txtDsex.Name = "txtDsex";
            this.txtDsex.PasswordChar = '\0';
            this.txtDsex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDsex.SelectedText = "";
            this.txtDsex.SelectionLength = 0;
            this.txtDsex.SelectionStart = 0;
            this.txtDsex.ShortcutsEnabled = true;
            this.txtDsex.Size = new System.Drawing.Size(254, 40);
            this.txtDsex.TabIndex = 43;
            this.txtDsex.UseSelectable = true;
            this.txtDsex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDsex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(87, 266);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(33, 20);
            this.metroLabel8.TabIndex = 42;
            this.metroLabel8.Text = "Sex:";
            // 
            // txtDaddress
            // 
            // 
            // 
            // 
            this.txtDaddress.CustomButton.Image = null;
            this.txtDaddress.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.txtDaddress.CustomButton.Name = "";
            this.txtDaddress.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.txtDaddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDaddress.CustomButton.TabIndex = 1;
            this.txtDaddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDaddress.CustomButton.UseSelectable = true;
            this.txtDaddress.CustomButton.Visible = false;
            this.txtDaddress.Lines = new string[0];
            this.txtDaddress.Location = new System.Drawing.Point(704, 30);
            this.txtDaddress.MaxLength = 32767;
            this.txtDaddress.Name = "txtDaddress";
            this.txtDaddress.PasswordChar = '\0';
            this.txtDaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDaddress.SelectedText = "";
            this.txtDaddress.SelectionLength = 0;
            this.txtDaddress.SelectionStart = 0;
            this.txtDaddress.ShortcutsEnabled = true;
            this.txtDaddress.Size = new System.Drawing.Size(264, 60);
            this.txtDaddress.TabIndex = 41;
            this.txtDaddress.UseSelectable = true;
            this.txtDaddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDaddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(580, 70);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(62, 20);
            this.metroLabel9.TabIndex = 40;
            this.metroLabel9.Text = "Address:";
            // 
            // txtDreference
            // 
            // 
            // 
            // 
            this.txtDreference.CustomButton.Image = null;
            this.txtDreference.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.txtDreference.CustomButton.Name = "";
            this.txtDreference.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDreference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDreference.CustomButton.TabIndex = 1;
            this.txtDreference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDreference.CustomButton.UseSelectable = true;
            this.txtDreference.CustomButton.Visible = false;
            this.txtDreference.Lines = new string[0];
            this.txtDreference.Location = new System.Drawing.Point(167, 349);
            this.txtDreference.MaxLength = 32767;
            this.txtDreference.Name = "txtDreference";
            this.txtDreference.PasswordChar = '\0';
            this.txtDreference.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDreference.SelectedText = "";
            this.txtDreference.SelectionLength = 0;
            this.txtDreference.SelectionStart = 0;
            this.txtDreference.ShortcutsEnabled = true;
            this.txtDreference.Size = new System.Drawing.Size(254, 40);
            this.txtDreference.TabIndex = 39;
            this.txtDreference.UseSelectable = true;
            this.txtDreference.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDreference.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(47, 349);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 20);
            this.metroLabel5.TabIndex = 38;
            this.metroLabel5.Text = "Reference";
            // 
            // txtDid
            // 
            // 
            // 
            // 
            this.txtDid.CustomButton.Image = null;
            this.txtDid.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.txtDid.CustomButton.Name = "";
            this.txtDid.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDid.CustomButton.TabIndex = 1;
            this.txtDid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDid.CustomButton.UseSelectable = true;
            this.txtDid.CustomButton.Visible = false;
            this.txtDid.Lines = new string[0];
            this.txtDid.Location = new System.Drawing.Point(167, 37);
            this.txtDid.MaxLength = 32767;
            this.txtDid.Name = "txtDid";
            this.txtDid.PasswordChar = '\0';
            this.txtDid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDid.SelectedText = "";
            this.txtDid.SelectionLength = 0;
            this.txtDid.SelectionStart = 0;
            this.txtDid.ShortcutsEnabled = true;
            this.txtDid.Size = new System.Drawing.Size(254, 40);
            this.txtDid.TabIndex = 37;
            this.txtDid.UseSelectable = true;
            this.txtDid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(97, 57);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(23, 20);
            this.metroLabel6.TabIndex = 36;
            this.metroLabel6.Text = "Id:";
            // 
            // btnAback
            // 
            this.btnAback.Location = new System.Drawing.Point(495, 423);
            this.btnAback.Name = "btnAback";
            this.btnAback.Size = new System.Drawing.Size(115, 32);
            this.btnAback.TabIndex = 35;
            this.btnAback.Text = "Back";
            this.btnAback.UseSelectable = true;
            this.btnAback.Click += new System.EventHandler(this.btnAback_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(665, 423);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 32);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDname
            // 
            // 
            // 
            // 
            this.txtDname.CustomButton.Image = null;
            this.txtDname.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.txtDname.CustomButton.Name = "";
            this.txtDname.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDname.CustomButton.TabIndex = 1;
            this.txtDname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDname.CustomButton.UseSelectable = true;
            this.txtDname.CustomButton.Visible = false;
            this.txtDname.Lines = new string[0];
            this.txtDname.Location = new System.Drawing.Point(167, 113);
            this.txtDname.MaxLength = 32767;
            this.txtDname.Name = "txtDname";
            this.txtDname.PasswordChar = '\0';
            this.txtDname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDname.SelectedText = "";
            this.txtDname.SelectionLength = 0;
            this.txtDname.SelectionStart = 0;
            this.txtDname.ShortcutsEnabled = true;
            this.txtDname.Size = new System.Drawing.Size(254, 40);
            this.txtDname.TabIndex = 33;
            this.txtDname.UseSelectable = true;
            this.txtDname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(70, 113);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(50, 20);
            this.metroLabel11.TabIndex = 32;
            this.metroLabel11.Text = "Name:";
            // 
            // ManageDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 554);
            this.Controls.Add(this.pnlDoctor);
            this.Controls.Add(this.pnlMain);
            this.Name = "ManageDoctor";
            this.Text = "Manage Doctor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageDoctor_FormClosed);
            this.Load += new System.EventHandler(this.ManageDoctor_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvDoctor)).EndInit();
            this.pnlDoctor.ResumeLayout(false);
            this.pnlDoctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMain;
        private MetroFramework.Controls.MetroComboBox cmbFilter;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroGrid mgvDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn available;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel pnlDoctor;
        private MetroFramework.Controls.MetroButton btnLogoutD;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtDspeciality;
        private MetroFramework.Controls.MetroTextBox txtDavailable;
        private MetroFramework.Controls.MetroTextBox txtDage;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtDphone;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtDsex;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtDaddress;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtDreference;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDid;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnAback;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtDname;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DateTimePicker dtpTime;
    }
}