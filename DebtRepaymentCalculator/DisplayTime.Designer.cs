namespace DebtRepaymentCalculator
{
    partial class DisplayTime
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
            this.closeButton = new System.Windows.Forms.Button();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(119, 190);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthLabel.Location = new System.Drawing.Point(173, 138);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(38, 23);
            this.monthLabel.TabIndex = 7;
            this.monthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearLabel
            // 
            this.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearLabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.yearLabel.Location = new System.Drawing.Point(64, 138);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(38, 23);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "You will pay off your current debt in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "year(s) and";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "This calculator prioritizes payments to the highest interest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "rate with the lowest balance first, as this has been shown";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "to be an effective way to payoff debt while saving the";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "most amount of money.";
            // 
            // DisplayTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 235);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.closeButton);
            this.Name = "DisplayTime";
            this.Text = "Repayment Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Label monthLabel;
        public System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}