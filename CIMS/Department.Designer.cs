namespace CIMS
{
    partial class Department
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dept_nameLabel;
            System.Windows.Forms.Label dept_serviceAreaLabel;
            System.Windows.Forms.Label dept_headLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Dept_DGV = new System.Windows.Forms.DataGridView();
            this.Dept_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_Field = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.serviceAreaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.churchDBDataSet = new CIMS.ChurchDBDataSet();
            this.Dept_head = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.memberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dept_headComboBox = new System.Windows.Forms.ComboBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dept_serviceAreaComboBox = new System.Windows.Forms.ComboBox();
            this.serviceAreaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dept_nameTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deptMembers_DGV = new System.Windows.Forms.DataGridView();
            this.member_idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memb_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivingArea = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.seferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.serviceAreaTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.ServiceAreaTableAdapter();
            this.memberTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.MemberTableAdapter();
            this.seferTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.seferTableAdapter();
            dept_nameLabel = new System.Windows.Forms.Label();
            dept_serviceAreaLabel = new System.Windows.Forms.Label();
            dept_headLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dept_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAreaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAreaBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptMembers_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dept_nameLabel
            // 
            dept_nameLabel.AutoSize = true;
            dept_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dept_nameLabel.ForeColor = System.Drawing.Color.DimGray;
            dept_nameLabel.Location = new System.Drawing.Point(21, 90);
            dept_nameLabel.Name = "dept_nameLabel";
            dept_nameLabel.Size = new System.Drawing.Size(94, 18);
            dept_nameLabel.TabIndex = 83;
            dept_nameLabel.Text = "Dept name:";
            // 
            // dept_serviceAreaLabel
            // 
            dept_serviceAreaLabel.AutoSize = true;
            dept_serviceAreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dept_serviceAreaLabel.ForeColor = System.Drawing.Color.DimGray;
            dept_serviceAreaLabel.Location = new System.Drawing.Point(21, 134);
            dept_serviceAreaLabel.Name = "dept_serviceAreaLabel";
            dept_serviceAreaLabel.Size = new System.Drawing.Size(148, 18);
            dept_serviceAreaLabel.TabIndex = 85;
            dept_serviceAreaLabel.Text = "Dept service Field:";
            // 
            // dept_headLabel
            // 
            dept_headLabel.AutoSize = true;
            dept_headLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dept_headLabel.ForeColor = System.Drawing.Color.DimGray;
            dept_headLabel.Location = new System.Drawing.Point(21, 179);
            dept_headLabel.Name = "dept_headLabel";
            dept_headLabel.Size = new System.Drawing.Size(89, 18);
            dept_headLabel.TabIndex = 87;
            dept_headLabel.Text = "Dept head:";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(336, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(550, 52);
            label1.TabIndex = 90;
            label1.Text = "Department Management";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.DarkGray;
            label2.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(9, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(522, 34);
            label2.TabIndex = 91;
            label2.Text = "Department";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.DarkGray;
            label3.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(19, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(826, 35);
            label3.TabIndex = 93;
            label3.Text = "Department Members";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 87);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::CIMS.Properties.Resources.icons8_new_48;
            this.button3.Location = new System.Drawing.Point(15, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clear";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CIMS.Properties.Resources.sav1;
            this.button1.Location = new System.Drawing.Point(195, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 694);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.Dept_DGV);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(542, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(708, 338);
            this.panel5.TabIndex = 92;
            // 
            // Dept_DGV
            // 
            this.Dept_DGV.AllowUserToAddRows = false;
            this.Dept_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dept_DGV.BackgroundColor = System.Drawing.Color.Silver;
            this.Dept_DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dept_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dept_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dept_id,
            this.Dept_Name,
            this.Service_Field,
            this.Dept_head});
            this.Dept_DGV.Location = new System.Drawing.Point(26, 14);
            this.Dept_DGV.Name = "Dept_DGV";
            this.Dept_DGV.ReadOnly = true;
            this.Dept_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dept_DGV.Size = new System.Drawing.Size(658, 414);
            this.Dept_DGV.TabIndex = 89;
            this.Dept_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dept_DGV_CellClick);
            this.Dept_DGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Dept_DGV_DataError);
            // 
            // Dept_id
            // 
            this.Dept_id.HeaderText = "Dept ID";
            this.Dept_id.Name = "Dept_id";
            this.Dept_id.ReadOnly = true;
            // 
            // Dept_Name
            // 
            this.Dept_Name.HeaderText = "Dept Name";
            this.Dept_Name.Name = "Dept_Name";
            this.Dept_Name.ReadOnly = true;
            // 
            // Service_Field
            // 
            this.Service_Field.DataSource = this.serviceAreaBindingSource1;
            this.Service_Field.DisplayMember = "ServiceArea_name";
            this.Service_Field.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Service_Field.HeaderText = "Service Field";
            this.Service_Field.Name = "Service_Field";
            this.Service_Field.ReadOnly = true;
            this.Service_Field.ValueMember = "ServiceArea_id";
            // 
            // serviceAreaBindingSource1
            // 
            this.serviceAreaBindingSource1.DataMember = "ServiceArea";
            this.serviceAreaBindingSource1.DataSource = this.churchDBDataSet;
            // 
            // churchDBDataSet
            // 
            this.churchDBDataSet.DataSetName = "ChurchDBDataSet";
            this.churchDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dept_head
            // 
            this.Dept_head.DataSource = this.memberBindingSource1;
            this.Dept_head.DisplayMember = "Member_name";
            this.Dept_head.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dept_head.HeaderText = "Dept Head";
            this.Dept_head.Name = "Dept_head";
            this.Dept_head.ReadOnly = true;
            this.Dept_head.ValueMember = "Member_id";
            // 
            // memberBindingSource1
            // 
            this.memberBindingSource1.DataMember = "Member";
            this.memberBindingSource1.DataSource = this.churchDBDataSet;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(dept_nameLabel);
            this.panel4.Controls.Add(this.dept_headComboBox);
            this.panel4.Controls.Add(label2);
            this.panel4.Controls.Add(dept_headLabel);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.dept_serviceAreaComboBox);
            this.panel4.Controls.Add(dept_serviceAreaLabel);
            this.panel4.Controls.Add(this.dept_nameTextBox);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(542, 338);
            this.panel4.TabIndex = 97;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::CIMS.Properties.Resources.icons8_search_bar_50;
            this.button2.Location = new System.Drawing.Point(475, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 36);
            this.button2.TabIndex = 94;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.Image = global::CIMS.Properties.Resources.add_new;
            this.button7.Location = new System.Drawing.Point(484, 131);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 37);
            this.button7.TabIndex = 93;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dept_headComboBox
            // 
            this.dept_headComboBox.DataSource = this.memberBindingSource;
            this.dept_headComboBox.DisplayMember = "Member_name";
            this.dept_headComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dept_headComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dept_headComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_headComboBox.FormattingEnabled = true;
            this.dept_headComboBox.Location = new System.Drawing.Point(195, 179);
            this.dept_headComboBox.Name = "dept_headComboBox";
            this.dept_headComboBox.Size = new System.Drawing.Size(274, 26);
            this.dept_headComboBox.TabIndex = 88;
            this.dept_headComboBox.ValueMember = "Member_id";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.churchDBDataSet;
            // 
            // dept_serviceAreaComboBox
            // 
            this.dept_serviceAreaComboBox.DataSource = this.serviceAreaBindingSource;
            this.dept_serviceAreaComboBox.DisplayMember = "ServiceArea_name";
            this.dept_serviceAreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dept_serviceAreaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dept_serviceAreaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_serviceAreaComboBox.FormattingEnabled = true;
            this.dept_serviceAreaComboBox.Location = new System.Drawing.Point(195, 134);
            this.dept_serviceAreaComboBox.Name = "dept_serviceAreaComboBox";
            this.dept_serviceAreaComboBox.Size = new System.Drawing.Size(274, 26);
            this.dept_serviceAreaComboBox.TabIndex = 86;
            this.dept_serviceAreaComboBox.ValueMember = "ServiceArea_id";
            this.dept_serviceAreaComboBox.DropDown += new System.EventHandler(this.dept_serviceAreaComboBox_DropDown);
            // 
            // serviceAreaBindingSource
            // 
            this.serviceAreaBindingSource.DataMember = "ServiceArea";
            this.serviceAreaBindingSource.DataSource = this.churchDBDataSet;
            // 
            // dept_nameTextBox
            // 
            this.dept_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_nameTextBox.Location = new System.Drawing.Point(195, 90);
            this.dept_nameTextBox.Name = "dept_nameTextBox";
            this.dept_nameTextBox.Size = new System.Drawing.Size(274, 24);
            this.dept_nameTextBox.TabIndex = 84;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.deptMembers_DGV);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 356);
            this.panel3.TabIndex = 96;
            // 
            // deptMembers_DGV
            // 
            this.deptMembers_DGV.AllowUserToAddRows = false;
            this.deptMembers_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deptMembers_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deptMembers_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.member_idd,
            this.Memb_name,
            this.Sex,
            this.Age,
            this.Phone,
            this.LivingArea});
            this.deptMembers_DGV.Location = new System.Drawing.Point(24, 72);
            this.deptMembers_DGV.Name = "deptMembers_DGV";
            this.deptMembers_DGV.ReadOnly = true;
            this.deptMembers_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deptMembers_DGV.Size = new System.Drawing.Size(1162, 308);
            this.deptMembers_DGV.TabIndex = 92;
            // 
            // member_idd
            // 
            this.member_idd.HeaderText = "Member ID";
            this.member_idd.Name = "member_idd";
            this.member_idd.ReadOnly = true;
            // 
            // Memb_name
            // 
            this.Memb_name.HeaderText = "Full Name";
            this.Memb_name.Name = "Memb_name";
            this.Memb_name.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // LivingArea
            // 
            this.LivingArea.DataSource = this.seferBindingSource;
            this.LivingArea.DisplayMember = "sefer_name";
            this.LivingArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LivingArea.HeaderText = "Living Area";
            this.LivingArea.Name = "LivingArea";
            this.LivingArea.ReadOnly = true;
            this.LivingArea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LivingArea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LivingArea.ValueMember = "sefer_id";
            // 
            // seferBindingSource
            // 
            this.seferBindingSource.DataMember = "sefer";
            this.seferBindingSource.DataSource = this.churchDBDataSet;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Image = global::CIMS.Properties.Resources.icons8_remove_user_64;
            this.button5.Location = new System.Drawing.Point(1036, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 56);
            this.button5.TabIndex = 95;
            this.button5.Text = "Remove Member";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::CIMS.Properties.Resources.icons8_add_user_group_man_man_48;
            this.button4.Location = new System.Drawing.Point(851, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 56);
            this.button4.TabIndex = 94;
            this.button4.Text = "Add Member";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // serviceAreaTableAdapter
            // 
            this.serviceAreaTableAdapter.ClearBeforeFill = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // seferTableAdapter
            // 
            this.seferTableAdapter.ClearBeforeFill = true;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 781);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Department";
            this.Text = "Department";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Department_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dept_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAreaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAreaBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deptMembers_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox dept_nameTextBox;
        private System.Windows.Forms.ComboBox dept_serviceAreaComboBox;
        private System.Windows.Forms.ComboBox dept_headComboBox;
        private ChurchDBDataSet churchDBDataSet;
        private System.Windows.Forms.BindingSource serviceAreaBindingSource;
        private ChurchDBDataSetTableAdapters.ServiceAreaTableAdapter serviceAreaTableAdapter;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private ChurchDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Dept_DGV;
        private System.Windows.Forms.BindingSource serviceAreaBindingSource1;
        private System.Windows.Forms.BindingSource memberBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept_Name;
        private System.Windows.Forms.DataGridViewComboBoxColumn Service_Field;
        private System.Windows.Forms.DataGridViewComboBoxColumn Dept_head;
        private System.Windows.Forms.DataGridView deptMembers_DGV;
        private System.Windows.Forms.BindingSource seferBindingSource;
        private ChurchDBDataSetTableAdapters.seferTableAdapter seferTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memb_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewComboBoxColumn LivingArea;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
    }
}