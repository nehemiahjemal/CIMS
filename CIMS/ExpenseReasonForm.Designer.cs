namespace CIMS
{
    partial class ExpenseReasonForm
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
            System.Windows.Forms.Label expenseReason_nameLabel;
            this.expenseReason_nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            expenseReason_nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // expenseReason_nameLabel
            // 
            expenseReason_nameLabel.AutoSize = true;
            expenseReason_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expenseReason_nameLabel.Location = new System.Drawing.Point(12, 45);
            expenseReason_nameLabel.Name = "expenseReason_nameLabel";
            expenseReason_nameLabel.Size = new System.Drawing.Size(186, 18);
            expenseReason_nameLabel.TabIndex = 189;
            expenseReason_nameLabel.Text = "Expense Reason name:";
            // 
            // expenseReason_nameTextBox
            // 
            this.expenseReason_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseReason_nameTextBox.Location = new System.Drawing.Point(204, 42);
            this.expenseReason_nameTextBox.Name = "expenseReason_nameTextBox";
            this.expenseReason_nameTextBox.Size = new System.Drawing.Size(259, 24);
            this.expenseReason_nameTextBox.TabIndex = 190;
            this.expenseReason_nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.expenseReason_nameTextBox_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 40);
            this.button1.TabIndex = 191;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExpenseReasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 155);
            this.Controls.Add(this.button1);
            this.Controls.Add(expenseReason_nameLabel);
            this.Controls.Add(this.expenseReason_nameTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(491, 194);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(491, 194);
            this.Name = "ExpenseReasonForm";
            this.Text = "ExpenseReasonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox expenseReason_nameTextBox;
        private System.Windows.Forms.Button button1;
    }
}