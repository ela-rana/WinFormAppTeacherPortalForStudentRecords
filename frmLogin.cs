using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppTeacherPortalForStudentRecords
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidLogin())
            {
                TeacherPortal teacherPortal = new TeacherPortal();
                teacherPortal.Show();
                this.Hide();

            }
            else
            {
                lblLoginErrorMessage.Text = "Invalid username and/or password combination.\nPlease enter valid credentials";
                lblLoginErrorMessage.Visible = true;
            }

        }
        public bool ValidLogin()
        {
            return true;
            //if (txtUserName.Text == "Teacher" && txtPassword.Text == "Admin")
            //    return true;
            //else
            //    return false;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            lblLoginErrorMessage.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblLoginErrorMessage.Visible = false;
        }
    }
}
