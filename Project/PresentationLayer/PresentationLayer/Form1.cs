using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Interface.Business;
using System.Data.Entity;
using DataAccessLayer;
using System.Text.RegularExpressions;
namespace PresentationLayer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        public void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName, pass;
            userName = textBoxUserName.Text;
            pass = textBoxPassword.Text;
            if ((userName == "admin1" && pass == "password1") || (userName == "admin2" && pass == "password2") ||
                (userName == "admin3" && pass == "password3"))
            {
                MessageBox.Show("Success");
                FormStudents1 formStudents1 = new FormStudents1();
                formStudents1.Show();
    }
          
            else
            {
                MessageBox.Show("Error Try again!");

            }
        }

        public void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void checkBoxHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHide.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;

            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
