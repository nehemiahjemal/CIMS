namespace CIMS
{
    partial class MemberList
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
            this.ListDGV = new System.Windows.Forms.DataGridView();
            this.mID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Living_Area = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.seferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.churchDBDataSet = new CIMS.ChurchDBDataSet();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeTeam = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.homeTeamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seferTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.seferTableAdapter();
            this.homeTeamTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.HomeTeamTableAdapter();
            this.valueTbox = new System.Windows.Forms.TextBox();
            this.byName_rdb = new System.Windows.Forms.RadioButton();
            this.byPhone_rdb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTeamBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.ListDGV.Location = new System.Drawing.Point(21, 88);
            this.ListDGV.Name = "ListDGV";
            this.ListDGV.ReadOnly = true;
            this.ListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListDGV.Size = new System.Drawing.Size(542, 418);
            this.ListDGV.TabIndex = 0;
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
            this.Living_Area.DataSource = this.seferBindingSource;
            this.Living_Area.DisplayMember = "sefer_name";
            this.Living_Area.HeaderText = "Living Area";
            this.Living_Area.Name = "Living_Area";
            this.Living_Area.ReadOnly = true;
            this.Living_Area.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Living_Area.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Living_Area.ValueMember = "sefer_id";
            // 
            // seferBindingSource
            // 
            this.seferBindingSource.DataMember = "sefer";
            this.seferBindingSource.DataSource = this.churchDBDataSet;
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
            // seferTableAdapter
            // 
            this.seferTableAdapter.ClearBeforeFill = true;
            // 
            // homeTeamTableAdapter
            // 
            this.homeTeamTableAdapter.ClearBeforeFill = true;
            // 
            // valueTbox
            // 
            this.valueTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTbox.Location = new System.Drawing.Point(21, 30);
            this.valueTbox.Name = "valueTbox";
            this.valueTbox.Size = new System.Drawing.Size(227, 22);
            this.valueTbox.TabIndex = 1;
            this.valueTbox.TextChanged += new System.EventHandler(this.valueTbox_TextChanged);
            // 
            // byName_rdb
            // 
            this.byName_rdb.AutoSize = true;
            this.byName_rdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byName_rdb.ForeColor = System.Drawing.Color.White;
            this.byName_rdb.Location = new System.Drawing.Point(302, 30);
            this.byName_rdb.Name = "byName_rdb";
            this.byName_rdb.Size = new System.Drawing.Size(89, 20);
            this.byName_rdb.TabIndex = 2;
            this.byName_rdb.TabStop = true;
            this.byName_rdb.Text = "By Name";
            this.byName_rdb.UseVisualStyleBackColor = true;
            // 
            // byPhone_rdb
            // 
            this.byPhone_rdb.AutoSize = true;
            this.byPhone_rdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byPhone_rdb.ForeColor = System.Drawing.Color.White;
            this.byPhone_rdb.Location = new System.Drawing.Point(471, 30);
            this.byPhone_rdb.Name = "byPhone_rdb";
            this.byPhone_rdb.Size = new System.Drawing.Size(92, 20);
            this.byPhone_rdb.TabIndex = 3;
            this.byPhone_rdb.TabStop = true;
            this.byPhone_rdb.Text = "By Phone";
            this.byPhone_rdb.UseVisualStyleBackColor = true;
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(603, 518);
            this.Controls.Add(this.byPhone_rdb);
            this.Controls.Add(this.byName_rdb);
            this.Controls.Add(this.valueTbox);
            this.Controls.Add(this.ListDGV);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(619, 557);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(619, 557);
            this.Name = "MemberList";
            this.Text = "MemberList";
            this.Load += new System.EventHandler(this.MemberList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTeamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListDGV;
        private ChurchDBDataSet churchDBDataSet;
        private System.Windows.Forms.BindingSource seferBindingSource;
        private ChurchDBDataSetTableAdapters.seferTableAdapter seferTableAdapter;
        private System.Windows.Forms.BindingSource homeTeamBindingSource;
        private ChurchDBDataSetTableAdapters.HomeTeamTableAdapter homeTeamTableAdapter;
        private System.Windows.Forms.TextBox valueTbox;
        private System.Windows.Forms.RadioButton byName_rdb;
        private System.Windows.Forms.RadioButton byPhone_rdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn mID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewComboBoxColumn Living_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewComboBoxColumn HomeTeam;
    }
}