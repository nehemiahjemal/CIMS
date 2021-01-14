namespace CIMS
{
    partial class MemberList4
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
            this.byPhone_rdb = new System.Windows.Forms.RadioButton();
            this.byName_rdb = new System.Windows.Forms.RadioButton();
            this.valueTbox = new System.Windows.Forms.TextBox();
            this.ListDGV = new System.Windows.Forms.DataGridView();
            this.mID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Living_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // byPhone_rdb
            // 
            this.byPhone_rdb.AutoSize = true;
            this.byPhone_rdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byPhone_rdb.ForeColor = System.Drawing.Color.White;
            this.byPhone_rdb.Location = new System.Drawing.Point(509, 42);
            this.byPhone_rdb.Name = "byPhone_rdb";
            this.byPhone_rdb.Size = new System.Drawing.Size(92, 20);
            this.byPhone_rdb.TabIndex = 15;
            this.byPhone_rdb.TabStop = true;
            this.byPhone_rdb.Text = "By Phone";
            this.byPhone_rdb.UseVisualStyleBackColor = true;
            // 
            // byName_rdb
            // 
            this.byName_rdb.AutoSize = true;
            this.byName_rdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byName_rdb.ForeColor = System.Drawing.Color.White;
            this.byName_rdb.Location = new System.Drawing.Point(340, 42);
            this.byName_rdb.Name = "byName_rdb";
            this.byName_rdb.Size = new System.Drawing.Size(89, 20);
            this.byName_rdb.TabIndex = 14;
            this.byName_rdb.TabStop = true;
            this.byName_rdb.Text = "By Name";
            this.byName_rdb.UseVisualStyleBackColor = true;
            // 
            // valueTbox
            // 
            this.valueTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTbox.Location = new System.Drawing.Point(59, 42);
            this.valueTbox.Name = "valueTbox";
            this.valueTbox.Size = new System.Drawing.Size(227, 22);
            this.valueTbox.TabIndex = 13;
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
            this.Phone});
            this.ListDGV.Location = new System.Drawing.Point(37, 99);
            this.ListDGV.Name = "ListDGV";
            this.ListDGV.ReadOnly = true;
            this.ListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListDGV.Size = new System.Drawing.Size(590, 493);
            this.ListDGV.TabIndex = 12;
            this.ListDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDGV_CellContentDoubleClick);
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
            this.Living_Area.HeaderText = "Age";
            this.Living_Area.Name = "Living_Area";
            this.Living_Area.ReadOnly = true;
            this.Living_Area.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // MemberList4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(661, 649);
            this.Controls.Add(this.byPhone_rdb);
            this.Controls.Add(this.byName_rdb);
            this.Controls.Add(this.valueTbox);
            this.Controls.Add(this.ListDGV);
            this.Name = "MemberList4";
            this.Text = "MemberList4";
            this.Load += new System.EventHandler(this.MemberList4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton byPhone_rdb;
        private System.Windows.Forms.RadioButton byName_rdb;
        private System.Windows.Forms.TextBox valueTbox;
        private System.Windows.Forms.DataGridView ListDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Living_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}