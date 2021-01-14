namespace CIMS
{
    partial class Expense_Form
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
            System.Windows.Forms.Label expense_idLabel;
            System.Windows.Forms.Label expense_reasonLabel;
            System.Windows.Forms.Label expense_detailLabel;
            System.Windows.Forms.Label expense_issueByLabel;
            System.Windows.Forms.Label expense_issueToLabel;
            System.Windows.Forms.Label expense_valueLabel;
            System.Windows.Forms.Label expense_dateLabel;
            System.Windows.Forms.Label expense_remarkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPicBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.totExpense = new System.Windows.Forms.Label();
            this.expNo = new System.Windows.Forms.Label();
            this.ExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.expenseDGV = new System.Windows.Forms.DataGridView();
            this.Expense_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expense_reason = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.expenseReasonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.churchDBDataSet = new CIMS.ChurchDBDataSet();
            this.Expense_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Issue_By = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.memberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Issue_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Issue_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expense_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.expense_idTextBox = new System.Windows.Forms.TextBox();
            this.expense_reasonComboBox = new System.Windows.Forms.ComboBox();
            this.expenseReasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expense_detailTextBox = new System.Windows.Forms.TextBox();
            this.expense_issueByComboBox = new System.Windows.Forms.ComboBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expense_issueToTextBox = new System.Windows.Forms.TextBox();
            this.expense_valueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.expense_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expense_remarkTextBox = new System.Windows.Forms.TextBox();
            this.expenseReasonTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.ExpenseReasonTableAdapter();
            this.memberTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.MemberTableAdapter();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            expense_idLabel = new System.Windows.Forms.Label();
            expense_reasonLabel = new System.Windows.Forms.Label();
            expense_detailLabel = new System.Windows.Forms.Label();
            expense_issueByLabel = new System.Windows.Forms.Label();
            expense_issueToLabel = new System.Windows.Forms.Label();
            expense_valueLabel = new System.Windows.Forms.Label();
            expense_dateLabel = new System.Windows.Forms.Label();
            expense_remarkLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPicBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseReasonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseReasonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expense_valueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // expense_idLabel
            // 
            expense_idLabel.AutoSize = true;
            expense_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expense_idLabel.ForeColor = System.Drawing.Color.White;
            expense_idLabel.Location = new System.Drawing.Point(21, 91);
            expense_idLabel.Name = "expense_idLabel";
            expense_idLabel.Size = new System.Drawing.Size(89, 16);
            expense_idLabel.TabIndex = 16;
            expense_idLabel.Text = "Expense id:";
            // 
            // expense_reasonLabel
            // 
            expense_reasonLabel.AutoSize = true;
            expense_reasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expense_reasonLabel.ForeColor = System.Drawing.Color.White;
            expense_reasonLabel.Location = new System.Drawing.Point(21, 133);
            expense_reasonLabel.Name = "expense_reasonLabel";
            expense_reasonLabel.Size = new System.Drawing.Size(124, 16);
            expense_reasonLabel.TabIndex = 18;
            expense_reasonLabel.Text = "Expense reason:";
            // 
            // expense_detailLabel
            // 
            expense_detailLabel.AutoSize = true;
            expense_detailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expense_detailLabel.ForeColor = System.Drawing.Color.White;
            expense_detailLabel.Location = new System.Drawing.Point(21, 176);
            expense_detailLabel.Name = "expense_detailLabel";
            expense_detailLabel.Size = new System.Drawing.Size(115, 16);
            expense_detailLabel.TabIndex = 20;
            expense_detailLabel.Text = "Expense detail:";
            // 
            // expense_issueByLabel
            // 
            expense_issueByLabel.AutoSize = true;
            expense_issueByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expense_issueByLabel.ForeColor = System.Drawing.Color.White;
            expense_issueByLabel.Location = new System.Drawing.Point(21, 218);
            expense_issueByLabel.Name = "expense_issueByLabel";
            expense_issueByLabel.Size = new System.Drawing.Size(135, 16);
            expense_issueByLabel.TabIndex = 22;
            expense_issueByLabel.Text = "Expense issue By:";
            // 
            // expense_issueToLabel
            // 
            expense_issueToLabel.AutoSize = true;
            expense_issueToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expense_issueToLabel.ForeColor = System.Drawing.Color.White;
            expense_issueToLabel.Location = new System.Drawing.Point(21, 261);
            expense_issueToLabel.Name = "expense_issueToLabel";
            expense_issueToLabel.Size = new System.Drawing.Size(136, 16);
            expense_issueToLabel.TabIndex = 24;
            expense_issueToLabel.Text = "Expense issue To:";
            // 
            // expense_valueLabel
            // 
            expense_valueLabel.AutoSize = true;
            expense_valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expense_valueLabel.ForeColor = System.Drawing.Color.White;
            expense_valueLabel.Location = new System.Drawing.Point(21, 300);
            expense_valueLabel.Name = "expense_valueLabel";
            expense_valueLabel.Size = new System.Drawing.Size(114, 16);
            expense_valueLabel.TabIndex = 26;
            expense_valueLabel.Text = "Expense value:";
            // 
            // expense_dateLabel
            // 
            expense_dateLabel.AutoSize = true;
            expense_dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expense_dateLabel.ForeColor = System.Drawing.Color.White;
            expense_dateLabel.Location = new System.Drawing.Point(21, 346);
            expense_dateLabel.Name = "expense_dateLabel";
            expense_dateLabel.Size = new System.Drawing.Size(107, 16);
            expense_dateLabel.TabIndex = 28;
            expense_dateLabel.Text = "Expense date:";
            // 
            // expense_remarkLabel
            // 
            expense_remarkLabel.AutoSize = true;
            expense_remarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expense_remarkLabel.ForeColor = System.Drawing.Color.White;
            expense_remarkLabel.Location = new System.Drawing.Point(21, 387);
            expense_remarkLabel.Name = "expense_remarkLabel";
            expense_remarkLabel.Size = new System.Drawing.Size(124, 16);
            expense_remarkLabel.TabIndex = 30;
            expense_remarkLabel.Text = "Expense remark:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.headerPicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 94);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1028, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense Record";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPicBox
            // 
            this.headerPicBox.Image = global::CIMS.Properties.Resources.Church_Header31;
            this.headerPicBox.Location = new System.Drawing.Point(127, 12);
            this.headerPicBox.Name = "headerPicBox";
            this.headerPicBox.Size = new System.Drawing.Size(702, 129);
            this.headerPicBox.TabIndex = 0;
            this.headerPicBox.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(118, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(224, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.totExpense);
            this.panel3.Controls.Add(this.expNo);
            this.panel3.Controls.Add(this.ExpenseDate);
            this.panel3.Controls.Add(this.expenseDGV);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 625);
            this.panel3.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SteelBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1076, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 33);
            this.button6.TabIndex = 34;
            this.button6.Text = "Print List";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // totExpense
            // 
            this.totExpense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totExpense.Location = new System.Drawing.Point(879, 17);
            this.totExpense.Name = "totExpense";
            this.totExpense.Size = new System.Drawing.Size(190, 28);
            this.totExpense.TabIndex = 5;
            // 
            // expNo
            // 
            this.expNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.expNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expNo.Location = new System.Drawing.Point(664, 17);
            this.expNo.Name = "expNo";
            this.expNo.Size = new System.Drawing.Size(197, 30);
            this.expNo.TabIndex = 4;
            // 
            // ExpenseDate
            // 
            this.ExpenseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpenseDate.Location = new System.Drawing.Point(458, 17);
            this.ExpenseDate.Name = "ExpenseDate";
            this.ExpenseDate.Size = new System.Drawing.Size(200, 26);
            this.ExpenseDate.TabIndex = 3;
            this.ExpenseDate.ValueChanged += new System.EventHandler(this.ExpenseDate_ValueChanged);
            // 
            // expenseDGV
            // 
            this.expenseDGV.AllowUserToAddRows = false;
            this.expenseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenseDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Expense_id,
            this.Expense_reason,
            this.Expense_Detail,
            this.Issue_By,
            this.Issue_to,
            this.Issue_value,
            this.Expense_date,
            this.remark});
            this.expenseDGV.Location = new System.Drawing.Point(458, 62);
            this.expenseDGV.Name = "expenseDGV";
            this.expenseDGV.ReadOnly = true;
            this.expenseDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expenseDGV.Size = new System.Drawing.Size(703, 571);
            this.expenseDGV.TabIndex = 2;
            this.expenseDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expenseDGV_CellClick);
            this.expenseDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.expenseDGV_DataError);
            // 
            // Expense_id
            // 
            this.Expense_id.HeaderText = "Expense Id";
            this.Expense_id.Name = "Expense_id";
            this.Expense_id.ReadOnly = true;
            // 
            // Expense_reason
            // 
            this.Expense_reason.DataSource = this.expenseReasonBindingSource1;
            this.Expense_reason.DisplayMember = "ExpenseReason_name";
            this.Expense_reason.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Expense_reason.HeaderText = "Expense reason";
            this.Expense_reason.Name = "Expense_reason";
            this.Expense_reason.ReadOnly = true;
            this.Expense_reason.ValueMember = "ExpenseReason_id";
            // 
            // expenseReasonBindingSource1
            // 
            this.expenseReasonBindingSource1.DataMember = "ExpenseReason";
            this.expenseReasonBindingSource1.DataSource = this.churchDBDataSet;
            // 
            // churchDBDataSet
            // 
            this.churchDBDataSet.DataSetName = "ChurchDBDataSet";
            this.churchDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Expense_Detail
            // 
            this.Expense_Detail.HeaderText = "Expense Detail";
            this.Expense_Detail.Name = "Expense_Detail";
            this.Expense_Detail.ReadOnly = true;
            this.Expense_Detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Expense_Detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Issue_By
            // 
            this.Issue_By.DataSource = this.memberBindingSource1;
            this.Issue_By.DisplayMember = "Member_name";
            this.Issue_By.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Issue_By.HeaderText = "Issue By";
            this.Issue_By.Name = "Issue_By";
            this.Issue_By.ReadOnly = true;
            this.Issue_By.ValueMember = "Member_id";
            // 
            // memberBindingSource1
            // 
            this.memberBindingSource1.DataMember = "Member";
            this.memberBindingSource1.DataSource = this.churchDBDataSet;
            // 
            // Issue_to
            // 
            this.Issue_to.HeaderText = "Issue To";
            this.Issue_to.Name = "Issue_to";
            this.Issue_to.ReadOnly = true;
            this.Issue_to.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Issue_to.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Issue_value
            // 
            this.Issue_value.HeaderText = "Issue Amount";
            this.Issue_value.Name = "Issue_value";
            this.Issue_value.ReadOnly = true;
            this.Issue_value.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Issue_value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Expense_date
            // 
            this.Expense_date.HeaderText = "Expense Date";
            this.Expense_date.Name = "Expense_date";
            this.Expense_date.ReadOnly = true;
            this.Expense_date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Expense_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Expense_date.Visible = false;
            // 
            // remark
            // 
            this.remark.HeaderText = "remark";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.remark.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(expense_idLabel);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.expense_idTextBox);
            this.panel2.Controls.Add(expense_reasonLabel);
            this.panel2.Controls.Add(this.expense_reasonComboBox);
            this.panel2.Controls.Add(expense_detailLabel);
            this.panel2.Controls.Add(this.expense_detailTextBox);
            this.panel2.Controls.Add(expense_issueByLabel);
            this.panel2.Controls.Add(this.expense_issueByComboBox);
            this.panel2.Controls.Add(expense_issueToLabel);
            this.panel2.Controls.Add(this.expense_issueToTextBox);
            this.panel2.Controls.Add(expense_valueLabel);
            this.panel2.Controls.Add(this.expense_valueNumericUpDown);
            this.panel2.Controls.Add(expense_dateLabel);
            this.panel2.Controls.Add(this.expense_dateDateTimePicker);
            this.panel2.Controls.Add(expense_remarkLabel);
            this.panel2.Controls.Add(this.expense_remarkTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 625);
            this.panel2.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SteelBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(12, 507);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(401, 38);
            this.button7.TabIndex = 34;
            this.button7.Text = "Print Attachment";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(329, 468);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 34);
            this.button5.TabIndex = 33;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expense Detail";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(373, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 35);
            this.button4.TabIndex = 32;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // expense_idTextBox
            // 
            this.expense_idTextBox.Enabled = false;
            this.expense_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_idTextBox.Location = new System.Drawing.Point(166, 88);
            this.expense_idTextBox.Name = "expense_idTextBox";
            this.expense_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.expense_idTextBox.TabIndex = 17;
            // 
            // expense_reasonComboBox
            // 
            this.expense_reasonComboBox.DataSource = this.expenseReasonBindingSource;
            this.expense_reasonComboBox.DisplayMember = "ExpenseReason_name";
            this.expense_reasonComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_reasonComboBox.FormattingEnabled = true;
            this.expense_reasonComboBox.Location = new System.Drawing.Point(166, 130);
            this.expense_reasonComboBox.Name = "expense_reasonComboBox";
            this.expense_reasonComboBox.Size = new System.Drawing.Size(200, 24);
            this.expense_reasonComboBox.TabIndex = 19;
            this.expense_reasonComboBox.ValueMember = "ExpenseReason_id";
            this.expense_reasonComboBox.DropDown += new System.EventHandler(this.expense_reasonComboBox_DropDown);
            // 
            // expenseReasonBindingSource
            // 
            this.expenseReasonBindingSource.DataMember = "ExpenseReason";
            this.expenseReasonBindingSource.DataSource = this.churchDBDataSet;
            // 
            // expense_detailTextBox
            // 
            this.expense_detailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_detailTextBox.Location = new System.Drawing.Point(166, 173);
            this.expense_detailTextBox.Name = "expense_detailTextBox";
            this.expense_detailTextBox.Size = new System.Drawing.Size(200, 22);
            this.expense_detailTextBox.TabIndex = 21;
            // 
            // expense_issueByComboBox
            // 
            this.expense_issueByComboBox.DataSource = this.memberBindingSource;
            this.expense_issueByComboBox.DisplayMember = "Member_name";
            this.expense_issueByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expense_issueByComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.expense_issueByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_issueByComboBox.FormattingEnabled = true;
            this.expense_issueByComboBox.Location = new System.Drawing.Point(166, 215);
            this.expense_issueByComboBox.Name = "expense_issueByComboBox";
            this.expense_issueByComboBox.Size = new System.Drawing.Size(200, 24);
            this.expense_issueByComboBox.TabIndex = 23;
            this.expense_issueByComboBox.ValueMember = "Member_id";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.churchDBDataSet;
            // 
            // expense_issueToTextBox
            // 
            this.expense_issueToTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_issueToTextBox.Location = new System.Drawing.Point(166, 258);
            this.expense_issueToTextBox.Name = "expense_issueToTextBox";
            this.expense_issueToTextBox.Size = new System.Drawing.Size(200, 22);
            this.expense_issueToTextBox.TabIndex = 25;
            // 
            // expense_valueNumericUpDown
            // 
            this.expense_valueNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_valueNumericUpDown.Location = new System.Drawing.Point(166, 300);
            this.expense_valueNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.expense_valueNumericUpDown.Name = "expense_valueNumericUpDown";
            this.expense_valueNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.expense_valueNumericUpDown.TabIndex = 27;
            // 
            // expense_dateDateTimePicker
            // 
            this.expense_dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expense_dateDateTimePicker.Location = new System.Drawing.Point(166, 342);
            this.expense_dateDateTimePicker.Name = "expense_dateDateTimePicker";
            this.expense_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.expense_dateDateTimePicker.TabIndex = 29;
            // 
            // expense_remarkTextBox
            // 
            this.expense_remarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_remarkTextBox.Location = new System.Drawing.Point(166, 384);
            this.expense_remarkTextBox.Name = "expense_remarkTextBox";
            this.expense_remarkTextBox.Size = new System.Drawing.Size(200, 22);
            this.expense_remarkTextBox.TabIndex = 31;
            // 
            // expenseReasonTableAdapter
            // 
            this.expenseReasonTableAdapter.ClearBeforeFill = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Expense_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 719);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Expense_Form";
            this.Text = "Expense";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Expense_Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerPicBox)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expenseDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseReasonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseReasonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expense_valueNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView expenseDGV;
        private System.Windows.Forms.TextBox expense_idTextBox;
        private System.Windows.Forms.ComboBox expense_reasonComboBox;
        private System.Windows.Forms.TextBox expense_detailTextBox;
        private System.Windows.Forms.ComboBox expense_issueByComboBox;
        private System.Windows.Forms.TextBox expense_issueToTextBox;
        private System.Windows.Forms.NumericUpDown expense_valueNumericUpDown;
        private System.Windows.Forms.DateTimePicker expense_dateDateTimePicker;
        private System.Windows.Forms.TextBox expense_remarkTextBox;
        private ChurchDBDataSet churchDBDataSet;
        private System.Windows.Forms.BindingSource expenseReasonBindingSource;
        private ChurchDBDataSetTableAdapters.ExpenseReasonTableAdapter expenseReasonTableAdapter;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private ChurchDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.BindingSource expenseReasonBindingSource1;
        private System.Windows.Forms.BindingSource memberBindingSource1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker ExpenseDate;
        private System.Windows.Forms.Label totExpense;
        private System.Windows.Forms.Label expNo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expense_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn Expense_reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expense_Detail;
        private System.Windows.Forms.DataGridViewComboBoxColumn Issue_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issue_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issue_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expense_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox headerPicBox;
    }
}