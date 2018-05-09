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
namespace terminal1._0
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TerminalSystem;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setUserNameTextboxText()
        {
            txtUserNameLogin.Text = "Enter username";
            txtUserNameLogin.ForeColor = Color.Gray;
        }

        private void setPasswordTextboxText()
        {
            txtPasswordLogin.Text = "Enter password";
            txtPasswordLogin.ForeColor = Color.Gray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }
        //*******************************************************
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            setUserNameTextboxText();
            setPasswordTextboxText();
        }

        private void txtUserNameLogin_Enter(object sender, EventArgs e)
        {
            if (txtUserNameLogin.ForeColor == Color.Black)
            {
                txtUserNameLogin.SelectAll();
                return;
            }
            else
            {
                txtUserNameLogin.Text = string.Empty;
                txtUserNameLogin.ForeColor = Color.Black;
            }

        }

        private void txtPasswordLogin_Enter(object sender, EventArgs e)
        {
            if (txtPasswordLogin.ForeColor == Color.Black)
            {
                txtPasswordLogin.SelectAll();
                return;
            }
            else
            {
                txtPasswordLogin.Text = string.Empty;
                txtPasswordLogin.UseSystemPasswordChar = true;
                txtPasswordLogin.ForeColor = Color.Black;
            }
            
        }

        private void txtUserNameLogin_Leave(object sender, EventArgs e)
        {
            if(txtUserNameLogin.Text == string.Empty)
            {
                setUserNameTextboxText();
            }
        }

        private void txtPasswordLogin_Leave(object sender, EventArgs e)
        {
            if(txtPasswordLogin.Text == string.Empty)
            {
                setPasswordTextboxText();
                txtPasswordLogin.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Security security = new Security();
            SqlCommand cmdAdmin = new SqlCommand();
            cmdAdmin.CommandType = CommandType.Text;
            cmdAdmin.Connection = con;
            SqlDataReader myReader;
            cmdAdmin.CommandText = "select * from tblAddAdmin where (username = @username) and (password = @password)";
            cmdAdmin.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUserNameLogin.Text;
            cmdAdmin.Parameters.Add("@password", SqlDbType.NVarChar).Value = security.calculateMD5Hash(txtPasswordLogin.Text);
            con.Open();
            myReader = cmdAdmin.ExecuteReader();
            if(myReader.Read()==true)
            {
                this.Hide();
                frmAdminstrator admin = new frmAdminstrator();                
                admin.ShowDialog();
                myReader.Close();
                this.Close();
            }
            else
            {
                errorProvider1.SetError(txtPasswordLogin, "the information is wrong !!!");
                errorProvider1.SetError(txtUserNameLogin, "the information is wrong !!!");
            }
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPassword fgtPassword = new frmForgetPassword();
            fgtPassword.ShowDialog();
        }
    }
}
