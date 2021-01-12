using BusinessLayer;
using DataAccessLayer.Models;
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
    public partial class FormSeminary : Form
    {
        public readonly StudentBusiness studentBusiness;

        public FormSeminary()
        {
            this.studentBusiness = new StudentBusiness();
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Student> students = this.studentBusiness.Seminary();

            foreach (Student s in students)
            {
                listBoxSeminary.Items.Add(s.Name + "      " + s.Surname + "      " + s.IndexNumber + "   -     " + s.SeminaryWork + "    points");
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxSeminary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
