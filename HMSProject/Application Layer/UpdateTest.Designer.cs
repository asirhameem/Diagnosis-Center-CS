namespace HMSProject.Application_Layer
{
    partial class UpdateTest
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
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.txtTestNo = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.mgvUpdateTest = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.dtpDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvUpdateTest)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.dtpDate);
            this.metroPanel1.Controls.Add(this.btnClear);
            this.metroPanel1.Controls.Add(this.txtTestNo);
            this.metroPanel1.Controls.Add(this.btnSearch);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtName);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(14, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(360, 315);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(62, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseCustomBackColor = true;
            this.btnClear.UseCustomForeColor = true;
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTestNo
            // 
            // 
            // 
            // 
            this.txtTestNo.CustomButton.Image = null;
            this.txtTestNo.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtTestNo.CustomButton.Name = "";
            this.txtTestNo.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtTestNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTestNo.CustomButton.TabIndex = 1;
            this.txtTestNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTestNo.CustomButton.UseSelectable = true;
            this.txtTestNo.CustomButton.Visible = false;
            this.txtTestNo.Lines = new string[0];
            this.txtTestNo.Location = new System.Drawing.Point(159, 103);
            this.txtTestNo.MaxLength = 32767;
            this.txtTestNo.Name = "txtTestNo";
            this.txtTestNo.PasswordChar = '\0';
            this.txtTestNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTestNo.SelectedText = "";
            this.txtTestNo.SelectionLength = 0;
            this.txtTestNo.SelectionStart = 0;
            this.txtTestNo.ShortcutsEnabled = true;
            this.txtTestNo.Size = new System.Drawing.Size(165, 35);
            this.txtTestNo.TabIndex = 6;
            this.txtTestNo.UseSelectable = true;
            this.txtTestNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTestNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(210, 243);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseCustomForeColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Test Number:";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(159, 30);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(165, 35);
            this.txtName.TabIndex = 4;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Patient Name:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.btnRefresh);
            this.metroPanel2.Controls.Add(this.btnBack);
            this.metroPanel2.Controls.Add(this.btnDelete);
            this.metroPanel2.Controls.Add(this.btnUpdate);
            this.metroPanel2.Controls.Add(this.mgvUpdateTest);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(380, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(754, 448);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(73, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 37);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(436, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 37);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseCustomForeColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(591, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 37);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseCustomBackColor = true;
            this.btnUpdate.UseCustomForeColor = true;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mgvUpdateTest
            // 
            this.mgvUpdateTest.AllowUserToResizeRows = false;
            this.mgvUpdateTest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvUpdateTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvUpdateTest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvUpdateTest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvUpdateTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgvUpdateTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvUpdateTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tests,
            this.name,
            this.age,
            this.sex,
            this.reference,
            this.total,
            this.date});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvUpdateTest.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgvUpdateTest.EnableHeadersVisualStyles = false;
            this.mgvUpdateTest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvUpdateTest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvUpdateTest.Location = new System.Drawing.Point(17, 18);
            this.mgvUpdateTest.Name = "mgvUpdateTest";
            this.mgvUpdateTest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvUpdateTest.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgvUpdateTest.RowHeadersWidth = 51;
            this.mgvUpdateTest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvUpdateTest.RowTemplate.Height = 24;
            this.mgvUpdateTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvUpdateTest.Size = new System.Drawing.Size(723, 361);
            this.mgvUpdateTest.Style = MetroFramework.MetroColorStyle.Teal;
            this.mgvUpdateTest.TabIndex = 2;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // tests
            // 
            this.tests.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tests.DataPropertyName = "tests";
            this.tests.HeaderText = "Tests";
            this.tests.MinimumWidth = 6;
            this.tests.Name = "tests";
            this.tests.ReadOnly = true;
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
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Bill";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRefresh.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefresh.Location = new System.Drawing.Point(258, 392);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(146, 37);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseCustomBackColor = true;
            this.btnRefresh.UseCustomForeColor = true;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(159, 174);
            this.dtpDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(165, 30);
            this.dtpDate.TabIndex = 12;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(82, 174);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 20);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Date:";
            // 
            // UpdateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 516);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "UpdateTest";
            this.Text = "Update Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateTest_FormClosed);
            this.Load += new System.EventHandler(this.UpdateTest_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgvUpdateTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtTestNo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroGrid mgvUpdateTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tests;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime dtpDate;
    }
}