using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName, pass;
            userName = textBoxUserName.Text;
            pass = textBoxPassword.Text;
            if((userName=="administrator1" && pass=="password1") || (userName == "administrator2" && pass == "password2") ||
                (userName == "administrator3" && pass == "password3"))
            {
                MessageBox.Show("Success");
                ListStudents listStudents = new ListStudents();
                listStudents.Show();
                
            }
            else
            {
                MessageBox.Show("Error Try again!");

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;

            }
        }
    }
}
