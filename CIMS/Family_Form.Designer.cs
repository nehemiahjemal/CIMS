namespace CIMS
{
    partial class Family_Form
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
            System.Windows.Forms.Label family_repLabel;
            System.Windows.Forms.Label family_remarkLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.Family_NBAL = new System.Windows.Forms.TextBox();
            this.Family_NBA = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fmember_DGV = new System.Windows.Forms.DataGridView();
            this.memeber_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family_DGV = new System.Windows.Forms.DataGridView();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.churchDBDataSet = new CIMS.ChurchDBDataSet();
            this.family_repComboBox = new System.Windows.Forms.ComboBox();
            this.memberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.family_remarkTextBox = new System.Windows.Forms.TextBox();
            this.memberTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.MemberTableAdapter();
            this.Family_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family_rep = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NBAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            family_repLabel = new System.Windows.Forms.Label();
            family_remarkLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Family_NBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fmember_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Family_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // family_repLabel
            // 
            family_repLabel.AutoSize = true;
            family_repLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            family_repLabel.ForeColor = System.Drawing.Color.White;
            family_repLabel.Location = new System.Drawing.Point(12, 142);
            family_repLabel.Name = "family_repLabel";
            family_repLabel.Size = new System.Drawing.Size(131, 20);
            family_repLabel.TabIndex = 57;
            family_repLabel.Text = "Representative";
            // 
            // family_remarkLabel
            // 
            family_remarkLabel.AutoSize = true;
            family_remarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            family_remarkLabel.ForeColor = System.Drawing.Color.White;
            family_remarkLabel.Location = new System.Drawing.Point(12, 195);
            family_remarkLabel.Name = "family_remarkLabel";
            family_remarkLabel.Size = new System.Drawing.Size(99, 20);
            family_remarkLabel.TabIndex = 59;
            family_remarkLabel.Text = "Family Title";
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(422, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(368, 41);
            label3.TabIndex = 65;
            label3.Text = "Family Management";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(3, 250);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(148, 43);
            label4.TabIndex = 101;
            label4.Text = "No of Non-Born Again Members";
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(3, 324);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(137, 47);
            label5.TabIndex = 102;
            label5.Text = "Non-Born Again Members List";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 77);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::CIMS.Properties.Resources.icons8_remove_user_64;
            this.button5.Location = new System.Drawing.Point(1037, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 61);
            this.button5.TabIndex = 4;
            this.button5.Text = "Remove Family Member";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::CIMS.Properties.Resources.icons8_add_user_group_man_man_48;
            this.button4.Location = new System.Drawing.Point(788, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add Family Member";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::CIMS.Properties.Resources.sav1;
            this.button2.Location = new System.Drawing.Point(175, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CIMS.Properties.Resources.icons8_new_48;
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(this.Family_NBAL);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.Family_NBA);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Fmember_DGV);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Family_DGV);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(family_repLabel);
            this.panel2.Controls.Add(this.family_repComboBox);
            this.panel2.Controls.Add(family_remarkLabel);
            this.panel2.Controls.Add(this.family_remarkTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 631);
            this.panel2.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Image = global::CIMS.Properties.Resources.icons8_search_bar_50;
            this.button7.Location = new System.Drawing.Point(340, 131);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 36);
            this.button7.TabIndex = 104;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Family_NBAL
            // 
            this.Family_NBAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Family_NBAL.Location = new System.Drawing.Point(146, 325);
            this.Family_NBAL.Multiline = true;
            this.Family_NBAL.Name = "Family_NBAL";
            this.Family_NBAL.Size = new System.Drawing.Size(227, 246);
            this.Family_NBAL.TabIndex = 103;
            // 
            // Family_NBA
            // 
            this.Family_NBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Family_NBA.Location = new System.Drawing.Point(155, 252);
            this.Family_NBA.Name = "Family_NBA";
            this.Family_NBA.Size = new System.Drawing.Size(218, 26);
            this.Family_NBA.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(844, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "Family Members";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 29);
            this.label1.TabIndex = 63;
            this.label1.Text = "List Of Family";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fmember_DGV
            // 
            this.Fmember_DGV.AllowUserToAddRows = false;
            this.Fmember_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Fmember_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memeber_id,
            this.Full_Name,
            this.Phone,
            this.role});
            this.Fmember_DGV.Location = new System.Drawing.Point(826, 135);
            this.Fmember_DGV.Name = "Fmember_DGV";
            this.Fmember_DGV.ReadOnly = true;
            this.Fmember_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Fmember_DGV.Size = new System.Drawing.Size(421, 466);
            this.Fmember_DGV.TabIndex = 62;
            this.Fmember_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Fmember_DGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Fmember_DGV_DataError);
            // 
            // memeber_id
            // 
            this.memeber_id.HeaderText = "Member  ID";
            this.memeber_id.Name = "memeber_id";
            this.memeber_id.ReadOnly = true;
            // 
            // Full_Name
            // 
            this.Full_Name.HeaderText = "Full Name";
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone No.";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // Family_DGV
            // 
            this.Family_DGV.AllowUserToAddRows = false;
            this.Family_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Family_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Family_id,
            this.Family_rep,
            this.Remark,
            this.NBA,
            this.NBAM});
            this.Family_DGV.Location = new System.Drawing.Point(402, 135);
            this.Family_DGV.Name = "Family_DGV";
            this.Family_DGV.ReadOnly = true;
            this.Family_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Family_DGV.Size = new System.Drawing.Size(409, 466);
            this.Family_DGV.TabIndex = 61;
            this.Family_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Family_DGV_CellClick);
            this.Family_DGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Family_DGV_DataError);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.churchDBDataSet;
            // 
            // churchDBDataSet
            // 
            this.churchDBDataSet.DataSetName = "ChurchDBDataSet";
            this.churchDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // family_repComboBox
            // 
            this.family_repComboBox.DataSource = this.memberBindingSource1;
            this.family_repComboBox.DisplayMember = "Member_name";
            this.family_repComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.family_repComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.family_repComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.family_repComboBox.FormattingEnabled = true;
            this.family_repComboBox.Location = new System.Drawing.Point(155, 138);
            this.family_repComboBox.Name = "family_repComboBox";
            this.family_repComboBox.Size = new System.Drawing.Size(179, 24);
            this.family_repComboBox.TabIndex = 58;
            this.family_repComboBox.ValueMember = "Member_id";
            // 
            // memberBindingSource1
            // 
            this.memberBindingSource1.DataMember = "Member";
            this.memberBindingSource1.DataSource = this.churchDBDataSet;
            // 
            // family_remarkTextBox
            // 
            this.family_remarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.family_remarkTextBox.Location = new System.Drawing.Point(154, 197);
            this.family_remarkTextBox.Name = "family_remarkTextBox";
            this.family_remarkTextBox.Size = new System.Drawing.Size(218, 22);
            this.family_remarkTextBox.TabIndex = 60;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // Family_id
            // 
            this.Family_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Family_id.HeaderText = "Family_id";
            this.Family_id.Name = "Family_id";
            this.Family_id.ReadOnly = true;
            // 
            // Family_rep
            // 
            this.Family_rep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Family_rep.DataSource = this.memberBindingSource;
            this.Family_rep.DisplayMember = "Member_name";
            this.Family_rep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Family_rep.HeaderText = "Family Rep";
            this.Family_rep.Name = "Family_rep";
            this.Family_rep.ReadOnly = true;
            this.Family_rep.ValueMember = "Member_id";
            // 
            // Remark
            // 
            this.Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remark.HeaderText = "Title";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NBA
            // 
            this.NBA.HeaderText = "NBA";
            this.NBA.Name = "NBA";
            this.NBA.ReadOnly = true;
            this.NBA.Visible = false;
            // 
            // NBAM
            // 
            this.NBAM.HeaderText = "NBAM";
            this.NBAM.Name = "NBAM";
            this.NBAM.ReadOnly = true;
            this.NBAM.Visible = false;
            // 
            // Family_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 708);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Family_Form";
            this.Text = "Family Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Family_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Family_NBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fmember_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Family_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Family_DGV;
        private System.Windows.Forms.ComboBox family_repComboBox;
        private System.Windows.Forms.TextBox family_remarkTextBox;
        private ChurchDBDataSet churchDBDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private ChurchDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.BindingSource memberBindingSource1;
        private System.Windows.Forms.DataGridView Fmember_DGV;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memeber_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.TextBox Family_NBAL;
        private System.Windows.Forms.NumericUpDown Family_NBA;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn Family_rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn NBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NBAM;
    }
}