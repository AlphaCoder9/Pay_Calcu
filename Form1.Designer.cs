namespace First
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblPay = new Label();
            btnComputePay = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtHoursWorked = new TextBox();
            txtPayRate = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 96);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 124);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 0;
            label3.Text = "Hours-Worked";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 152);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 0;
            label4.Text = "Pay-Rate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 69);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 0;
            label6.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(114, 248);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 0;
            label7.Text = "Pay";
            // 
            // lblPay
            // 
            lblPay.AutoSize = true;
            lblPay.Location = new Point(266, 248);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(19, 15);
            lblPay.TabIndex = 0;
            lblPay.Text = "$$";
            // 
            // btnComputePay
            // 
            btnComputePay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnComputePay.ForeColor = Color.Blue;
            btnComputePay.Location = new Point(204, 183);
            btnComputePay.Name = "btnComputePay";
            btnComputePay.Size = new Size(100, 38);
            btnComputePay.TabIndex = 1;
            btnComputePay.Text = "Compute Pay";
            btnComputePay.UseVisualStyleBackColor = true;
            btnComputePay.Click += btnComputePay_Click_1;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.InactiveCaption;
            txtFirstName.Location = new Point(204, 61);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.InactiveCaption;
            txtLastName.Location = new Point(204, 88);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.BackColor = SystemColors.InactiveCaption;
            txtHoursWorked.Location = new Point(204, 116);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(100, 23);
            txtHoursWorked.TabIndex = 2;
            // 
            // txtPayRate
            // 
            txtPayRate.BackColor = SystemColors.InactiveCaption;
            txtPayRate.Location = new Point(204, 144);
            txtPayRate.Name = "txtPayRate";
            txtPayRate.Size = new Size(100, 23);
            txtPayRate.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(672, 375);
            Controls.Add(txtPayRate);
            Controls.Add(txtHoursWorked);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnComputePay);
            Controls.Add(lblPay);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            ForeColor = Color.YellowGreen;
            Name = "Form1";
            Text = "Pay Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label lblPay;
        private Button btnComputePay;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtHoursWorked;
        private TextBox txtPayRate;
    }
}