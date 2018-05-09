using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace terminal1._0
{
    public partial class frmForgetPassword : Form
    {
        public frmForgetPassword()
        {
            InitializeComponent();
        }

        private void rdbSecurityQuestion_CheckedChanged(object sender, EventArgs e)
        {
            this.Height = 396;
            gbxSMSEmail.Enabled = false;
        }

        private void frmForgetPassword_Load(object sender, EventArgs e)
        {
            this.Height = 197;
        }

        private void EnableGbxSMSEmail(RadioButton rdbCkeck)
        {
            this.Height = 197;
            gbxSMSEmail.Enabled = rdbCkeck.Checked;
        }

        private void rdbSMS_CheckedChanged(object sender, EventArgs e)
        {
            EnableGbxSMSEmail(rdbSMS);
        }

        private void rdbEmail_CheckedChanged(object sender, EventArgs e)
        {
            EnableGbxSMSEmail(rdbEmail);
        }
    }
}
