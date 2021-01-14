namespace CIMS
{
    partial class IncomeForm
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
            System.Windows.Forms.Label income_idLabel;
            System.Windows.Forms.Label income_reasonLabel;
            System.Windows.Forms.Label income_byLabel;
            System.Windows.Forms.Label income_DateLabel;
            System.Windows.Forms.Label income_ofYearLabel;
            System.Windows.Forms.Label income_ofMonthLabel;
            System.Windows.Forms.Label income_receivedByLabel;
            System.Windows.Forms.Label income_valueLabel;
            System.Windows.Forms.Label income_ReceitNoLabel;
            System.Windows.Forms.Label income_remarkLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.noOfInc = new System.Windows.Forms.Label();
            this.TotInc = new System.Windows.Forms.Label();
            this.incomeDatepicker = new System.Windows.Forms.DateTimePicker();
            this.incomeDGV = new System.Windows.Forms.DataGridView();
            this.IncNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.incomeSourceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.churchDBDataSet = new CIMS.ChurchDBDataSet();
            this.Income_By = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.memberBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Income_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Income_received_by = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.memberBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.IncomeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.income_receivedByComboBox = new System.Windows.Forms.ComboBox();
            this.memberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.income_idTextBox = new System.Windows.Forms.TextBox();
            this.income_reasonComboBox = new System.Windows.Forms.ComboBox();
            this.incomeSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.income_byComboBox = new System.Windows.Forms.ComboBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.income_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.income_ofYearComboBox = new System.Windows.Forms.ComboBox();
            this.income_ofMonthComboBox = new System.Windows.Forms.ComboBox();
            this.income_valueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.income_ReceitNoTextBox = new System.Windows.Forms.TextBox();
            this.income_remarkTextBox = new System.Windows.Forms.TextBox();
            this.incomeSourceTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.IncomeSourceTableAdapter();
            this.memberTableAdapter = new CIMS.ChurchDBDataSetTableAdapters.MemberTableAdapter();
            this.churchDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            income_idLabel = new System.Windows.Forms.Label();
            income_reasonLabel = new System.Windows.Forms.Label();
            income_byLabel = new System.Windows.Forms.Label();
            income_DateLabel = new System.Windows.Forms.Label();
            income_ofYearLabel = new System.Windows.Forms.Label();
            income_ofMonthLabel = new System.Windows.Forms.Label();
            income_receivedByLabel = new System.Windows.Forms.Label();
            income_valueLabel = new System.Windows.Forms.Label();
            income_ReceitNoLabel = new System.Windows.Forms.Label();
            income_remarkLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeSourceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeSourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.income_valueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // income_idLabel
            // 
            income_idLabel.AutoSize = true;
            income_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            income_idLabel.ForeColor = System.Drawing.Color.White;
            income_idLabel.Location = new System.Drawing.Point(20, 115);
            income_idLabel.Name = "income_idLabel";
            income_idLabel.Size = new System.Drawing.Size(92, 20);
            income_idLabel.TabIndex = 23;
            income_idLabel.Text = "Income id:";
            // 
            // income_reasonLabel
            // 
            income_reasonLabel.AutoSize = true;
            income_reasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            income_reasonLabel.ForeColor = System.Drawing.Color.White;
            income_reasonLabel.Location = new System.Drawing.Point(20, 157);
            income_reasonLabel.Name = "income_reasonLabel";
            income_reasonLabel.Size = new System.Drawing.Size(133, 20);
            income_reasonLabel.TabIndex = 25;
            income_reasonLabel.Text = "Income reason:";
            // 
            // income_byLabel
            // 
            income_byLabel.AutoSize = true;
            income_byLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            income_byLabel.ForeColor = System.Drawing.Color.White;
            income_byLabel.Location = new System.Drawing.Point(20, 199);
            income_byLabel.Name = "income_byLabel";
            income_byLabel.Size = new System.Drawing.Size(96, 20);
            income_byLabel.TabIndex = 27;
            income_byLabel.Text = "Income by:";
            // 
            // income_DateLabel
            // 
            income_DateLabel.AutoSize = true;
            income_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            income_DateLabel.ForeColor = System.Drawing.Color.White;
            income_DateLabel.Location = new System.Drawing.Point(20, 241);
            income_DateLabel.Name = "income_DateLabel";
            income_DateLabel.Size = new System.Drawing.Size(117, 20);
            income_DateLabel.TabIndex = 29;
            income_DateLabel.Text = "Income Date:";
            // 
            // income_ofYearLabel
            // 
            income_ofYearLabel.AutoSize = true;
            income_ofYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            income_ofYearLabel.ForeColor = System.Drawing.Color.White;
            income_ofYearLabel.Location = new System.Drawing.Point(20, 283);
            income_ofYearLabel.Name = "income_ofYearLabel";
            income_ofYearLabel.Size = new System.Drawing.Size(137, 20);
            income_ofYearLabel.TabIndex = 31;
            income_ofYearLabel.Text = "Income of Year:";
            // 
            // income_ofMonthLabel
            // 
            income_ofMonthLabel.AutoSize = true;
            income_ofMonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            income_ofMonthLabel.ForeColor = System.Drawing.Color.White;
            income_ofMonthLabel.Location = new System.Drawing.Point(20, 325);
            income_ofMonthLabel.Name = "income_ofMonthLabel";
            income_ofMonthLabel.Size = new System.Drawing.Size(149, 20);
            income_ofMonthLabel.TabIndex = 33;
            income_ofMonthLabel.Text = "Income of Month:";
            // 
            // income_receivedByLabel
            // 
            income_receivedByLabel.AutoSize = true;
            income_receivedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            income_receivedByLabel.ForeColor = System.Drawing.Color.White;
            income_receivedByLabel.Location = new System.Drawing.Point(20, 370);
            income_receivedByLabel.Name = "income_receivedByLabel";
            income_receivedByLabel.Size = new System.Drawing.Size(170, 20);
            income_receivedByLabel.TabIndex = 37;
            income_receivedByLabel.Text = "Income received By:";
            // 
            // income_valueLabel
            // 
            income_valueLabel.AutoSize = true;
            income_valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            income_valueLabel.ForeColor = System.Drawing.Color.White;
            income_valueLabel.Location = new System.Drawing.Point(20, 412);
            income_valueLabel.Name = "income_valueLabel";
            income_valueLabel.Size = new System.Drawing.Size(120, 20);
            income_valueLabel.TabIndex = 38;
            income_valueLabel.Text = "Income value:";
            // 
            // income_ReceitNoLabel
            // 
            income_ReceitNoLabel.AutoSize = true;
            income_ReceitNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            income_ReceitNoLabel.ForeColor = System.Drawing.Color.White;
            income_ReceitNoLabel.Location = new System.Drawing.Point(20, 454);
            income_ReceitNoLabel.Name = "income_ReceitNoLabel";
            income_ReceitNoLabel.Size = new System.Drawing.Size(157, 20);
            income_ReceitNoLabel.TabIndex = 40;
            income_ReceitNoLabel.Text = "Income Receit No:";
            // 
            // income_remarkLabel
            // 
            income_remarkLabel.AutoSize = true;
            income_remarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            income_remarkLabel.ForeColor = System.Drawing.Color.White;
            income_remarkLabel.Location = new System.Drawing.Point(20, 496);
            income_remarkLabel.Name = "income_remarkLabel";
            income_remarkLabel.Size = new System.Drawing.Size(133, 20);
            income_remarkLabel.TabIndex = 42;
            income_remarkLabel.Text = "Income remark:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 88);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1251, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income Record";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::CIMS.Properties.Resources.icons8_new_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(25, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Image = global::CIMS.Properties.Resources.sav1;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(195, 16);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(116, 51);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Save";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.noOfInc);
            this.panel2.Controls.Add(this.TotInc);
            this.panel2.Controls.Add(this.incomeDatepicker);
            this.panel2.Controls.Add(this.incomeDGV);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 576);
            this.panel2.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1115, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 33);
            this.button5.TabIndex = 47;
            this.button5.Text = "Print List";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // noOfInc
            // 
            this.noOfInc.AutoSize = true;
            this.noOfInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfInc.Location = new System.Drawing.Point(746, 24);
            this.noOfInc.Name = "noOfInc";
            this.noOfInc.Size = new System.Drawing.Size(95, 16);
            this.noOfInc.TabIndex = 5;
            this.noOfInc.Text = "No Of Income: ";
            this.noOfInc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotInc
            // 
            this.TotInc.AutoSize = true;
            this.TotInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotInc.Location = new System.Drawing.Point(921, 24);
            this.TotInc.Name = "TotInc";
            this.TotInc.Size = new System.Drawing.Size(92, 16);
            this.TotInc.TabIndex = 4;
            this.TotInc.Text = "Total Income: ";
            this.TotInc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incomeDatepicker
            // 
            this.incomeDatepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.incomeDatepicker.Location = new System.Drawing.Point(520, 16);
            this.incomeDatepicker.Name = "incomeDatepicker";
            this.incomeDatepicker.Size = new System.Drawing.Size(200, 26);
            this.incomeDatepicker.TabIndex = 3;
            this.incomeDatepicker.ValueChanged += new System.EventHandler(this.incomeDatepicker_ValueChanged);
            // 
            // incomeDGV
            // 
            this.incomeDGV.AllowUserToAddRows = false;
          //  dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
         //   dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         //   dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
         //   dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
          //  dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.incomeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.incomeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IncNo,
            this.Reason,
            this.Income_By,
            this.Income_Value,
            this.ofYear,
            this.ofMonth,
            this.Income_received_by,
            this.IncomeDate,
            this.receiptNo,
            this.remark});
            this.incomeDGV.Location = new System.Drawing.Point(510, 59);
            this.incomeDGV.Name = "incomeDGV";
            this.incomeDGV.ReadOnly = true;
            this.incomeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.incomeDGV.Size = new System.Drawing.Size(698, 508);
            this.incomeDGV.TabIndex = 2;
            this.incomeDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.incomeDGV_CellClick);
            this.incomeDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.incomeDGV_DataError);
            // 
            // IncNo
            // 
            this.IncNo.HeaderText = "IncNo";
            this.IncNo.Name = "IncNo";
            this.IncNo.ReadOnly = true;
            // 
            // Reason
            // 
            this.Reason.DataSource = this.incomeSourceBindingSource1;
            this.Reason.DisplayMember = "IncomeSource_name";
            this.Reason.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            this.Reason.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Reason.ValueMember = "IncomeSource_id";
            // 
            // incomeSourceBindingSource1
            // 
            this.incomeSourceBindingSource1.DataMember = "IncomeSource";
            this.incomeSourceBindingSource1.DataSource = this.churchDBDataSet;
            // 
            // churchDBDataSet
            // 
            this.churchDBDataSet.DataSetName = "ChurchDBDataSet";
            this.churchDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Income_By
            // 
            this.Income_By.DataSource = this.memberBindingSource2;
            this.Income_By.DisplayMember = "Member_name";
            this.Income_By.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Income_By.HeaderText = "Income By";
            this.Income_By.Name = "Income_By";
            this.Income_By.ReadOnly = true;
            this.Income_By.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Income_By.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Income_By.ValueMember = "Member_id";
            // 
            // memberBindingSource2
            // 
            this.memberBindingSource2.DataMember = "Member";
            this.memberBindingSource2.DataSource = this.churchDBDataSet;
            // 
            // Income_Value
            // 
            this.Income_Value.HeaderText = "Income Value";
            this.Income_Value.Name = "Income_Value";
            this.Income_Value.ReadOnly = true;
            // 
            // ofYear
            // 
            this.ofYear.HeaderText = "Of Year";
            this.ofYear.Name = "ofYear";
            this.ofYear.ReadOnly = true;
            // 
            // ofMonth
            // 
            this.ofMonth.HeaderText = "of Month";
            this.ofMonth.Name = "ofMonth";
            this.ofMonth.ReadOnly = true;
            // 
            // Income_received_by
            // 
            this.Income_received_by.DataSource = this.memberBindingSource3;
            this.Income_received_by.DisplayMember = "Member_name";
            this.Income_received_by.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Income_received_by.HeaderText = "Received By";
            this.Income_received_by.Name = "Income_received_by";
            this.Income_received_by.ReadOnly = true;
            this.Income_received_by.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Income_received_by.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Income_received_by.ValueMember = "Member_id";
            // 
            // memberBindingSource3
            // 
            this.memberBindingSource3.DataMember = "Member";
            this.memberBindingSource3.DataSource = this.churchDBDataSet;
            // 
            // IncomeDate
            // 
            this.IncomeDate.HeaderText = "Income Date";
            this.IncomeDate.Name = "IncomeDate";
            this.IncomeDate.ReadOnly = true;
            this.IncomeDate.Visible = false;
            // 
            // receiptNo
            // 
            this.receiptNo.HeaderText = "receipt No";
            this.receiptNo.Name = "receiptNo";
            this.receiptNo.ReadOnly = true;
            this.receiptNo.Visible = false;
            // 
            // remark
            // 
            this.remark.HeaderText = "remark";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.income_receivedByComboBox);
            this.panel3.Controls.Add(income_idLabel);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.income_idTextBox);
            this.panel3.Controls.Add(this.addBtn);
            this.panel3.Controls.Add(income_reasonLabel);
            this.panel3.Controls.Add(this.income_reasonComboBox);
            this.panel3.Controls.Add(income_byLabel);
            this.panel3.Controls.Add(this.income_byComboBox);
            this.panel3.Controls.Add(income_DateLabel);
            this.panel3.Controls.Add(this.income_DateDateTimePicker);
            this.panel3.Controls.Add(income_ofYearLabel);
            this.panel3.Controls.Add(this.income_ofYearComboBox);
            this.panel3.Controls.Add(income_ofMonthLabel);
            this.panel3.Controls.Add(this.income_ofMonthComboBox);
            this.panel3.Controls.Add(income_receivedByLabel);
            this.panel3.Controls.Add(income_valueLabel);
            this.panel3.Controls.Add(this.income_valueNumericUpDown);
            this.panel3.Controls.Add(income_ReceitNoLabel);
            this.panel3.Controls.Add(this.income_ReceitNoTextBox);
            this.panel3.Controls.Add(income_remarkLabel);
            this.panel3.Controls.Add(this.income_remarkTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 576);
            this.panel3.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Image = global::CIMS.Properties.Resources.icons8_search_bar_50;
            this.button6.Location = new System.Drawing.Point(407, 363);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 36);
            this.button6.TabIndex = 106;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Image = global::CIMS.Properties.Resources.icons8_search_bar_50;
            this.button7.Location = new System.Drawing.Point(411, 189);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 36);
            this.button7.TabIndex = 105;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(342, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 51);
            this.button4.TabIndex = 46;
            this.button4.Text = "Void";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(408, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 35);
            this.button3.TabIndex = 45;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // income_receivedByComboBox
            // 
            this.income_receivedByComboBox.DataSource = this.memberBindingSource1;
            this.income_receivedByComboBox.DisplayMember = "Member_name";
            this.income_receivedByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.income_receivedByComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.income_receivedByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_receivedByComboBox.FormattingEnabled = true;
            this.income_receivedByComboBox.Location = new System.Drawing.Point(203, 370);
            this.income_receivedByComboBox.Name = "income_receivedByComboBox";
            this.income_receivedByComboBox.Size = new System.Drawing.Size(196, 24);
            this.income_receivedByComboBox.TabIndex = 44;
            this.income_receivedByComboBox.ValueMember = "Member_id";
            // 
            // memberBindingSource1
            // 
            this.memberBindingSource1.DataMember = "Member";
            this.memberBindingSource1.DataSource = this.churchDBDataSet;
            // 
            // income_idTextBox
            // 
            this.income_idTextBox.Enabled = false;
            this.income_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_idTextBox.Location = new System.Drawing.Point(202, 111);
            this.income_idTextBox.Name = "income_idTextBox";
            this.income_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.income_idTextBox.TabIndex = 24;
            // 
            // income_reasonComboBox
            // 
            this.income_reasonComboBox.DataSource = this.incomeSourceBindingSource;
            this.income_reasonComboBox.DisplayMember = "IncomeSource_name";
            this.income_reasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.income_reasonComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.income_reasonComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_reasonComboBox.FormattingEnabled = true;
            this.income_reasonComboBox.Location = new System.Drawing.Point(202, 153);
            this.income_reasonComboBox.Name = "income_reasonComboBox";
            this.income_reasonComboBox.Size = new System.Drawing.Size(200, 24);
            this.income_reasonComboBox.TabIndex = 26;
            this.income_reasonComboBox.ValueMember = "IncomeSource_id";
            this.income_reasonComboBox.DropDown += new System.EventHandler(this.income_reasonComboBox_DropDown);
            // 
            // incomeSourceBindingSource
            // 
            this.incomeSourceBindingSource.DataMember = "IncomeSource";
            this.incomeSourceBindingSource.DataSource = this.churchDBDataSet;
            // 
            // income_byComboBox
            // 
            this.income_byComboBox.DataSource = this.memberBindingSource;
            this.income_byComboBox.DisplayMember = "Member_name";
            this.income_byComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.income_byComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.income_byComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_byComboBox.FormattingEnabled = true;
            this.income_byComboBox.Location = new System.Drawing.Point(202, 196);
            this.income_byComboBox.Name = "income_byComboBox";
            this.income_byComboBox.Size = new System.Drawing.Size(200, 24);
            this.income_byComboBox.TabIndex = 28;
            this.income_byComboBox.ValueMember = "Member_id";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.churchDBDataSet;
            // 
            // income_DateDateTimePicker
            // 
            this.income_DateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.income_DateDateTimePicker.Location = new System.Drawing.Point(202, 239);
            this.income_DateDateTimePicker.Name = "income_DateDateTimePicker";
            this.income_DateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.income_DateDateTimePicker.TabIndex = 30;
            // 
            // income_ofYearComboBox
            // 
            this.income_ofYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.income_ofYearComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.income_ofYearComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_ofYearComboBox.FormattingEnabled = true;
            this.income_ofYearComboBox.Items.AddRange(new object[] {
            "",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070"});
            this.income_ofYearComboBox.Location = new System.Drawing.Point(202, 281);
            this.income_ofYearComboBox.Name = "income_ofYearComboBox";
            this.income_ofYearComboBox.Size = new System.Drawing.Size(200, 24);
            this.income_ofYearComboBox.TabIndex = 32;
            // 
            // income_ofMonthComboBox
            // 
            this.income_ofMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.income_ofMonthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.income_ofMonthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_ofMonthComboBox.FormattingEnabled = true;
            this.income_ofMonthComboBox.Items.AddRange(new object[] {
            "",
            "Meskerem",
            "Tikimt",
            "Hidar",
            "Tahisas",
            "Tir",
            "Yekatit",
            "Miazia",
            "Ginbot",
            "Sene",
            "Hamle",
            "Nehasie"});
            this.income_ofMonthComboBox.Location = new System.Drawing.Point(202, 324);
            this.income_ofMonthComboBox.Name = "income_ofMonthComboBox";
            this.income_ofMonthComboBox.Size = new System.Drawing.Size(200, 24);
            this.income_ofMonthComboBox.TabIndex = 34;
            // 
            // income_valueNumericUpDown
            // 
            this.income_valueNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_valueNumericUpDown.Location = new System.Drawing.Point(202, 413);
            this.income_valueNumericUpDown.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.income_valueNumericUpDown.Name = "income_valueNumericUpDown";
            this.income_valueNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.income_valueNumericUpDown.TabIndex = 39;
            // 
            // income_ReceitNoTextBox
            // 
            this.income_ReceitNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_ReceitNoTextBox.Location = new System.Drawing.Point(202, 455);
            this.income_ReceitNoTextBox.Name = "income_ReceitNoTextBox";
            this.income_ReceitNoTextBox.Size = new System.Drawing.Size(200, 22);
            this.income_ReceitNoTextBox.TabIndex = 41;
            // 
            // income_remarkTextBox
            // 
            this.income_remarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_remarkTextBox.Location = new System.Drawing.Point(202, 497);
            this.income_remarkTextBox.Name = "income_remarkTextBox";
            this.income_remarkTextBox.Size = new System.Drawing.Size(200, 22);
            this.income_remarkTextBox.TabIndex = 43;
            // 
            // incomeSourceTableAdapter
            // 
            this.incomeSourceTableAdapter.ClearBeforeFill = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // churchDBDataSetBindingSource
            // 
            this.churchDBDataSetBindingSource.DataSource = this.churchDBDataSet;
            this.churchDBDataSetBindingSource.Position = 0;
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 664);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeSourceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeSourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.income_valueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox income_receivedByComboBox;
        private System.Windows.Forms.TextBox income_idTextBox;
        private System.Windows.Forms.ComboBox income_reasonComboBox;
        private System.Windows.Forms.ComboBox income_byComboBox;
        private System.Windows.Forms.DateTimePicker income_DateDateTimePicker;
        private System.Windows.Forms.ComboBox income_ofYearComboBox;
        private System.Windows.Forms.ComboBox income_ofMonthComboBox;
        private System.Windows.Forms.NumericUpDown income_valueNumericUpDown;
        private System.Windows.Forms.TextBox income_ReceitNoTextBox;
        private System.Windows.Forms.TextBox income_remarkTextBox;
        private System.Windows.Forms.DataGridView incomeDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addBtn;
        private ChurchDBDataSet churchDBDataSet;
        private System.Windows.Forms.BindingSource incomeSourceBindingSource;
        private ChurchDBDataSetTableAdapters.IncomeSourceTableAdapter incomeSourceTableAdapter;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private ChurchDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.BindingSource memberBindingSource1;
        private System.Windows.Forms.BindingSource churchDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource incomeSourceBindingSource1;
        private System.Windows.Forms.BindingSource memberBindingSource2;
        private System.Windows.Forms.BindingSource memberBindingSource3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker incomeDatepicker;
        private System.Windows.Forms.Label noOfInc;
        private System.Windows.Forms.Label TotInc;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Reason;
        private System.Windows.Forms.DataGridViewComboBoxColumn Income_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofMonth;
        private System.Windows.Forms.DataGridViewComboBoxColumn Income_received_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}