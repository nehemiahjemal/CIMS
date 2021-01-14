namespace CIMS
{
    partial class MemberList2
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
            this.byPhone_rdb = new System.Windows.Forms.RadioButton();
            this.byName_rdb = new System.Windows.Forms.RadioButton();
            this.valueTbox = new System.Windows.Forms.TextBox();
            this.ListDGV = new System.Windows.Forms.DataGridView();
            this.mID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Living_Area = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.familyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.churchDBDataSet = new CIMS.ChurchDBDataSet();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeTeam = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.homeTeamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seferTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.seferTableAdapter();
            this.homeTeamTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.HomeTeamTableAdapter();
            this.familyTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.FamilyTableAdapter();
            this.role_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTeamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // byPhone_rdb
            // 
            this.byPhone_rdb.AutoSize = true;
            this.byPhone_rdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byPhone_rdb.ForeColor = System.Drawing.Color.White;
            this.byPhone_rdb.Location = new System.Drawing.Point(553, 87);
            this.byPhone_rdb.Name = "byPhone_rdb";
            this.byPhone_rdb.Size = new System.Drawing.Size(92, 20);
            this.byPhone_rdb.TabIndex = 7;
            this.byPhone_rdb.TabStop = true;
            this.byPhone_rdb.Text = "By Phone";
            this.byPhone_rdb.UseVisualStyleBackColor = true;
            // 
            // byName_rdb
            // 
            this.byName_rdb.AutoSize = true;
            this.byName_rdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byName_rdb.ForeColor = System.Drawing.Color.White;
            this.byName_rdb.Location = new System.Drawing.Point(416, 86);
            this.byName_rdb.Name = "byName_rdb";
            this.byName_rdb.Size = new System.Drawing.Size(89, 20);
            this.byName_rdb.TabIndex = 6;
            this.byName_rdb.TabStop = true;
            this.byName_rdb.Text = "By Name";
            this.byName_rdb.UseVisualStyleBackColor = true;
            // 
            // valueTbox
            // 
            this.valueTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTbox.Location = new System.Drawing.Point(145, 86);
            this.valueTbox.Name = "valueTbox";
            this.valueTbox.Size = new System.Drawing.Size(227, 22);
            this.valueTbox.TabIndex = 5;
            this.valueTbox.TextChanged += new System.EventHandler(this.valueTbox_TextChanged);
            // 
            // ListDGV
            // 
            this.ListDGV.AllowUserToAddRows = false;
            this.ListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mID,
            this.Full_Name,
            this.Sex,
            this.Living_Area,
            this.Phone,
            this.HomeTeam});
            this.ListDGV.Location = new System.Drawing.Point(27, 131);
            this.ListDGV.Name = "ListDGV";
            this.ListDGV.ReadOnly = true;
            this.ListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListDGV.Size = new System.Drawing.Size(641, 521);
            this.ListDGV.TabIndex = 4;
            this.ListDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDGV_CellDoubleClick);
            this.ListDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ListDGV_DataError);
            // 
            // mID
            // 
            this.mID.HeaderText = "ID";
            this.mID.Name = "mID";
            this.mID.ReadOnly = true;
            // 
            // Full_Name
            // 
            this.Full_Name.HeaderText = "Full Name";
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // Living_Area
            // 
            this.Living_Area.DataSource = this.familyBindingSource;
            this.Living_Area.DisplayMember = "Family_remark";
            this.Living_Area.HeaderText = "Family";
            this.Living_Area.Name = "Living_Area";
            this.Living_Area.ReadOnly = true;
            this.Living_Area.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Living_Area.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Living_Area.ValueMember = "Family_id";
            // 
            // familyBindingSource
            // 
            this.familyBindingSource.DataMember = "Family";
            this.familyBindingSource.DataSource = this.churchDBDataSet;
            // 
            // churchDBDataSet
            // 
            this.churchDBDataSet.DataSetName = "ChurchDBDataSet";
            this.churchDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // HomeTeam
            // 
            this.HomeTeam.DataSource = this.homeTeamBindingSource;
            this.HomeTeam.DisplayMember = "HomeTeam_title";
            this.HomeTeam.HeaderText = "HomeTeam";
            this.HomeTeam.Name = "HomeTeam";
            this.HomeTeam.ReadOnly = true;
            this.HomeTeam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HomeTeam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HomeTeam.ValueMember = "HomeTeam_id";
            // 
            // homeTeamBindingSource
            // 
            this.homeTeamBindingSource.DataMember = "HomeTeam";
            this.homeTeamBindingSource.DataSource = this.churchDBDataSet;
            // 
            // seferBindingSource
            // 
            this.seferBindingSource.DataMember = "sefer";
            this.seferBindingSource.DataSource = this.churchDBDataSet;
            // 
            // seferTableAdapter
            // 
            this.seferTableAdapter.ClearBeforeFill = true;
            // 
            // homeTeamTableAdapter
            // 
            this.homeTeamTableAdapter.ClearBeforeFill = true;
            // 
            // familyTableAdapter
            // 
            this.familyTableAdapter.ClearBeforeFill = true;
            // 
            // role_combo
            // 
            this.role_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.role_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_combo.FormattingEnabled = true;
            this.role_combo.Items.AddRange(new object[] {
            "Wife",
            "Husband",
            "Daughter",
            "Son",
            "Other"});
            this.role_combo.Location = new System.Drawing.Point(130, 22);
            this.role_combo.Name = "role_combo";
            this.role_combo.Size = new System.Drawing.Size(242, 26);
            this.role_combo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Role in Family";
            // 
            // MemberList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(685, 652);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.role_combo);
            this.Controls.Add(this.byPhone_rdb);
            this.Controls.Add(this.byName_rdb);
            this.Controls.Add(this.valueTbox);
            this.Controls.Add(this.ListDGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberList2";
            this.Text = "Add Family Member";
            this.Load += new System.EventHandler(this.MemberList2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTeamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton byPhone_rdb;
        private System.Windows.Forms.RadioButton byName_rdb;
        private System.Windows.Forms.TextBox valueTbox;
        private System.Windows.Forms.DataGridView ListDGV;
        private ChurchDBDataSet churchDBDataSet;
        private System.Windows.Forms.BindingSource seferBindingSource;
        private ChurchDBDataSetTableAdapters.seferTableAdapter seferTableAdapter;
        private System.Windows.Forms.BindingSource homeTeamBindingSource;
        private ChurchDBDataSetTableAdapters.HomeTeamTableAdapter homeTeamTableAdapter;
        private System.Windows.Forms.BindingSource familyBindingSource;
        private ChurchDBDataSetTableAdapters.FamilyTableAdapter familyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewComboBoxColumn Living_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewComboBoxColumn HomeTeam;
        private System.Windows.Forms.ComboBox role_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}