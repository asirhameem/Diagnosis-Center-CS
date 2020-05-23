namespace HMSProject.Application_Layer
{
    partial class Financials
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtSumTotal = new MetroFramework.Controls.MetroTextBox();
            this.mgvResult = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbFilter = new MetroFramework.Controls.MetroComboBox();
            this.dtpDate = new MetroFramework.Controls.MetroDateTime();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtSumTotal);
            this.metroPanel1.Controls.Add(this.mgvResult);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(313, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(696, 386);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(182, 349);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(193, 20);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Total Cash Received  (In Taka):";
            // 
            // txtSumTotal
            // 
            // 
            // 
            // 
            this.txtSumTotal.CustomButton.Image = null;
            this.txtSumTotal.CustomButton.Location = new System.Drawing.Point(195, 2);
            this.txtSumTotal.CustomButton.Name = "";
            this.txtSumTotal.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSumTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSumTotal.CustomButton.TabIndex = 1;
            this.txtSumTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSumTotal.CustomButton.UseSelectable = true;
            this.txtSumTotal.CustomButton.Visible = false;
            this.txtSumTotal.Lines = new string[0];
            this.txtSumTotal.Location = new System.Drawing.Point(448, 347);
            this.txtSumTotal.MaxLength = 32767;
            this.txtSumTotal.Name = "txtSumTotal";
            this.txtSumTotal.PasswordChar = '\0';
            this.txtSumTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSumTotal.SelectedText = "";
            this.txtSumTotal.SelectionLength = 0;
            this.txtSumTotal.SelectionStart = 0;
            this.txtSumTotal.ShortcutsEnabled = true;
            this.txtSumTotal.Size = new System.Drawing.Size(223, 30);
            this.txtSumTotal.TabIndex = 8;
            this.txtSumTotal.UseSelectable = true;
            this.txtSumTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSumTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mgvResult
            // 
            this.mgvResult.AllowUserToResizeRows = false;
            this.mgvResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.date,
            this.total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgvResult.EnableHeadersVisualStyles = false;
            this.mgvResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvResult.Location = new System.Drawing.Point(3, 3);
            this.mgvResult.Name = "mgvResult";
            this.mgvResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgvResult.RowHeadersWidth = 51;
            this.mgvResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvResult.RowTemplate.Height = 24;
            this.mgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvResult.Size = new System.Drawing.Size(690, 338);
            this.mgvResult.TabIndex = 2;
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
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Payment";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 206);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Sales By Date:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Sales By Filters:";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.ItemHeight = 24;
            this.cmbFilter.Items.AddRange(new object[] {
            "Today",
            "This Week",
            "This Month"});
            this.cmbFilter.Location = new System.Drawing.Point(50, 134);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(223, 30);
            this.cmbFilter.TabIndex = 5;
            this.cmbFilter.UseSelectable = true;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(50, 243);
            this.dtpDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(223, 30);
            this.dtpDate.TabIndex = 7;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(131, 334);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 39);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(636, 478);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 38);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(842, 478);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(142, 38);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Financials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 530);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Financials";
            this.Text = "Financials";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Financials_FormClosed);
            this.Load += new System.EventHandler(this.Financials_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid mgvResult;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private MetroFramework.Controls.MetroDateTime dtpDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtSumTotal;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnLogout;
    }
}