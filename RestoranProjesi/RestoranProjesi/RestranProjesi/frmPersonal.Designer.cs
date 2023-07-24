namespace RestranProjesi
{
    partial class frmPersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.comTuru = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMaas = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoyadi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDataPersonal = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdres = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "_urunid";
            this.dataGridViewTextBoxColumn1.HeaderText = "_urunid";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 115;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "_urunadi";
            this.dataGridViewTextBoxColumn2.HeaderText = "_urunadi";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 115;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "_urunturu";
            this.dataGridViewTextBoxColumn3.HeaderText = "_urunturu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 115;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "_fiyati";
            this.dataGridViewTextBoxColumn4.HeaderText = "_fiyati";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 115;
            // 
            // btnInsert
            // 
            this.btnInsert.AutoRoundedCorners = true;
            this.btnInsert.BorderRadius = 17;
            this.btnInsert.CustomizableEdges.TopLeft = false;
            this.btnInsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsert.FillColor = System.Drawing.Color.Peru;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(34, 105);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(111, 36);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Ekle";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 17;
            this.btnSave.CustomizableEdges.TopLeft = false;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Peru;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(161, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 36);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Kayıt et";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comTuru
            // 
            this.comTuru.AutoRoundedCorners = true;
            this.comTuru.BackColor = System.Drawing.Color.Transparent;
            this.comTuru.BorderRadius = 19;
            this.comTuru.CustomizableEdges.TopLeft = false;
            this.comTuru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTuru.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comTuru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comTuru.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Italic);
            this.comTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comTuru.ItemHeight = 35;
            this.comTuru.Items.AddRange(new object[] {
            "Garson",
            "Şef",
            "Yönteci",
            "Kasiyer"});
            this.comTuru.Location = new System.Drawing.Point(721, 60);
            this.comTuru.Name = "comTuru";
            this.comTuru.Size = new System.Drawing.Size(141, 41);
            this.comTuru.TabIndex = 19;
            this.comTuru.SelectedIndexChanged += new System.EventHandler(this.comTuru_SelectedIndexChanged);
            // 
            // txtMaas
            // 
            this.txtMaas.AutoRoundedCorners = true;
            this.txtMaas.BorderRadius = 13;
            this.txtMaas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaas.CustomizableEdges.TopLeft = false;
            this.txtMaas.DefaultText = "";
            this.txtMaas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaas.Enabled = false;
            this.txtMaas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaas.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaas.Location = new System.Drawing.Point(380, 60);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.PasswordChar = '\0';
            this.txtMaas.PlaceholderText = "";
            this.txtMaas.SelectedText = "";
            this.txtMaas.Size = new System.Drawing.Size(141, 29);
            this.txtMaas.TabIndex = 20;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.AutoRoundedCorners = true;
            this.txtSoyadi.BorderRadius = 13;
            this.txtSoyadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyadi.CustomizableEdges.TopLeft = false;
            this.txtSoyadi.DefaultText = "";
            this.txtSoyadi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoyadi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoyadi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoyadi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoyadi.Enabled = false;
            this.txtSoyadi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoyadi.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyadi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoyadi.Location = new System.Drawing.Point(207, 60);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.PasswordChar = '\0';
            this.txtSoyadi.PlaceholderText = "";
            this.txtSoyadi.SelectedText = "";
            this.txtSoyadi.Size = new System.Drawing.Size(141, 29);
            this.txtSoyadi.TabIndex = 21;
            // 
            // txtAdi
            // 
            this.txtAdi.AutoRoundedCorners = true;
            this.txtAdi.BorderRadius = 13;
            this.txtAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdi.CustomizableEdges.TopLeft = false;
            this.txtAdi.DefaultText = "";
            this.txtAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdi.Enabled = false;
            this.txtAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdi.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdi.Location = new System.Drawing.Point(33, 60);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.PasswordChar = '\0';
            this.txtAdi.PlaceholderText = "";
            this.txtAdi.SelectedText = "";
            this.txtAdi.Size = new System.Drawing.Size(141, 29);
            this.txtAdi.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(203, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(376, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Maas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvDataPersonal
            // 
            this.dgvDataPersonal.AllowUserToAddRows = false;
            this.dgvDataPersonal.AllowUserToDeleteRows = false;
            this.dgvDataPersonal.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvDataPersonal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDataPersonal.ColumnHeadersHeight = 4;
            this.dgvDataPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataPersonal.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDataPersonal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDataPersonal.Location = new System.Drawing.Point(33, 223);
            this.dgvDataPersonal.MultiSelect = false;
            this.dgvDataPersonal.Name = "dgvDataPersonal";
            this.dgvDataPersonal.ReadOnly = true;
            this.dgvDataPersonal.RowHeadersVisible = false;
            this.dgvDataPersonal.RowHeadersWidth = 47;
            this.dgvDataPersonal.Size = new System.Drawing.Size(870, 385);
            this.dgvDataPersonal.TabIndex = 26;
            this.dgvDataPersonal.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDataPersonal.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDataPersonal.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDataPersonal.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDataPersonal.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDataPersonal.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDataPersonal.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDataPersonal.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDataPersonal.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDataPersonal.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvDataPersonal.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDataPersonal.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDataPersonal.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDataPersonal.ThemeStyle.ReadOnly = true;
            this.dgvDataPersonal.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDataPersonal.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDataPersonal.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvDataPersonal.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDataPersonal.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDataPersonal.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDataPersonal.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(29, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "#Sr";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(208, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Adi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(380, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Soyadi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(717, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Personal Tipi";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(548, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Telefon No";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.AutoRoundedCorners = true;
            this.txtTelefon.BorderRadius = 13;
            this.txtTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefon.CustomizableEdges.TopLeft = false;
            this.txtTelefon.DefaultText = "";
            this.txtTelefon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefon.Enabled = false;
            this.txtTelefon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefon.Location = new System.Drawing.Point(552, 60);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.PasswordChar = '\0';
            this.txtTelefon.PlaceholderText = "";
            this.txtTelefon.SelectedText = "";
            this.txtTelefon.Size = new System.Drawing.Size(141, 29);
            this.txtTelefon.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(883, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Adress";
            // 
            // txtAdres
            // 
            this.txtAdres.AutoRoundedCorners = true;
            this.txtAdres.BorderRadius = 13;
            this.txtAdres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdres.CustomizableEdges.TopLeft = false;
            this.txtAdres.DefaultText = "";
            this.txtAdres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdres.Enabled = false;
            this.txtAdres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdres.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdres.Location = new System.Drawing.Point(887, 60);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.PasswordChar = '\0';
            this.txtAdres.PlaceholderText = "";
            this.txtAdres.SelectedText = "";
            this.txtAdres.Size = new System.Drawing.Size(225, 29);
            this.txtAdres.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.Location = new System.Drawing.Point(727, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 36;
            this.label11.Text = "Maas";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.Location = new System.Drawing.Point(548, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 19);
            this.label12.TabIndex = 37;
            this.label12.Text = "Personal Tipi";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 639);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDataPersonal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.comTuru);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonal";
            this.Text = "frmPersonal";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Guna.UI2.WinForms.Guna2Button btnInsert;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox comTuru;
        private Guna.UI2.WinForms.Guna2TextBox txtMaas;
        private Guna.UI2.WinForms.Guna2TextBox txtSoyadi;
        private Guna.UI2.WinForms.Guna2TextBox txtAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDataPersonal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefon;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtAdres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}