namespace FormsProject2
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFName = new System.Windows.Forms.TextBox();
            this.TxtEA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkSMS = new System.Windows.Forms.CheckBox();
            this.CheckReports = new System.Windows.Forms.CheckBox();
            this.CheckTransactions = new System.Windows.Forms.CheckBox();
            this.lblSMSmessage = new System.Windows.Forms.Label();
            this.lblReportsmessage = new System.Windows.Forms.Label();
            this.lblTransactionsmessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // TxtFName
            // 
            this.TxtFName.Location = new System.Drawing.Point(151, 25);
            this.TxtFName.Name = "TxtFName";
            this.TxtFName.Size = new System.Drawing.Size(261, 20);
            this.TxtFName.TabIndex = 1;
            // 
            // TxtEA
            // 
            this.TxtEA.Location = new System.Drawing.Point(151, 106);
            this.TxtEA.Name = "TxtEA";
            this.TxtEA.Size = new System.Drawing.Size(261, 20);
            this.TxtEA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email Address";
            // 
            // TxtLName
            // 
            this.TxtLName.Location = new System.Drawing.Point(151, 64);
            this.TxtLName.Name = "TxtLName";
            this.TxtLName.Size = new System.Drawing.Size(261, 20);
            this.TxtLName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(58, 156);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(354, 168);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Services";
            // 
            // checkSMS
            // 
            this.checkSMS.AutoSize = true;
            this.checkSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSMS.Location = new System.Drawing.Point(110, 198);
            this.checkSMS.Name = "checkSMS";
            this.checkSMS.Size = new System.Drawing.Size(52, 17);
            this.checkSMS.TabIndex = 7;
            this.checkSMS.Text = "SMS";
            this.checkSMS.UseVisualStyleBackColor = true;
            this.checkSMS.CheckedChanged += new System.EventHandler(this.checkSMS_CheckedChanged);
            // 
            // CheckReports
            // 
            this.CheckReports.AutoSize = true;
            this.CheckReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckReports.Location = new System.Drawing.Point(110, 242);
            this.CheckReports.Name = "CheckReports";
            this.CheckReports.Size = new System.Drawing.Size(70, 17);
            this.CheckReports.TabIndex = 8;
            this.CheckReports.Text = "Reports";
            this.CheckReports.UseVisualStyleBackColor = true;
            this.CheckReports.CheckedChanged += new System.EventHandler(this.CheckReports_CheckedChanged);
            // 
            // CheckTransactions
            // 
            this.CheckTransactions.AutoSize = true;
            this.CheckTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckTransactions.Location = new System.Drawing.Point(110, 283);
            this.CheckTransactions.Name = "CheckTransactions";
            this.CheckTransactions.Size = new System.Drawing.Size(99, 17);
            this.CheckTransactions.TabIndex = 9;
            this.CheckTransactions.Text = "Transactions";
            this.CheckTransactions.UseVisualStyleBackColor = true;
            this.CheckTransactions.CheckedChanged += new System.EventHandler(this.CheckTransactions_CheckedChanged);
            // 
            // lblSMSmessage
            // 
            this.lblSMSmessage.AutoSize = true;
            this.lblSMSmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMSmessage.Location = new System.Drawing.Point(271, 198);
            this.lblSMSmessage.Name = "lblSMSmessage";
            this.lblSMSmessage.Size = new System.Drawing.Size(41, 13);
            this.lblSMSmessage.TabIndex = 10;
            this.lblSMSmessage.Text = "label4";
            // 
            // lblReportsmessage
            // 
            this.lblReportsmessage.AutoSize = true;
            this.lblReportsmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsmessage.Location = new System.Drawing.Point(271, 243);
            this.lblReportsmessage.Name = "lblReportsmessage";
            this.lblReportsmessage.Size = new System.Drawing.Size(41, 13);
            this.lblReportsmessage.TabIndex = 11;
            this.lblReportsmessage.Text = "label5";
            // 
            // lblTransactionsmessage
            // 
            this.lblTransactionsmessage.AutoSize = true;
            this.lblTransactionsmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionsmessage.Location = new System.Drawing.Point(271, 287);
            this.lblTransactionsmessage.Name = "lblTransactionsmessage";
            this.lblTransactionsmessage.Size = new System.Drawing.Size(41, 13);
            this.lblTransactionsmessage.TabIndex = 12;
            this.lblTransactionsmessage.Text = "label6";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTransactionsmessage);
            this.Controls.Add(this.lblReportsmessage);
            this.Controls.Add(this.lblSMSmessage);
            this.Controls.Add(this.CheckTransactions);
            this.Controls.Add(this.CheckReports);
            this.Controls.Add(this.checkSMS);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TxtLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtEA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFName;
        private System.Windows.Forms.TextBox TxtEA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkSMS;
        private System.Windows.Forms.CheckBox CheckReports;
        private System.Windows.Forms.CheckBox CheckTransactions;
        private System.Windows.Forms.Label lblSMSmessage;
        private System.Windows.Forms.Label lblReportsmessage;
        private System.Windows.Forms.Label lblTransactionsmessage;
        private System.Windows.Forms.Button button1;
    }
}

