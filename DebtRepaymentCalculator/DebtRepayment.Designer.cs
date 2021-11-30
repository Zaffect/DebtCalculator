namespace DebtRepaymentCalculator
{
    partial class DebtRepayment
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
            this.label2 = new System.Windows.Forms.Label();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.enterDetailsButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.minPaymentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.monthlyPaymentTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalDebtLabel = new System.Windows.Forms.Label();
            this.averageYearlyInterestLabel = new System.Windows.Forms.Label();
            this.averageMonthlyInterestLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "What will your monthly payment be?:";
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Location = new System.Drawing.Point(269, 423);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(125, 464);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(162, 23);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate Repayment Time";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(171, 493);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // enterDetailsButton
            // 
            this.enterDetailsButton.Location = new System.Drawing.Point(146, 134);
            this.enterDetailsButton.Name = "enterDetailsButton";
            this.enterDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.enterDetailsButton.TabIndex = 12;
            this.enterDetailsButton.Text = "Enter Details";
            this.enterDetailsButton.UseVisualStyleBackColor = true;
            this.enterDetailsButton.Click += new System.EventHandler(this.enterDetailsButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Your total minimum monthly payment is:";
            // 
            // minPaymentLabel
            // 
            this.minPaymentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minPaymentLabel.Location = new System.Drawing.Point(244, 129);
            this.minPaymentLabel.Name = "minPaymentLabel";
            this.minPaymentLabel.Size = new System.Drawing.Size(100, 23);
            this.minPaymentLabel.TabIndex = 14;
            this.minPaymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "What is the principal debt?:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "What is the yearly interest rate as a percent?:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "What is the minimum monthly payment?:";
            // 
            // principalTextBox
            // 
            this.principalTextBox.Location = new System.Drawing.Point(244, 32);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(100, 20);
            this.principalTextBox.TabIndex = 18;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(244, 64);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.interestRateTextBox.TabIndex = 19;
            // 
            // monthlyPaymentTextBox
            // 
            this.monthlyPaymentTextBox.Location = new System.Drawing.Point(244, 95);
            this.monthlyPaymentTextBox.Name = "monthlyPaymentTextBox";
            this.monthlyPaymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthlyPaymentTextBox.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.monthlyPaymentTextBox);
            this.groupBox1.Controls.Add(this.interestRateTextBox);
            this.groupBox1.Controls.Add(this.enterDetailsButton);
            this.groupBox1.Controls.Add(this.principalTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 178);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Multiple Debts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Monthly payment must be greater than or equal to total minimum monthly payment.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Your total principal debt is:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Your average yearly interest rate is:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Your average monthly interest rate is:";
            // 
            // totalDebtLabel
            // 
            this.totalDebtLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDebtLabel.Location = new System.Drawing.Point(244, 26);
            this.totalDebtLabel.Name = "totalDebtLabel";
            this.totalDebtLabel.Size = new System.Drawing.Size(100, 23);
            this.totalDebtLabel.TabIndex = 26;
            this.totalDebtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageYearlyInterestLabel
            // 
            this.averageYearlyInterestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageYearlyInterestLabel.Location = new System.Drawing.Point(244, 60);
            this.averageYearlyInterestLabel.Name = "averageYearlyInterestLabel";
            this.averageYearlyInterestLabel.Size = new System.Drawing.Size(100, 23);
            this.averageYearlyInterestLabel.TabIndex = 27;
            this.averageYearlyInterestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageMonthlyInterestLabel
            // 
            this.averageMonthlyInterestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageMonthlyInterestLabel.Location = new System.Drawing.Point(244, 94);
            this.averageMonthlyInterestLabel.Name = "averageMonthlyInterestLabel";
            this.averageMonthlyInterestLabel.Size = new System.Drawing.Size(100, 23);
            this.averageMonthlyInterestLabel.TabIndex = 28;
            this.averageMonthlyInterestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalDebtLabel);
            this.groupBox2.Controls.Add(this.averageMonthlyInterestLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.averageYearlyInterestLabel);
            this.groupBox2.Controls.Add(this.minPaymentLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(25, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 176);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Debt Details";
            // 
            // DebtRepayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.label2);
            this.Name = "DebtRepayment";
            this.Text = "Debt Repayment Calculator - Zak Tedder";
            this.Load += new System.EventHandler(this.DebtRepayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button enterDetailsButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label minPaymentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox monthlyPaymentTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalDebtLabel;
        private System.Windows.Forms.Label averageYearlyInterestLabel;
        private System.Windows.Forms.Label averageMonthlyInterestLabel;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

