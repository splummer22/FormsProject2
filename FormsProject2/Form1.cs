using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject2
{
    public partial class Form1 : Form
    {
        string fname;
        string lname;
        string email;
        bool SMS;
        bool Reports;
        bool Transactions;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSMSmessage.Text = "";
            lblReportsmessage.Text = "";
            lblTransactionsmessage.Text = "";

            lblSMSmessage.ForeColor = System.Drawing.Color.Orange;
            lblReportsmessage.ForeColor = System.Drawing.Color.Purple;
            lblTransactionsmessage.ForeColor = System.Drawing.Color.Red;

        }

        private void checkSMS_CheckedChanged(object sender, EventArgs e)
        {
            if(checkSMS.Checked)
            {
                lblSMSmessage.Text = "Service Rates May Apply.";
            }
            else
            {
                lblSMSmessage.Text = "";
            }


        }

        private void CheckReports_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckReports.Checked)
            {
                lblReportsmessage.Text = "Service Rates May Apply.";
            }
            else
            {
                lblReportsmessage.Text = "";
            }
        }

        private void CheckTransactions_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTransactions.Checked)
            {
                lblTransactionsmessage.Text = "Service Rates May Apply.";
            }
            else
            {
                lblTransactionsmessage.Text = "";
            }
        }

        private void signup()
        {
            fname = TxtFName.Text;
            lname = TxtLName.Text;
            email = TxtEA.Text;
            SMS = checkSMS.Checked;
            Reports = CheckReports.Checked;
            Transactions = CheckTransactions.Checked;

            Form2 n = new Form2(fname, lname, email, SMS, Reports, Transactions);
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signup();
        }
    }
}
