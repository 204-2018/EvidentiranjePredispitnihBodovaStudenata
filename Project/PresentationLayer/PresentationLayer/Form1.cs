using Shared.Interface.Business;
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

    public partial class Form1 : Form
    {
        public readonly IBusinessRepository studentBusiness;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxHide_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {

            string userName, pass;
            userName = textBoxUserName.Text;
            pass = textBoxPassword.Text;
            if ((userName == "admin1" && pass == "password1") || (userName == "admin2" && pass == "password2") ||
                (userName == "admin3" && pass == "password3"))
            {
                MessageBox.Show("Success");
                FormStudents1 formStudents1 = new FormStudents1(studentBusiness);
                formStudents1.Show();
            }
            else
            {
                MessageBox.Show("Error Try again!");

            }
        }

        private void checkBoxHide_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBoxHide.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;

            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
