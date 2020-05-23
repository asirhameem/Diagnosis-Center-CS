namespace HMSProject.Application_Layer
{
    partial class DoctorAppointment
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtDoctorName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbFilter = new MetroFramework.Controls.MetroComboBox();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mgvAppointment = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpDate = new MetroFramework.Controls.MetroDateTime();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvAppointment)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dtpDate);
            this.metroPanel1.Controls.Add(this.txtDoctorName);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.btnBack);
            this.metroPanel1.Controls.Add(this.btnClear);
            this.metroPanel1.Controls.Add(this.btnSearch);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.cmbFilter);
            this.metroPanel1.Controls.Add(this.btnLogout);
            this.metroPanel1.Controls.Add(this.txtName);
            this.metroPanel1.Controls.Add(this.txtId);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.mgvAppointment);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(27, 102);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1117, 459);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // txtDoctorName
            // 
            // 
            // 
            // 
            this.txtDoctorName.CustomButton.Image = null;
            this.txtDoctorName.CustomButton.Location = new System.Drawing.Point(155, 2);
            this.txtDoctorName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorName.CustomButton.Name = "";
            this.txtDoctorName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDoctorName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDoctorName.CustomButton.TabIndex = 1;
            this.txtDoctorName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDoctorName.CustomButton.UseSelectable = true;
            this.txtDoctorName.CustomButton.Visible = false;
            this.txtDoctorName.Lines = new string[0];
            this.txtDoctorName.Location = new System.Drawing.Point(116, 189);
            this.txtDoctorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorName.MaxLength = 32767;
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.PasswordChar = '\0';
            this.txtDoctorName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDoctorName.SelectedText = "";
            this.txtDoctorName.SelectionLength = 0;
            this.txtDoctorName.SelectionStart = 0;
            this.txtDoctorName.ShortcutsEnabled = true;
            this.txtDoctorName.Size = new System.Drawing.Size(181, 28);
            this.txtDoctorName.TabIndex = 17;
            this.txtDoctorName.UseSelectable = true;
            this.txtDoctorName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDoctorName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 194);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 20);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Doctor";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(832, 421);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 28);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(24, 374);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 36);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(172, 374);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 36);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 253);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 20);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Date:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 312);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 20);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Filter By:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(45, 20);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(219, 31);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Manage Appoinments";
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
            this.cmbFilter.Location = new System.Drawing.Point(116, 312);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(180, 30);
            this.cmbFilter.TabIndex = 8;
            this.cmbFilter.UseSelectable = true;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(988, 421);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 28);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(155, 2);
            this.txtName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(116, 133);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(181, 28);
            this.txtName.TabIndex = 6;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(155, 2);
            this.txtId.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(116, 75);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(181, 28);
            this.txtId.TabIndex = 5;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 138);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Name:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 80);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(23, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Id:";
            // 
            // mgvAppointment
            // 
            this.mgvAppointment.AllowUserToResizeRows = false;
            this.mgvAppointment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.age,
            this.sex,
            this.date,
            this.time});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvAppointment.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgvAppointment.EnableHeadersVisualStyles = false;
            this.mgvAppointment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvAppointment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvAppointment.Location = new System.Drawing.Point(340, 20);
            this.mgvAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.mgvAppointment.Name = "mgvAppointment";
            this.mgvAppointment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgvAppointment.RowHeadersWidth = 51;
            this.mgvAppointment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvAppointment.Size = new System.Drawing.Size(771, 378);
            this.mgvAppointment.TabIndex = 2;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Patient Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            // 
            // sex
            // 
            this.sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "Sex";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Time";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.addAppointmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(27, 74);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            this.appointmentToolStripMenuItem.Click += new System.EventHandler(this.appointmentToolStripMenuItem_Click);
            // 
            // addAppointmentToolStripMenuItem
            // 
            this.addAppointmentToolStripMenuItem.Name = "addAppointmentToolStripMenuItem";
            this.addAppointmentToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.addAppointmentToolStripMenuItem.Text = "Add Appointment";
            this.addAppointmentToolStripMenuItem.Click += new System.EventHandler(this.addAppointmentToolStripMenuItem_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy - MM - dd";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(116, 253);
            this.dtpDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(180, 30);
            this.dtpDate.TabIndex = 18;
            // 
            // DoctorAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 586);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoctorAppointment";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "My Today\'s Appointments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorAppointment_FormClosed);
            this.Load += new System.EventHandler(this.DoctorAppointment_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvAppointment)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbFilter;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid mgvAppointment;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox txtDoctorName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ToolStripMenuItem addAppointmentToolStripMenuItem;
        private MetroFramework.Controls.MetroDateTime dtpDate;
    }
}