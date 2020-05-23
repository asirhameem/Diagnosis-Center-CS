namespace HMSProject.Application_Layer
{
    partial class Appointment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.mdtAppoinmentDate = new MetroFramework.Controls.MetroDateTime();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mbtnBack = new MetroFramework.Controls.MetroButton();
            this.mbtnInsert = new MetroFramework.Controls.MetroButton();
            this.mgvDoctorAppointment = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRefer = new System.Windows.Forms.Label();
            this.lblPrefer = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPsex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblPname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvDoctorAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpTime);
            this.panel1.Controls.Add(this.mdtAppoinmentDate);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mbtnBack);
            this.panel1.Controls.Add(this.mbtnInsert);
            this.panel1.Controls.Add(this.mgvDoctorAppointment);
            this.panel1.Controls.Add(this.cmbDepartment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblRefer);
            this.panel1.Controls.Add(this.lblPrefer);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.lblPsex);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblPage);
            this.panel1.Controls.Add(this.lblPname);
            this.panel1.Location = new System.Drawing.Point(17, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 452);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(879, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Time:";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm tt";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(955, 95);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(135, 27);
            this.dtpTime.TabIndex = 24;
            this.dtpTime.Value = new System.DateTime(2020, 5, 7, 23, 44, 22, 0);
            // 
            // mdtAppoinmentDate
            // 
            this.mdtAppoinmentDate.Location = new System.Drawing.Point(643, 92);
            this.mdtAppoinmentDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mdtAppoinmentDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.mdtAppoinmentDate.Name = "mdtAppoinmentDate";
            this.mdtAppoinmentDate.Size = new System.Drawing.Size(200, 30);
            this.mdtAppoinmentDate.TabIndex = 18;
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.txtId.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(65, 90);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(140, 33);
            this.txtId.TabIndex = 23;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID:";
            // 
            // mbtnBack
            // 
            this.mbtnBack.BackColor = System.Drawing.Color.LightBlue;
            this.mbtnBack.Location = new System.Drawing.Point(729, 404);
            this.mbtnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mbtnBack.Name = "mbtnBack";
            this.mbtnBack.Size = new System.Drawing.Size(180, 34);
            this.mbtnBack.TabIndex = 21;
            this.mbtnBack.Text = "Back";
            this.mbtnBack.UseCustomBackColor = true;
            this.mbtnBack.UseCustomForeColor = true;
            this.mbtnBack.UseSelectable = true;
            this.mbtnBack.Click += new System.EventHandler(this.mbtnBack_Click);
            // 
            // mbtnInsert
            // 
            this.mbtnInsert.BackColor = System.Drawing.Color.LightBlue;
            this.mbtnInsert.Location = new System.Drawing.Point(943, 404);
            this.mbtnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mbtnInsert.Name = "mbtnInsert";
            this.mbtnInsert.Size = new System.Drawing.Size(172, 34);
            this.mbtnInsert.TabIndex = 20;
            this.mbtnInsert.Text = "Insert";
            this.mbtnInsert.UseCustomBackColor = true;
            this.mbtnInsert.UseCustomForeColor = true;
            this.mbtnInsert.UseSelectable = true;
            this.mbtnInsert.Click += new System.EventHandler(this.mbtnInsert_Click);
            // 
            // mgvDoctorAppointment
            // 
            this.mgvDoctorAppointment.AllowUserToAddRows = false;
            this.mgvDoctorAppointment.AllowUserToDeleteRows = false;
            this.mgvDoctorAppointment.AllowUserToResizeRows = false;
            this.mgvDoctorAppointment.BackgroundColor = System.Drawing.Color.LightBlue;
            this.mgvDoctorAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvDoctorAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.mgvDoctorAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvDoctorAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgvDoctorAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvDoctorAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.specialist,
            this.phone,
            this.available,
            this.time});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvDoctorAppointment.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgvDoctorAppointment.EnableHeadersVisualStyles = false;
            this.mgvDoctorAppointment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvDoctorAppointment.GridColor = System.Drawing.Color.LightBlue;
            this.mgvDoctorAppointment.Location = new System.Drawing.Point(24, 142);
            this.mgvDoctorAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mgvDoctorAppointment.Name = "mgvDoctorAppointment";
            this.mgvDoctorAppointment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvDoctorAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgvDoctorAppointment.RowHeadersWidth = 51;
            this.mgvDoctorAppointment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvDoctorAppointment.RowTemplate.Height = 24;
            this.mgvDoctorAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvDoctorAppointment.Size = new System.Drawing.Size(1091, 238);
            this.mgvDoctorAppointment.TabIndex = 19;
            this.mgvDoctorAppointment.UseCustomBackColor = true;
            this.mgvDoctorAppointment.UseCustomForeColor = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
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
            // specialist
            // 
            this.specialist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.specialist.DataPropertyName = "speciality";
            this.specialist.HeaderText = "Speciality";
            this.specialist.MinimumWidth = 6;
            this.specialist.Name = "specialist";
            this.specialist.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone Number";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
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
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Arthopedic",
            "Eye",
            "Dental",
            "ENT",
            "Urology",
            "Skin",
            "Gynocologist",
            "Surgery"});
            this.cmbDepartment.Location = new System.Drawing.Point(364, 90);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(191, 33);
            this.cmbDepartment.TabIndex = 17;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Department:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(120, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 34);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "label2";
            // 
            // lblRefer
            // 
            this.lblRefer.AutoSize = true;
            this.lblRefer.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefer.Location = new System.Drawing.Point(975, 14);
            this.lblRefer.Name = "lblRefer";
            this.lblRefer.Size = new System.Drawing.Size(85, 34);
            this.lblRefer.TabIndex = 11;
            this.lblRefer.Text = "label2";
            // 
            // lblPrefer
            // 
            this.lblPrefer.AutoSize = true;
            this.lblPrefer.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrefer.Location = new System.Drawing.Point(840, 14);
            this.lblPrefer.Name = "lblPrefer";
            this.lblPrefer.Size = new System.Drawing.Size(129, 34);
            this.lblPrefer.TabIndex = 10;
            this.lblPrefer.Text = "Reference:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(636, 14);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(85, 34);
            this.lblSex.TabIndex = 9;
            this.lblSex.Text = "label2";
            // 
            // lblPsex
            // 
            this.lblPsex.AutoSize = true;
            this.lblPsex.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsex.Location = new System.Drawing.Point(573, 14);
            this.lblPsex.Name = "lblPsex";
            this.lblPsex.Size = new System.Drawing.Size(65, 34);
            this.lblPsex.TabIndex = 8;
            this.lblPsex.Text = "Sex:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(359, 14);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(85, 34);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "label2";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(299, 14);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(65, 34);
            this.lblPage.TabIndex = 5;
            this.lblPage.Text = "Age:";
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPname.Location = new System.Drawing.Point(21, 14);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(93, 34);
            this.lblPname.TabIndex = 4;
            this.lblPname.Text = "Name:";
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 553);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Appointment";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Appointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Appointment_FormClosed);
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvDoctorAppointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRefer;
        private System.Windows.Forms.Label lblPrefer;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblPsex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroGrid mgvDoctorAppointment;
        private MetroFramework.Controls.MetroDateTime mdtAppoinmentDate;
        private MetroFramework.Controls.MetroButton mbtnInsert;
        private MetroFramework.Controls.MetroButton mbtnBack;
        private MetroFramework.Controls.MetroTextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialist;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn available;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}