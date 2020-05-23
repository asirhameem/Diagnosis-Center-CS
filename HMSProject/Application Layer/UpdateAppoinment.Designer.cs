namespace HMSProject.Application_Layer
{
    partial class UpdateAppoinment
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
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.txtDoctor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtAppointment = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.mgvUpdateAppoinment = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvUpdateAppoinment)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnClear);
            this.metroPanel1.Controls.Add(this.txtDoctor);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtAppointment);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtName);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.btnSearch);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 17);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(360, 181);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(83, 141);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 27);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDoctor
            // 
            // 
            // 
            // 
            this.txtDoctor.CustomButton.Image = null;
            this.txtDoctor.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtDoctor.CustomButton.Name = "";
            this.txtDoctor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDoctor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDoctor.CustomButton.TabIndex = 1;
            this.txtDoctor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDoctor.CustomButton.UseSelectable = true;
            this.txtDoctor.CustomButton.Visible = false;
            this.txtDoctor.Lines = new string[0];
            this.txtDoctor.Location = new System.Drawing.Point(185, 97);
            this.txtDoctor.MaxLength = 32767;
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.PasswordChar = '\0';
            this.txtDoctor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDoctor.SelectedText = "";
            this.txtDoctor.SelectionLength = 0;
            this.txtDoctor.SelectionStart = 0;
            this.txtDoctor.ShortcutsEnabled = true;
            this.txtDoctor.Size = new System.Drawing.Size(165, 23);
            this.txtDoctor.TabIndex = 8;
            this.txtDoctor.UseSelectable = true;
            this.txtDoctor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDoctor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(63, 97);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 20);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Doctor:";
            // 
            // txtAppointment
            // 
            // 
            // 
            // 
            this.txtAppointment.CustomButton.Image = null;
            this.txtAppointment.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtAppointment.CustomButton.Name = "";
            this.txtAppointment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAppointment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAppointment.CustomButton.TabIndex = 1;
            this.txtAppointment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAppointment.CustomButton.UseSelectable = true;
            this.txtAppointment.CustomButton.Visible = false;
            this.txtAppointment.Lines = new string[0];
            this.txtAppointment.Location = new System.Drawing.Point(185, 58);
            this.txtAppointment.MaxLength = 32767;
            this.txtAppointment.Name = "txtAppointment";
            this.txtAppointment.PasswordChar = '\0';
            this.txtAppointment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAppointment.SelectedText = "";
            this.txtAppointment.SelectionLength = 0;
            this.txtAppointment.SelectionStart = 0;
            this.txtAppointment.ShortcutsEnabled = true;
            this.txtAppointment.Size = new System.Drawing.Size(165, 23);
            this.txtAppointment.TabIndex = 6;
            this.txtAppointment.UseSelectable = true;
            this.txtAppointment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAppointment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(5, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(145, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Appoinment Number:";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(185, 15);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(165, 23);
            this.txtName.TabIndex = 4;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(100, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(236, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.btnBack);
            this.metroPanel2.Controls.Add(this.btnDelete);
            this.metroPanel2.Controls.Add(this.btnUpdate);
            this.metroPanel2.Controls.Add(this.mgvUpdateAppoinment);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(378, 14);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(756, 433);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(284, 395);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 27);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(441, 395);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 27);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(589, 395);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 27);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mgvUpdateAppoinment
            // 
            this.mgvUpdateAppoinment.AllowUserToResizeRows = false;
            this.mgvUpdateAppoinment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvUpdateAppoinment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvUpdateAppoinment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvUpdateAppoinment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvUpdateAppoinment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvUpdateAppoinment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvUpdateAppoinment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.age,
            this.sex,
            this.reference,
            this.doctor,
            this.date,
            this.time});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvUpdateAppoinment.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgvUpdateAppoinment.EnableHeadersVisualStyles = false;
            this.mgvUpdateAppoinment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvUpdateAppoinment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvUpdateAppoinment.Location = new System.Drawing.Point(17, 18);
            this.mgvUpdateAppoinment.Name = "mgvUpdateAppoinment";
            this.mgvUpdateAppoinment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvUpdateAppoinment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgvUpdateAppoinment.RowHeadersWidth = 51;
            this.mgvUpdateAppoinment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvUpdateAppoinment.RowTemplate.Height = 24;
            this.mgvUpdateAppoinment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvUpdateAppoinment.Size = new System.Drawing.Size(723, 361);
            this.mgvUpdateAppoinment.TabIndex = 2;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
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
            // reference
            // 
            this.reference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reference.DataPropertyName = "reference";
            this.reference.HeaderText = "Reference";
            this.reference.MinimumWidth = 6;
            this.reference.Name = "reference";
            // 
            // doctor
            // 
            this.doctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doctor.DataPropertyName = "doctor";
            this.doctor.HeaderText = "Doctor";
            this.doctor.MinimumWidth = 6;
            this.doctor.Name = "doctor";
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
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroPanel2);
            this.metroPanel3.Controls.Add(this.metroPanel1);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(20, 60);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1160, 463);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // UpdateAppoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 543);
            this.Controls.Add(this.metroPanel3);
            this.Name = "UpdateAppoinment";
            this.Text = "Update Appoinments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateAppoinment_FormClosed);
            this.Load += new System.EventHandler(this.UpdateAppoinment_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgvUpdateAppoinment)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtAppointment;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid mgvUpdateAppoinment;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTextBox txtDoctor;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}