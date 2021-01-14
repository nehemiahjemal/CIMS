namespace CIMS
{
    partial class HomeTeamForm
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
            System.Windows.Forms.Label homeTeam_headLabel;
            System.Windows.Forms.Label homeTeam_WriterLabel;
            System.Windows.Forms.Label homeTeam_titleLabel;
            System.Windows.Forms.Label label3;
            this.homeTeam_headComboBox = new System.Windows.Forms.ComboBox();
            this.memberBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.churchDBDataSet = new CIMS.ChurchDBDataSet();
            this.homeTeam_WriterComboBox = new System.Windows.Forms.ComboBox();
            this.memberBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.homeTeam_titleTextBox = new System.Windows.Forms.TextBox();
            this.HomeTeamDGV = new System.Windows.Forms.DataGridView();
            this.ht_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ht_head = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ht_writer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.memberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ht_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.MemberTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.member_dgv = new System.Windows.Forms.DataGridView();
            this.MbId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            homeTeam_headLabel = new System.Windows.Forms.Label();
            homeTeam_WriterLabel = new System.Windows.Forms.Label();
            homeTeam_titleLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeTeamDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.member_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // homeTeam_headLabel
            // 
            homeTeam_headLabel.AutoSize = true;
            homeTeam_headLabel.BackColor = System.Drawing.Color.DarkGray;
            homeTeam_headLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            homeTeam_headLabel.ForeColor = System.Drawing.Color.White;
            homeTeam_headLabel.Location = new System.Drawing.Point(25, 136);
            homeTeam_headLabel.Name = "homeTeam_headLabel";
            homeTeam_headLabel.Size = new System.Drawing.Size(184, 24);
            homeTeam_headLabel.TabIndex = 83;
            homeTeam_headLabel.Text = "Home Team head:";
            // 
            // homeTeam_WriterLabel
            // 
            homeTeam_WriterLabel.AutoSize = true;
            homeTeam_WriterLabel.BackColor = System.Drawing.Color.DarkGray;
            homeTeam_WriterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            homeTeam_WriterLabel.ForeColor = System.Drawing.Color.White;
            homeTeam_WriterLabel.Location = new System.Drawing.Point(25, 187);
            homeTeam_WriterLabel.Name = "homeTeam_WriterLabel";
            homeTeam_WriterLabel.Size = new System.Drawing.Size(192, 24);
            homeTeam_WriterLabel.TabIndex = 85;
            homeTeam_WriterLabel.Text = "Home Team Writer:";
            // 
            // homeTeam_titleLabel
            // 
            homeTeam_titleLabel.AutoSize = true;
            homeTeam_titleLabel.BackColor = System.Drawing.Color.DarkGray;
            homeTeam_titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            homeTeam_titleLabel.ForeColor = System.Drawing.Color.White;
            homeTeam_titleLabel.Location = new System.Drawing.Point(25, 238);
            homeTeam_titleLabel.Name = "homeTeam_titleLabel";
            homeTeam_titleLabel.Size = new System.Drawing.Size(169, 24);
            homeTeam_titleLabel.TabIndex = 87;
            homeTeam_titleLabel.Text = "Home Team title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(439, 27);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(373, 33);
            label3.TabIndex = 95;
            label3.Text = "Home Team Management";
            // 
            // homeTeam_headComboBox
            // 
            this.homeTeam_headComboBox.DataSource = this.memberBindingSource2;
            this.homeTeam_headComboBox.DisplayMember = "Member_name";
            this.homeTeam_headComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.homeTeam_headComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.homeTeam_headComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeam_headComboBox.FormattingEnabled = true;
            this.homeTeam_headComboBox.Location = new System.Drawing.Point(233, 136);
            this.homeTeam_headComboBox.MaxDropDownItems = 100;
            this.homeTeam_headComboBox.Name = "homeTeam_headComboBox";
            this.homeTeam_headComboBox.Size = new System.Drawing.Size(315, 28);
            this.homeTeam_headComboBox.TabIndex = 84;
            this.homeTeam_headComboBox.ValueMember = "Member_id";
            // 
            // memberBindingSource2
            // 
            this.memberBindingSource2.DataMember = "Member";
            this.memberBindingSource2.DataSource = this.churchDBDataSet;
            // 
            // churchDBDataSet
            // 
            this.churchDBDataSet.DataSetName = "ChurchDBDataSet";
            this.churchDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // homeTeam_WriterComboBox
            // 
            this.homeTeam_WriterComboBox.DataSource = this.memberBindingSource3;
            this.homeTeam_WriterComboBox.DisplayMember = "Member_name";
            this.homeTeam_WriterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.homeTeam_WriterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.homeTeam_WriterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeam_WriterComboBox.FormattingEnabled = true;
            this.homeTeam_WriterComboBox.Location = new System.Drawing.Point(233, 187);
            this.homeTeam_WriterComboBox.Name = "homeTeam_WriterComboBox";
            this.homeTeam_WriterComboBox.Size = new System.Drawing.Size(315, 28);
            this.homeTeam_WriterComboBox.TabIndex = 86;
            this.homeTeam_WriterComboBox.ValueMember = "Member_id";
            // 
            // memberBindingSource3
            // 
            this.memberBindingSource3.DataMember = "Member";
            this.memberBindingSource3.DataSource = this.churchDBDataSet;
            // 
            // homeTeam_titleTextBox
            // 
            this.homeTeam_titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeam_titleTextBox.Location = new System.Drawing.Point(233, 238);
            this.homeTeam_titleTextBox.Name = "homeTeam_titleTextBox";
            this.homeTeam_titleTextBox.Size = new System.Drawing.Size(315, 26);
            this.homeTeam_titleTextBox.TabIndex = 88;
            // 
            // HomeTeamDGV
            // 
            this.HomeTeamDGV.AllowUserToAddRows = false;
            this.HomeTeamDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HomeTeamDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ht_id,
            this.ht_head,
            this.ht_writer,
            this.ht_title});
            this.HomeTeamDGV.Location = new System.Drawing.Point(642, 57);
            this.HomeTeamDGV.Name = "HomeTeamDGV";
            this.HomeTeamDGV.ReadOnly = true;
            this.HomeTeamDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HomeTeamDGV.Size = new System.Drawing.Size(620, 232);
            this.HomeTeamDGV.TabIndex = 89;
            this.HomeTeamDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HomeTeamDGV_CellClick);
            this.HomeTeamDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.HomeTeamDGV_DataError);
            // 
            // ht_id
            // 
            this.ht_id.HeaderText = "Home Team Id";
            this.ht_id.Name = "ht_id";
            this.ht_id.ReadOnly = true;
            // 
            // ht_head
            // 
            this.ht_head.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ht_head.DataSource = this.memberBindingSource;
            this.ht_head.DisplayMember = "Member_name";
            this.ht_head.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ht_head.HeaderText = "Home Team Head";
            this.ht_head.Name = "ht_head";
            this.ht_head.ReadOnly = true;
            this.ht_head.ValueMember = "Member_id";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.churchDBDataSet;
            // 
            // ht_writer
            // 
            this.ht_writer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ht_writer.DataSource = this.memberBindingSource1;
            this.ht_writer.DisplayMember = "Member_name";
            this.ht_writer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ht_writer.HeaderText = "Home Team Writer";
            this.ht_writer.Name = "ht_writer";
            this.ht_writer.ReadOnly = true;
            this.ht_writer.ValueMember = "Member_id";
            // 
            // memberBindingSource1
            // 
            this.memberBindingSource1.DataMember = "Member";
            this.memberBindingSource1.DataSource = this.churchDBDataSet;
            // 
            // ht_title
            // 
            this.ht_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ht_title.HeaderText = "Title";
            this.ht_title.Name = "ht_title";
            this.ht_title.ReadOnly = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 77);
            this.panel1.TabIndex = 90;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::CIMS.Properties.Resources.icons8_remove_user_64;
            this.button5.Location = new System.Drawing.Point(1039, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 59);
            this.button5.TabIndex = 94;
            this.button5.Text = "Remove Member";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::CIMS.Properties.Resources.icons8_add_user_group_man_man_48;
            this.button4.Location = new System.Drawing.Point(1039, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 59);
            this.button4.TabIndex = 93;
            this.button4.Text = "Add Member";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::CIMS.Properties.Resources.icons8_new_48;
            this.button2.Location = new System.Drawing.Point(19, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 53);
            this.button2.TabIndex = 91;
            this.button2.Text = "Clear";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CIMS.Properties.Resources.sav1;
            this.button1.Location = new System.Drawing.Point(300, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 53);
            this.button1.TabIndex = 90;
            this.button1.Text = "Save";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.HomeTeamDGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1274, 704);
            this.panel2.TabIndex = 91;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.homeTeam_headComboBox);
            this.panel4.Controls.Add(homeTeam_headLabel);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(homeTeam_WriterLabel);
            this.panel4.Controls.Add(this.homeTeam_WriterComboBox);
            this.panel4.Controls.Add(homeTeam_titleLabel);
            this.panel4.Controls.Add(this.homeTeam_titleTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(624, 307);
            this.panel4.TabIndex = 96;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Image = global::CIMS.Properties.Resources.icons8_search_bar_50;
            this.button7.Location = new System.Drawing.Point(561, 132);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 36);
            this.button7.TabIndex = 96;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Image = global::CIMS.Properties.Resources.icons8_search_bar_50;
            this.button6.Location = new System.Drawing.Point(560, 184);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 36);
            this.button6.TabIndex = 95;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.member_dgv);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1270, 393);
            this.panel3.TabIndex = 95;
            // 
            // member_dgv
            // 
            this.member_dgv.AllowUserToAddRows = false;
            this.member_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.member_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MbId,
            this.Member_name,
            this.Member_phone});
            this.member_dgv.Location = new System.Drawing.Point(111, 55);
            this.member_dgv.Name = "member_dgv";
            this.member_dgv.ReadOnly = true;
            this.member_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.member_dgv.Size = new System.Drawing.Size(904, 326);
            this.member_dgv.TabIndex = 91;
            this.member_dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.member_dgv_DataError);
            // 
            // MbId
            // 
            this.MbId.HeaderText = "ID";
            this.MbId.Name = "MbId";
            this.MbId.ReadOnly = true;
            // 
            // Member_name
            // 
            this.Member_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Member_name.HeaderText = "Full Name";
            this.Member_name.Name = "Member_name";
            this.Member_name.ReadOnly = true;
            // 
            // Member_phone
            // 
            this.Member_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Member_phone.HeaderText = "Phone No.";
            this.Member_phone.Name = "Member_phone";
            this.Member_phone.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(111, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(904, 29);
            this.label2.TabIndex = 92;
            this.label2.Text = "Home Team Members";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(642, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 29);
            this.label1.TabIndex = 90;
            this.label1.Text = "Home Team List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 781);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.MinimumSize = new System.Drawing.Size(825, 463);
            this.Name = "HomeTeamForm";
            this.Text = "HomeTeamForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeTeamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeTeamDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.member_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox homeTeam_headComboBox;
        private System.Windows.Forms.ComboBox homeTeam_WriterComboBox;
        private System.Windows.Forms.TextBox homeTeam_titleTextBox;
        private System.Windows.Forms.DataGridView HomeTeamDGV;
        private ChurchDBDataSet churchDBDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private ChurchDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.BindingSource memberBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource memberBindingSource2;
        private System.Windows.Forms.BindingSource memberBindingSource3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView member_dgv;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ht_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn ht_head;
        private System.Windows.Forms.DataGridViewComboBoxColumn ht_writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ht_title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_phone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}