using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace terminal1._0
{
    public partial class frmMain : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TerminalSystem;Integrated Security=True");

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDate.Text = monthCalendar1.SelectionStart.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblSundry", con);
            da.Fill(dt);

            bool checkAdminRegester = (bool)dt.Rows[0]["regesteredAdmin"];

            if (checkAdminRegester == false)
            {
                frmAddAdmin addAdmin = new frmAddAdmin();
                addAdmin.ShowDialog();
            }
            else
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
            
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About.aboutProgram about = new About.aboutProgram();
            about.ShowDialog();
           
        }
    }
}
