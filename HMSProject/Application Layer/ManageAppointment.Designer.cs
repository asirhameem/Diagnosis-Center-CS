namespace HMSProject.Application_Layer
{
    partial class ManageAppointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new MetroFramework.Controls.MetroPanel();
            this.txtDoctorName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.dtpDate = new MetroFramework.Controls.MetroDateTime();
            this.cmbFilter = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.mgvAppointment = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlDetails = new MetroFramework.Controls.MetroPanel();
            this.txtAppDoctor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.btnAppLogout = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.dtpAppTime = new System.Windows.Forms.DateTimePicker();
            this.txtAppName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtAppSex = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtAppAge = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtAppReference = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtpAppDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnAppBack = new MetroFramework.Controls.MetroButton();
            this.btnAppUpdate = new MetroFramework.Controls.MetroButton();
            this.txtAppId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvAppointment)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.txtDoctorName);
            this.pnlMain.Controls.Add(this.metroLabel13);
            this.pnlMain.Controls.Add(this.dtpDate);
            this.pnlMain.Controls.Add(this.cmbFilter);
            this.pnlMain.Controls.Add(this.metroLabel5);
            this.pnlMain.Controls.Add(this.metroLabel4);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.txtId);
            this.pnlMain.Controls.Add(this.metroLabel2);
            this.pnlMain.Controls.Add(this.btnLogout);
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.btnEdit);
            this.pnlMain.Controls.Add(this.mgvAppointment);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.metroLabel1);
            this.pnlMain.HorizontalScrollbarBarColor = true;
            this.pnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMain.HorizontalScrollbarSize = 10;
            this.pnlMain.Location = new System.Drawing.Point(20, 87);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1044, 462);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.VerticalScrollbarBarColor = true;
            this.pnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMain.VerticalScrollbarSize = 10;
            // 
            // txtDoctorName
            // 
            // 
            // 
            // 
            this.txtDoctorName.CustomButton.Image = null;
            this.txtDoctorName.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.txtDoctorName.CustomButton.Name = "";
            this.txtDoctorName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDoctorName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDoctorName.CustomButton.TabIndex = 1;
            this.txtDoctorName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDoctorName.CustomButton.UseSelectable = true;
            this.txtDoctorName.CustomButton.Visible = false;
            this.txtDoctorName.Lines = new string[0];
            this.txtDoctorName.Location = new System.Drawing.Point(140, 306);
            this.txtDoctorName.MaxLength = 32767;
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.PasswordChar = '\0';
            this.txtDoctorName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDoctorName.SelectedText = "";
            this.txtDoctorName.SelectionLength = 0;
            this.txtDoctorName.SelectionStart = 0;
            this.txtDoctorName.ShortcutsEnabled = true;
            this.txtDoctorName.Size = new System.Drawing.Size(199, 30);
            this.txtDoctorName.TabIndex = 21;
            this.txtDoctorName.UseSelectable = true;
            this.txtDoctorName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDoctorName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(16, 316);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(96, 20);
            this.metroLabel13.TabIndex = 20;
            this.metroLabel13.Text = "Doctor Name:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(140, 181);
            this.dtpDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(199, 30);
            this.dtpDate.TabIndex = 19;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.ItemHeight = 24;
            this.cmbFilter.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Child",
            "Youth",
            "Adult",
            "Senior"});
            this.cmbFilter.Location = new System.Drawing.Point(140, 247);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(199, 30);
            this.cmbFilter.TabIndex = 18;
            this.cmbFilter.UseSelectable = true;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(51, 247);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 20);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Filter By:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(71, 181);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 20);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Date:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(395, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 32);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(562, 408);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 32);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.txtId.Location = new System.Drawing.Point(140, 50);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(199, 30);
            this.txtId.TabIndex = 10;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(89, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(23, 20);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Id:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(896, 408);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 32);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(76, 408);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 32);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(729, 408);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // mgvAppointment
            // 
            this.mgvAppointment.AllowUserToResizeRows = false;
            this.mgvAppointment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.age,
            this.sex,
            this.reference,
            this.date,
            this.doctor,
            this.time});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvAppointment.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgvAppointment.EnableHeadersVisualStyles = false;
            this.mgvAppointment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvAppointment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvAppointment.Location = new System.Drawing.Point(362, 18);
            this.mgvAppointment.Name = "mgvAppointment";
            this.mgvAppointment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgvAppointment.RowHeadersWidth = 51;
            this.mgvAppointment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvAppointment.RowTemplate.Height = 24;
            this.mgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvAppointment.Size = new System.Drawing.Size(677, 356);
            this.mgvAppointment.TabIndex = 5;
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
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // doctor
            // 
            this.doctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doctor.DataPropertyName = "doctor";
            this.doctor.HeaderText = "Doctor";
            this.doctor.MinimumWidth = 6;
            this.doctor.Name = "doctor";
            this.doctor.ReadOnly = true;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Time";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(234, 408);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 32);
            this.btnSearch.TabIndex = 4;
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
            this.txtName.Location = new System.Drawing.Point(140, 115);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(199, 30);
            this.txtName.TabIndex = 3;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 125);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Name:";
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.txtAppDoctor);
            this.pnlDetails.Controls.Add(this.metroLabel12);
            this.pnlDetails.Controls.Add(this.btnAppLogout);
            this.pnlDetails.Controls.Add(this.metroLabel11);
            this.pnlDetails.Controls.Add(this.dtpAppTime);
            this.pnlDetails.Controls.Add(this.txtAppName);
            this.pnlDetails.Controls.Add(this.metroLabel10);
            this.pnlDetails.Controls.Add(this.txtAppSex);
            this.pnlDetails.Controls.Add(this.metroLabel9);
            this.pnlDetails.Controls.Add(this.txtAppAge);
            this.pnlDetails.Controls.Add(this.metroLabel8);
            this.pnlDetails.Controls.Add(this.txtAppReference);
            this.pnlDetails.Controls.Add(this.metroLabel3);
            this.pnlDetails.Controls.Add(this.dtpAppDate);
            this.pnlDetails.Controls.Add(this.metroLabel6);
            this.pnlDetails.Controls.Add(this.btnAppBack);
            this.pnlDetails.Controls.Add(this.btnAppUpdate);
            this.pnlDetails.Controls.Add(this.txtAppId);
            this.pnlDetails.Controls.Add(this.metroLabel7);
            this.pnlDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDetails.HorizontalScrollbarBarColor = true;
            this.pnlDetails.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDetails.HorizontalScrollbarSize = 10;
            this.pnlDetails.Location = new System.Drawing.Point(20, 87);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(1044, 462);
            this.pnlDetails.TabIndex = 20;
            this.pnlDetails.VerticalScrollbarBarColor = true;
            this.pnlDetails.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDetails.VerticalScrollbarSize = 10;
            this.pnlDetails.Visible = false;
            // 
            // txtAppDoctor
            // 
            // 
            // 
            // 
            this.txtAppDoctor.CustomButton.Image = null;
            this.txtAppDoctor.CustomButton.Location = new System.Drawing.Point(230, 2);
            this.txtAppDoctor.CustomButton.Name = "";
            this.txtAppDoctor.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAppDoctor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAppDoctor.CustomButton.TabIndex = 1;
            this.txtAppDoctor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAppDoctor.CustomButton.UseSelectable = true;
            this.txtAppDoctor.CustomButton.Visible = false;
            this.txtAppDoctor.Lines = new string[0];
            this.txtAppDoctor.Location = new System.Drawing.Point(693, 31);
            this.txtAppDoctor.MaxLength = 32767;
            this.txtAppDoctor.Name = "txtAppDoctor";
            this.txtAppDoctor.PasswordChar = '\0';
            this.txtAppDoctor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAppDoctor.SelectedText = "";
            this.txtAppDoctor.SelectionLength = 0;
            this.txtAppDoctor.SelectionStart = 0;
            this.txtAppDoctor.ShortcutsEnabled = true;
            this.txtAppDoctor.Size = new System.Drawing.Size(258, 30);
            this.txtAppDoctor.TabIndex = 40;
            this.txtAppDoctor.UseSelectable = true;
            this.txtAppDoctor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAppDoctor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(569, 41);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(96, 20);
            this.metroLabel12.TabIndex = 39;
            this.metroLabel12.Text = "Doctor Name:";
            // 
            // btnAppLogout
            // 
            this.btnAppLogout.Location = new System.Drawing.Point(848, 391);
            this.btnAppLogout.Name = "btnAppLogout";
            this.btnAppLogout.Size = new System.Drawing.Size(121, 32);
            this.btnAppLogout.TabIndex = 38;
            this.btnAppLogout.Text = "Logout";
            this.btnAppLogout.UseSelectable = true;
            this.btnAppLogout.Click += new System.EventHandler(this.btnAppLogout_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(624, 174);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(40, 20);
            this.metroLabel11.TabIndex = 37;
            this.metroLabel11.Text = "Time";
            // 
            // dtpAppTime
            // 
            this.dtpAppTime.CustomFormat = "hh:mm    tt";
            this.dtpAppTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppTime.Location = new System.Drawing.Point(693, 172);
            this.dtpAppTime.Name = "dtpAppTime";
            this.dtpAppTime.ShowUpDown = true;
            this.dtpAppTime.Size = new System.Drawing.Size(259, 30);
            this.dtpAppTime.TabIndex = 36;
            // 
            // txtAppName
            // 
            // 
            // 
            // 
            this.txtAppName.CustomButton.Image = null;
            this.txtAppName.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txtAppName.CustomButton.Name = "";
            this.txtAppName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAppName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAppName.CustomButton.TabIndex = 1;
            this.txtAppName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAppName.CustomButton.UseSelectable = true;
            this.txtAppName.CustomButton.Visible = false;
            this.txtAppName.Lines = new string[0];
            this.txtAppName.Location = new System.Drawing.Point(170, 106);
            this.txtAppName.MaxLength = 32767;
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.PasswordChar = '\0';
            this.txtAppName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAppName.SelectedText = "";
            this.txtAppName.SelectionLength = 0;
            this.txtAppName.SelectionStart = 0;
            this.txtAppName.ShortcutsEnabled = true;
            this.txtAppName.Size = new System.Drawing.Size(242, 30);
            this.txtAppName.TabIndex = 35;
            this.txtAppName.UseSelectable = true;
            this.txtAppName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAppName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(63, 116);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(50, 20);
            this.metroLabel10.TabIndex = 34;
            this.metroLabel10.Text = "Name:";
            // 
            // txtAppSex
            // 
            // 
            // 
            // 
            this.txtAppSex.CustomButton.Image = null;
            this.txtAppSex.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txtAppSex.CustomButton.Name = "";
            this.txtAppSex.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAppSex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAppSex.CustomButton.TabIndex = 1;
            this.txtAppSex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAppSex.CustomButton.UseSelectable = true;
            this.txtAppSex.CustomButton.Visible = false;
            this.txtAppSex.Lines = new string[0];
            this.txtAppSex.Location = new System.Drawing.Point(170, 244);
            this.txtAppSex.MaxLength = 32767;
            this.txtAppSex.Name = "txtAppSex";
            this.txtAppSex.PasswordChar = '\0';
            this.txtAppSex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAppSex.SelectedText = "";
            this.txtAppSex.SelectionLength = 0;
            this.txtAppSex.SelectionStart = 0;
            this.txtAppSex.ShortcutsEnabled = true;
            this.txtAppSex.Size = new System.Drawing.Size(242, 30);
            this.txtAppSex.TabIndex = 33;
            this.txtAppSex.UseSelectable = true;
            this.txtAppSex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAppSex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(80, 254);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(33, 20);
            this.metroLabel9.TabIndex = 32;
            this.metroLabel9.Text = "Sex:";
            // 
            // txtAppAge
            // 
            // 
            // 
            // 
            this.txtAppAge.CustomButton.Image = null;
            this.txtAppAge.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txtAppAge.CustomButton.Name = "";
            this.txtAppAge.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAppAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAppAge.CustomButton.TabIndex = 1;
            this.txtAppAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAppAge.CustomButton.UseSelectable = true;
            this.txtAppAge.CustomButton.Visible = false;
            this.txtAppAge.Lines = new string[0];
            this.txtAppAge.Location = new System.Drawing.Point(170, 172);
            this.txtAppAge.MaxLength = 32767;
            this.txtAppAge.Name = "txtAppAge";
            this.txtAppAge.PasswordChar = '\0';
            this.txtAppAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAppAge.SelectedText = "";
            this.txtAppAge.SelectionLength = 0;
            this.txtAppAge.SelectionStart = 0;
            this.txtAppAge.ShortcutsEnabled = true;
            this.txtAppAge.Size = new System.Drawing.Size(242, 30);
            this.txtAppAge.TabIndex = 31;
            this.txtAppAge.UseSelectable = true;
            this.txtAppAge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAppAge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(76, 182);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(37, 20);
            this.metroLabel8.TabIndex = 30;
            this.metroLabel8.Text = "Age:";
            // 
            // txtAppReference
            // 
            // 
            // 
            // 
            this.txtAppReference.CustomButton.Image = null;
            this.txtAppReference.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txtAppReference.CustomButton.Name = "";
            this.txtAppReference.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAppReference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAppReference.CustomButton.TabIndex = 1;
            this.txtAppReference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAppReference.CustomButton.UseSelectable = true;
            this.txtAppReference.CustomButton.Visible = false;
            this.txtAppReference.Lines = new string[0];
            this.txtAppReference.Location = new System.Drawing.Point(170, 309);
            this.txtAppReference.MaxLength = 32767;
            this.txtAppReference.Name = "txtAppReference";
            this.txtAppReference.PasswordChar = '\0';
            this.txtAppReference.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAppReference.SelectedText = "";
            this.txtAppReference.SelectionLength = 0;
            this.txtAppReference.SelectionStart = 0;
            this.txtAppReference.ShortcutsEnabled = true;
            this.txtAppReference.Size = new System.Drawing.Size(242, 30);
            this.txtAppReference.TabIndex = 29;
            this.txtAppReference.UseSelectable = true;
            this.txtAppReference.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAppReference.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(53, 319);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 20);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Reference:";
            // 
            // dtpAppDate
            // 
            this.dtpAppDate.Location = new System.Drawing.Point(693, 97);
            this.dtpAppDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpAppDate.Name = "dtpAppDate";
            this.dtpAppDate.Size = new System.Drawing.Size(258, 30);
            this.dtpAppDate.TabIndex = 27;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(624, 97);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 20);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "Date:";
            // 
            // btnAppBack
            // 
            this.btnAppBack.Location = new System.Drawing.Point(519, 391);
            this.btnAppBack.Name = "btnAppBack";
            this.btnAppBack.Size = new System.Drawing.Size(115, 32);
            this.btnAppBack.TabIndex = 23;
            this.btnAppBack.Text = "Back";
            this.btnAppBack.UseSelectable = true;
            this.btnAppBack.Click += new System.EventHandler(this.btnAppBack_Click);
            // 
            // btnAppUpdate
            // 
            this.btnAppUpdate.Location = new System.Drawing.Point(677, 391);
            this.btnAppUpdate.Name = "btnAppUpdate";
            this.btnAppUpdate.Size = new System.Drawing.Size(121, 32);
            this.btnAppUpdate.TabIndex = 22;
            this.btnAppUpdate.Text = "Update";
            this.btnAppUpdate.UseSelectable = true;
            this.btnAppUpdate.Click += new System.EventHandler(this.btnAppUpdate_Click);
            // 
            // txtAppId
            // 
            // 
            // 
            // 
            this.txtAppId.CustomButton.Image = null;
            this.txtAppId.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txtAppId.CustomButton.Name = "";
            this.txtAppId.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAppId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAppId.CustomButton.TabIndex = 1;
            this.txtAppId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAppId.CustomButton.UseSelectable = true;
            this.txtAppId.CustomButton.Visible = false;
            this.txtAppId.Lines = new string[0];
            this.txtAppId.Location = new System.Drawing.Point(170, 31);
            this.txtAppId.MaxLength = 32767;
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.PasswordChar = '\0';
            this.txtAppId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAppId.SelectedText = "";
            this.txtAppId.SelectionLength = 0;
            this.txtAppId.SelectionStart = 0;
            this.txtAppId.ShortcutsEnabled = true;
            this.txtAppId.Size = new System.Drawing.Size(242, 30);
            this.txtAppId.TabIndex = 21;
            this.txtAppId.UseSelectable = true;
            this.txtAppId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAppId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(92, 41);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(23, 20);
            this.metroLabel7.TabIndex = 20;
            this.metroLabel7.Text = "Id:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAppointmentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addAppointmentToolStripMenuItem
            // 
            this.addAppointmentToolStripMenuItem.Name = "addAppointmentToolStripMenuItem";
            this.addAppointmentToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.addAppointmentToolStripMenuItem.Text = "Add Appointment";
            this.addAppointmentToolStripMenuItem.Click += new System.EventHandler(this.addAppointmentToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ManageAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 578);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageAppointment";
            this.Text = "Manage Appointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageAppointment_FormClosed);
            this.Load += new System.EventHandler(this.ManageAppointment_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvAppointment)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMain;
        private MetroFramework.Controls.MetroDateTime dtpDate;
        private MetroFramework.Controls.MetroComboBox cmbFilter;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroGrid mgvAppointment;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private MetroFramework.Controls.MetroPanel pnlDetails;
        private MetroFramework.Controls.MetroDateTime dtpAppDate;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnAppBack;
        private MetroFramework.Controls.MetroButton btnAppUpdate;
        private MetroFramework.Controls.MetroTextBox txtAppId;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnAppLogout;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DateTimePicker dtpAppTime;
        private MetroFramework.Controls.MetroTextBox txtAppName;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtAppSex;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtAppAge;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtAppReference;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtAppDoctor;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtDoctorName;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}