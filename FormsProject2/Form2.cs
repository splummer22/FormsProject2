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
    public partial class Form2 : Form
    {
        string FName;
        string LName;
        string Email;
        bool SMS;
        bool Reports;
        bool Transactions;

        public Form2(string f, string l, string e, bool s, bool r, bool t)
        {
            InitializeComponent();
            FName = f;
            LName = l;
            Email = e;
            SMS = s;
            Reports = r;
            Transactions = t;
        }
        private void confirmation_load(object sender, EventArgs e)
        {
            lblFName.Text = FName;
            lblLName.Text = LName;
            lblEA.Text = Email;

            if(SMS)
            {
                lblSMS.Text = "✓";
            }

            if(Reports)
            {
                lblReports.Text = "✓";
            }

            if(Transactions)
            {
                lblTransactions.Text = "✓";
            }
        }

       
    }
}
