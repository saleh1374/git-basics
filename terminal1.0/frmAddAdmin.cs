using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Login;



namespace terminal1._0
{
    public partial class frmAddAdmin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TerminalSystem;Integrated Security=True");

        public frmAddAdmin()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            insertAdmin();
            
        }

        private void insertAdmin()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
                errorProvider1.SetError(txtUserName, "Please enter a username");
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
                errorProvider1.SetError(txtPassword, "please enter a password");
            else if (txtPasswordconfiration.Text != txtPassword.Text)
                errorProvider1.SetError(txtPasswordconfiration, "pleas enter curiectly password");
            else if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                errorProvider1.SetError(txtFirstName, "Please enter a first name");
            else if (string.IsNullOrWhiteSpace(txtLastName.Text))
                errorProvider1.SetError(txtLastName, "Please enter a last name");
            else if (string.IsNullOrWhiteSpace(txtNationalCode.Text))
                errorProvider1.SetError(txtNationalCode, "please enter a National Code");
            else if (string.IsNullOrWhiteSpace(txtMobileNumber.Text))
                errorProvider1.SetError(txtMobileNumber, "please enter a mobile number");
            else if (string.IsNullOrWhiteSpace(txtHouseNumber.Text))
                errorProvider1.SetError(txtHouseNumber, "please enter a National Code");
            else if (capcha != txtCaptcha.Text)
            {
                errorProvider1.SetError(txtCaptcha, "Please enter captcha code");
                RefreshCaptcha();
                txtCaptcha.ResetText();
            }
            else
            {
                con.Open();
                insertAdmainFull();
                setRegAdmin();
                con.Close();
                MessageBox.Show("The Admin information saved", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void setRegAdmin()
        {
            SqlCommand cmdRegAdmin = new SqlCommand();
            cmdRegAdmin.CommandText = "update tblSundry set regesteredAdmin = @regesteredAdmin";
            cmdRegAdmin.Connection = con;
            cmdRegAdmin.Parameters.Add("@regesteredAdmin", SqlDbType.Bit).Value = true;
            cmdRegAdmin.ExecuteNonQuery();

        }

        private void insertAdmainFull()
        {
            Security security = new Security();
            SqlCommand cmdAddAdmin = new SqlCommand();
            cmdAddAdmin.CommandText = "insert into tblAddAdmin (username , password , firstName , lastName , nationalCode , mobileNumber , securityQuestion , answerQuestion  , email , city , street , houseNumber) values (@username , @password , @firstName , @lastName , @nationalCode , @mobileNumber , @securityQuestion , @answerQuestion , @email , @city , @street , @houseNumber)";
            cmdAddAdmin.Connection = con;
            cmdAddAdmin.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUserName.Text;
            cmdAddAdmin.Parameters.Add("@password", SqlDbType.NVarChar).Value = security.calculateMD5Hash(txtPassword.Text);
            cmdAddAdmin.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = txtFirstName.Text;
            cmdAddAdmin.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = txtLastName.Text;
            cmdAddAdmin.Parameters.Add("@nationalCode", SqlDbType.NVarChar).Value = txtNationalCode.Text;
            cmdAddAdmin.Parameters.Add("@mobileNumber", SqlDbType.NVarChar).Value = txtMobileNumber.Text;
            cmdAddAdmin.Parameters.Add("@securityQuestion", SqlDbType.VarChar).Value = cmbSecurityQuestion.Text;
            cmdAddAdmin.Parameters.Add("@answerQuestion", SqlDbType.NVarChar).Value = security.calculateMD5Hash(txtAnswerQuestion.Text);
            cmdAddAdmin.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmail.Text;
            cmdAddAdmin.Parameters.Add("@city", SqlDbType.NVarChar).Value = txtCity.Text;
            cmdAddAdmin.Parameters.Add("@street", SqlDbType.NVarChar).Value = txtStreet.Text;
            cmdAddAdmin.Parameters.Add("@houseNumber", SqlDbType.NVarChar).Value = txtHouseNumber.Text;
            cmdAddAdmin.ExecuteNonQuery();
        }

        private string RandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 99999).ToString();
        }

        string capcha;
        System.Speech.Synthesis.SpeechSynthesizer speech = new System.Speech.Synthesis.SpeechSynthesizer();
        void SpeechCaptcha()
        {
            speech.Volume = 100;
            foreach (char objChar in capcha.ToCharArray())
            {
                speech.Speak(objChar.ToString());
            }
        }

        //tolid adad be surate random baraye Captcha
        void RefreshCaptcha()
        {
            CaptchaImage c = new CaptchaImage(RandomNumber(), 100, 39);
            pbxCaptcha.Image = c.Image;
            capcha = c.Text;
        }
        private void frmAddAdmin_Load(object sender, EventArgs e)
        {
            cmbSecurityQuestion.SelectedIndex = 0;
            RefreshCaptcha();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshCaptcha();
        }

        private void btnVoice_Click(object sender, EventArgs e)
        {
            SpeechCaptcha();
        }

        private void txtCaptcha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
