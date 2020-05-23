namespace HMSProject.Application_Layer
{
    partial class ManageAdmin
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
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.mgvAdmin = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlEdit = new MetroFramework.Controls.MetroPanel();
            this.txtAage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnAlogout = new MetroFramework.Controls.MetroButton();
            this.txtAphone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtAsex = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtAaddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtAreference = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtAid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnAback = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.txtAname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvAdmin)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.txtPhone);
            this.pnlMain.Controls.Add(this.metroLabel3);
            this.pnlMain.Controls.Add(this.txtId);
            this.pnlMain.Controls.Add(this.metroLabel2);
            this.pnlMain.Controls.Add(this.btnLogout);
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.btnEdit);
            this.pnlMain.Controls.Add(this.mgvAdmin);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.metroLabel1);
            this.pnlMain.HorizontalScrollbarBarColor = true;
            this.pnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMain.HorizontalScrollbarSize = 10;
            this.pnlMain.Location = new System.Drawing.Point(23, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1044, 486);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.VerticalScrollbarBarColor = true;
            this.pnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMain.VerticalScrollbarSize = 10;
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
            this.txtPhone.Location = new System.Drawing.Point(140, 180);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(199, 30);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(109, 20);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Phone Number:";
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
            this.txtId.Location = new System.Drawing.Point(140, 115);
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
            this.metroLabel2.Location = new System.Drawing.Point(89, 125);
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
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(60, 269);
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
            // mgvAdmin
            // 
            this.mgvAdmin.AllowUserToResizeRows = false;
            this.mgvAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.age,
            this.sex,
            this.reference,
            this.address,
            this.phone});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgvAdmin.EnableHeadersVisualStyles = false;
            this.mgvAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvAdmin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvAdmin.Location = new System.Drawing.Point(362, 18);
            this.mgvAdmin.Name = "mgvAdmin";
            this.mgvAdmin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgvAdmin.RowHeadersWidth = 51;
            this.mgvAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvAdmin.RowTemplate.Height = 24;
            this.mgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvAdmin.Size = new System.Drawing.Size(677, 356);
            this.mgvAdmin.TabIndex = 5;
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
            this.btnSearch.Location = new System.Drawing.Point(218, 269);
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
            this.txtName.Location = new System.Drawing.Point(140, 56);
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
            this.metroLabel1.Location = new System.Drawing.Point(62, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Name:";
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.txtAage);
            this.pnlEdit.Controls.Add(this.metroLabel10);
            this.pnlEdit.Controls.Add(this.btnAlogout);
            this.pnlEdit.Controls.Add(this.txtAphone);
            this.pnlEdit.Controls.Add(this.metroLabel7);
            this.pnlEdit.Controls.Add(this.txtAsex);
            this.pnlEdit.Controls.Add(this.metroLabel8);
            this.pnlEdit.Controls.Add(this.txtAaddress);
            this.pnlEdit.Controls.Add(this.metroLabel9);
            this.pnlEdit.Controls.Add(this.txtAreference);
            this.pnlEdit.Controls.Add(this.metroLabel4);
            this.pnlEdit.Controls.Add(this.txtAid);
            this.pnlEdit.Controls.Add(this.metroLabel5);
            this.pnlEdit.Controls.Add(this.btnAback);
            this.pnlEdit.Controls.Add(this.btnUpdate);
            this.pnlEdit.Controls.Add(this.txtAname);
            this.pnlEdit.Controls.Add(this.metroLabel6);
            this.pnlEdit.HorizontalScrollbarBarColor = true;
            this.pnlEdit.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlEdit.HorizontalScrollbarSize = 10;
            this.pnlEdit.Location = new System.Drawing.Point(23, 63);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(1043, 486);
            this.pnlEdit.TabIndex = 15;
            this.pnlEdit.VerticalScrollbarBarColor = true;
            this.pnlEdit.VerticalScrollbarHighlightOnWheel = false;
            this.pnlEdit.VerticalScrollbarSize = 10;
            this.pnlEdit.Visible = false;
            // 
            // txtAage
            // 
            // 
            // 
            // 
            this.txtAage.CustomButton.Image = null;
            this.txtAage.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.txtAage.CustomButton.Name = "";
            this.txtAage.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtAage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAage.CustomButton.TabIndex = 1;
            this.txtAage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAage.CustomButton.UseSelectable = true;
            this.txtAage.CustomButton.Visible = false;
            this.txtAage.Lines = new string[0];
            this.txtAage.Location = new System.Drawing.Point(185, 204);
            this.txtAage.MaxLength = 32767;
            this.txtAage.Name = "txtAage";
            this.txtAage.PasswordChar = '\0';
            this.txtAage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAage.SelectedText = "";
            this.txtAage.SelectionLength = 0;
            this.txtAage.SelectionStart = 0;
            this.txtAage.ShortcutsEnabled = true;
            this.txtAage.Size = new System.Drawing.Size(254, 40);
            this.txtAage.TabIndex = 31;
            this.txtAage.UseSelectable = true;
            this.txtAage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(101, 204);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(37, 20);
            this.metroLabel10.TabIndex = 30;
            this.metroLabel10.Text = "Age:";
            // 
            // btnAlogout
            // 
            this.btnAlogout.Location = new System.Drawing.Point(897, 429);
            this.btnAlogout.Name = "btnAlogout";
            this.btnAlogout.Size = new System.Drawing.Size(121, 32);
            this.btnAlogout.TabIndex = 29;
            this.btnAlogout.Text = "Logout";
            this.btnAlogout.UseSelectable = true;
            this.btnAlogout.Click += new System.EventHandler(this.btnAlogout_Click);
            // 
            // txtAphone
            // 
            // 
            // 
            // 
            this.txtAphone.CustomButton.Image = null;
            this.txtAphone.CustomButton.Location = new System.Drawing.Point(223, 2);
            this.txtAphone.CustomButton.Name = "";
            this.txtAphone.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtAphone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAphone.CustomButton.TabIndex = 1;
            this.txtAphone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAphone.CustomButton.UseSelectable = true;
            this.txtAphone.CustomButton.Visible = false;
            this.txtAphone.Lines = new string[0];
            this.txtAphone.Location = new System.Drawing.Point(683, 143);
            this.txtAphone.MaxLength = 32767;
            this.txtAphone.Name = "txtAphone";
            this.txtAphone.PasswordChar = '\0';
            this.txtAphone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAphone.SelectedText = "";
            this.txtAphone.SelectionLength = 0;
            this.txtAphone.SelectionStart = 0;
            this.txtAphone.ShortcutsEnabled = true;
            this.txtAphone.Size = new System.Drawing.Size(261, 40);
            this.txtAphone.TabIndex = 28;
            this.txtAphone.UseSelectable = true;
            this.txtAphone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAphone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(512, 143);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(109, 20);
            this.metroLabel7.TabIndex = 27;
            this.metroLabel7.Text = "Phone Number:";
            // 
            // txtAsex
            // 
            // 
            // 
            // 
            this.txtAsex.CustomButton.Image = null;
            this.txtAsex.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.txtAsex.CustomButton.Name = "";
            this.txtAsex.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtAsex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAsex.CustomButton.TabIndex = 1;
            this.txtAsex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAsex.CustomButton.UseSelectable = true;
            this.txtAsex.CustomButton.Visible = false;
            this.txtAsex.Lines = new string[0];
            this.txtAsex.Location = new System.Drawing.Point(185, 279);
            this.txtAsex.MaxLength = 32767;
            this.txtAsex.Name = "txtAsex";
            this.txtAsex.PasswordChar = '\0';
            this.txtAsex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAsex.SelectedText = "";
            this.txtAsex.SelectionLength = 0;
            this.txtAsex.SelectionStart = 0;
            this.txtAsex.ShortcutsEnabled = true;
            this.txtAsex.Size = new System.Drawing.Size(254, 40);
            this.txtAsex.TabIndex = 26;
            this.txtAsex.UseSelectable = true;
            this.txtAsex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAsex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(105, 279);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(33, 20);
            this.metroLabel8.TabIndex = 25;
            this.metroLabel8.Text = "Sex:";
            // 
            // txtAaddress
            // 
            // 
            // 
            // 
            this.txtAaddress.CustomButton.Image = null;
            this.txtAaddress.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.txtAaddress.CustomButton.Name = "";
            this.txtAaddress.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.txtAaddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAaddress.CustomButton.TabIndex = 1;
            this.txtAaddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAaddress.CustomButton.UseSelectable = true;
            this.txtAaddress.CustomButton.Visible = false;
            this.txtAaddress.Lines = new string[0];
            this.txtAaddress.Location = new System.Drawing.Point(683, 50);
            this.txtAaddress.MaxLength = 32767;
            this.txtAaddress.Name = "txtAaddress";
            this.txtAaddress.PasswordChar = '\0';
            this.txtAaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAaddress.SelectedText = "";
            this.txtAaddress.SelectionLength = 0;
            this.txtAaddress.SelectionStart = 0;
            this.txtAaddress.ShortcutsEnabled = true;
            this.txtAaddress.Size = new System.Drawing.Size(264, 60);
            this.txtAaddress.TabIndex = 22;
            this.txtAaddress.UseSelectable = true;
            this.txtAaddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAaddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(559, 73);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(62, 20);
            this.metroLabel9.TabIndex = 21;
            this.metroLabel9.Text = "Address:";
            // 
            // txtAreference
            // 
            // 
            // 
            // 
            this.txtAreference.CustomButton.Image = null;
            this.txtAreference.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.txtAreference.CustomButton.Name = "";
            this.txtAreference.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtAreference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAreference.CustomButton.TabIndex = 1;
            this.txtAreference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAreference.CustomButton.UseSelectable = true;
            this.txtAreference.CustomButton.Visible = false;
            this.txtAreference.Lines = new string[0];
            this.txtAreference.Location = new System.Drawing.Point(185, 362);
            this.txtAreference.MaxLength = 32767;
            this.txtAreference.Name = "txtAreference";
            this.txtAreference.PasswordChar = '\0';
            this.txtAreference.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAreference.SelectedText = "";
            this.txtAreference.SelectionLength = 0;
            this.txtAreference.SelectionStart = 0;
            this.txtAreference.ShortcutsEnabled = true;
            this.txtAreference.Size = new System.Drawing.Size(254, 40);
            this.txtAreference.TabIndex = 20;
            this.txtAreference.UseSelectable = true;
            this.txtAreference.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAreference.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(65, 362);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 20);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Reference";
            // 
            // txtAid
            // 
            // 
            // 
            // 
            this.txtAid.CustomButton.Image = null;
            this.txtAid.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.txtAid.CustomButton.Name = "";
            this.txtAid.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtAid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAid.CustomButton.TabIndex = 1;
            this.txtAid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAid.CustomButton.UseSelectable = true;
            this.txtAid.CustomButton.Visible = false;
            this.txtAid.Lines = new string[0];
            this.txtAid.Location = new System.Drawing.Point(185, 50);
            this.txtAid.MaxLength = 32767;
            this.txtAid.Name = "txtAid";
            this.txtAid.PasswordChar = '\0';
            this.txtAid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAid.SelectedText = "";
            this.txtAid.SelectionLength = 0;
            this.txtAid.SelectionStart = 0;
            this.txtAid.ShortcutsEnabled = true;
            this.txtAid.Size = new System.Drawing.Size(254, 40);
            this.txtAid.TabIndex = 18;
            this.txtAid.UseSelectable = true;
            this.txtAid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(115, 53);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(23, 20);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Id:";
            // 
            // btnAback
            // 
            this.btnAback.Location = new System.Drawing.Point(562, 429);
            this.btnAback.Name = "btnAback";
            this.btnAback.Size = new System.Drawing.Size(115, 32);
            this.btnAback.TabIndex = 16;
            this.btnAback.Text = "Back";
            this.btnAback.UseSelectable = true;
            this.btnAback.Click += new System.EventHandler(this.btnAback_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(720, 429);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 32);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAname
            // 
            // 
            // 
            // 
            this.txtAname.CustomButton.Image = null;
            this.txtAname.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.txtAname.CustomButton.Name = "";
            this.txtAname.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtAname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAname.CustomButton.TabIndex = 1;
            this.txtAname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAname.CustomButton.UseSelectable = true;
            this.txtAname.CustomButton.Visible = false;
            this.txtAname.Lines = new string[0];
            this.txtAname.Location = new System.Drawing.Point(185, 126);
            this.txtAname.MaxLength = 32767;
            this.txtAname.Name = "txtAname";
            this.txtAname.PasswordChar = '\0';
            this.txtAname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAname.SelectedText = "";
            this.txtAname.SelectionLength = 0;
            this.txtAname.SelectionStart = 0;
            this.txtAname.ShortcutsEnabled = true;
            this.txtAname.Size = new System.Drawing.Size(254, 40);
            this.txtAname.TabIndex = 14;
            this.txtAname.UseSelectable = true;
            this.txtAname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(88, 126);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 20);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Name:";
            // 
            // ManageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 572);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlEdit);
            this.Name = "ManageAdmin";
            this.Text = "Manage Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageAdmin_FormClosed);
            this.Load += new System.EventHandler(this.ManageAdmin_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvAdmin)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMain;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroGrid mgvAdmin;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroPanel pnlEdit;
        private MetroFramework.Controls.MetroTextBox txtAphone;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtAsex;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtAaddress;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtAreference;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtAid;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnAback;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtAname;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnAlogout;
        private MetroFramework.Controls.MetroTextBox txtAage;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    }
}