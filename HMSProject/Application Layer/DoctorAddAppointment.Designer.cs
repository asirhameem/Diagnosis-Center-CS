namespace HMSProject.Application_Layer
{
    partial class DoctorAddAppointment
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new MetroFramework.Controls.MetroDateTime();
            this.cmbSex = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.mgvDoctor = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnInsert = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.txtReference = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtAge = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAdminBack = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnAdminBack);
            this.metroPanel1.Controls.Add(this.dtpTime);
            this.metroPanel1.Controls.Add(this.dtpDate);
            this.metroPanel1.Controls.Add(this.cmbSex);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.mgvDoctor);
            this.metroPanel1.Controls.Add(this.btnBack);
            this.metroPanel1.Controls.Add(this.btnInsert);
            this.metroPanel1.Controls.Add(this.btnClear);
            this.metroPanel1.Controls.Add(this.txtReference);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txtAge);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtName);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.btnLogout);
            this.metroPanel1.Controls.Add(this.txtId);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1085, 447);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm tt";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(124, 326);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(200, 28);
            this.dtpTime.TabIndex = 23;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(124, 273);
            this.dtpDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 30);
            this.dtpDate.TabIndex = 22;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.ItemHeight = 24;
            this.cmbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbSex.Location = new System.Drawing.Point(124, 177);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(196, 30);
            this.cmbSex.TabIndex = 21;
            this.cmbSex.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(46, 326);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(43, 20);
            this.metroLabel7.TabIndex = 19;
            this.metroLabel7.Text = "Time:";
            // 
            // mgvDoctor
            // 
            this.mgvDoctor.AllowUserToResizeRows = false;
            this.mgvDoctor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvDoctor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvDoctor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvDoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.sex,
            this.speciality,
            this.available,
            this.time});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvDoctor.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgvDoctor.EnableHeadersVisualStyles = false;
            this.mgvDoctor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvDoctor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvDoctor.Location = new System.Drawing.Point(367, 32);
            this.mgvDoctor.Name = "mgvDoctor";
            this.mgvDoctor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvDoctor.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgvDoctor.RowHeadersWidth = 51;
            this.mgvDoctor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvDoctor.RowTemplate.Height = 24;
            this.mgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvDoctor.Size = new System.Drawing.Size(697, 358);
            this.mgvDoctor.TabIndex = 18;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
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
            this.name.ReadOnly = true;
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
            // speciality
            // 
            this.speciality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.speciality.DataPropertyName = "speciality";
            this.speciality.HeaderText = "Speciality";
            this.speciality.MinimumWidth = 6;
            this.speciality.Name = "speciality";
            this.speciality.ReadOnly = true;
            // 
            // available
            // 
            this.available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.available.DataPropertyName = "available";
            this.available.HeaderText = "Available";
            this.available.MinimumWidth = 6;
            this.available.Name = "available";
            this.available.ReadOnly = true;
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(780, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 34);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(225, 404);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(99, 34);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseSelectable = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(71, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 34);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtReference
            // 
            // 
            // 
            // 
            this.txtReference.CustomButton.Image = null;
            this.txtReference.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtReference.CustomButton.Name = "";
            this.txtReference.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReference.CustomButton.TabIndex = 1;
            this.txtReference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReference.CustomButton.UseSelectable = true;
            this.txtReference.CustomButton.Visible = false;
            this.txtReference.Lines = new string[0];
            this.txtReference.Location = new System.Drawing.Point(124, 224);
            this.txtReference.MaxLength = 32767;
            this.txtReference.Name = "txtReference";
            this.txtReference.PasswordChar = '\0';
            this.txtReference.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReference.SelectedText = "";
            this.txtReference.SelectionLength = 0;
            this.txtReference.SelectionStart = 0;
            this.txtReference.ShortcutsEnabled = true;
            this.txtReference.Size = new System.Drawing.Size(196, 23);
            this.txtReference.TabIndex = 14;
            this.txtReference.UseSelectable = true;
            this.txtReference.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReference.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(21, 224);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 20);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Reference:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(56, 177);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(33, 20);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Sex:";
            // 
            // txtAge
            // 
            // 
            // 
            // 
            this.txtAge.CustomButton.Image = null;
            this.txtAge.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtAge.CustomButton.Name = "";
            this.txtAge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAge.CustomButton.TabIndex = 1;
            this.txtAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAge.CustomButton.UseSelectable = true;
            this.txtAge.CustomButton.Visible = false;
            this.txtAge.Lines = new string[0];
            this.txtAge.Location = new System.Drawing.Point(124, 132);
            this.txtAge.MaxLength = 32767;
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAge.SelectedText = "";
            this.txtAge.SelectionLength = 0;
            this.txtAge.SelectionStart = 0;
            this.txtAge.ShortcutsEnabled = true;
            this.txtAge.Size = new System.Drawing.Size(196, 23);
            this.txtAge.TabIndex = 10;
            this.txtAge.UseSelectable = true;
            this.txtAge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(52, 132);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 20);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Age:";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(124, 86);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(196, 23);
            this.txtName.TabIndex = 8;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(39, 89);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 20);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Name:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(48, 273);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Date:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(955, 404);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 34);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(124, 32);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(196, 23);
            this.txtId.TabIndex = 3;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Patient Id:";
            // 
            // btnAdminBack
            // 
            this.btnAdminBack.Location = new System.Drawing.Point(780, 404);
            this.btnAdminBack.Name = "btnAdminBack";
            this.btnAdminBack.Size = new System.Drawing.Size(110, 34);
            this.btnAdminBack.TabIndex = 24;
            this.btnAdminBack.Text = "Back";
            this.btnAdminBack.UseSelectable = true;
            this.btnAdminBack.Visible = false;
            this.btnAdminBack.Click += new System.EventHandler(this.btnAdminBack_Click);
            // 
            // DoctorAddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 527);
            this.Controls.Add(this.metroPanel1);
            this.Name = "DoctorAddAppointment";
            this.Text = "Add  Appointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorAddAppointment_FormClosed);
            this.Load += new System.EventHandler(this.DoctorAddAppointment_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvDoctor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private MetroFramework.Controls.MetroDateTime dtpDate;
        private MetroFramework.Controls.MetroComboBox cmbSex;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid mgvDoctor;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnInsert;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroTextBox txtReference;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtAge;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn available;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private MetroFramework.Controls.MetroButton btnAdminBack;
    }
}