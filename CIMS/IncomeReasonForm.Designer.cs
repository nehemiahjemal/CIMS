namespace CIMS
{
    partial class IncomeReasonForm
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
            System.Windows.Forms.Label incomeSource_nameLabel;
            this.incomeSource_nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            incomeSource_nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incomeSource_nameLabel
            // 
            incomeSource_nameLabel.AutoSize = true;
            incomeSource_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            incomeSource_nameLabel.ForeColor = System.Drawing.Color.White;
            incomeSource_nameLabel.Location = new System.Drawing.Point(25, 59);
            incomeSource_nameLabel.Name = "incomeSource_nameLabel";
            incomeSource_nameLabel.Size = new System.Drawing.Size(120, 16);
            incomeSource_nameLabel.TabIndex = 190;
            incomeSource_nameLabel.Text = "Income Reason:";
            // 
            // incomeSource_nameTextBox
            // 
            this.incomeSource_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeSource_nameTextBox.Location = new System.Drawing.Point(161, 59);
            this.incomeSource_nameTextBox.Name = "incomeSource_nameTextBox";
            this.incomeSource_nameTextBox.Size = new System.Drawing.Size(271, 22);
            this.incomeSource_nameTextBox.TabIndex = 191;
            this.incomeSource_nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.incomeSource_nameTextBox_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(109, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 34);
            this.button1.TabIndex = 192;
            this.button1.Text = "Add Income Reason";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IncomeReasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(462, 177);
            this.Controls.Add(this.button1);
            this.Controls.Add(incomeSource_nameLabel);
            this.Controls.Add(this.incomeSource_nameTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(478, 216);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(478, 216);
            this.Name = "IncomeReasonForm";
            this.Text = "IncomeReasonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox incomeSource_nameTextBox;
        private System.Windows.Forms.Button button1;
    }
}