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
    public partial class FormStudents1 : Form

    {
        public readonly StudentBusiness studentBusiness;

        public FormStudents1()

        {
            this.WindowState = FormWindowState.Maximized;
            this.studentBusiness = new StudentBusiness();
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void labelColloquim_Click(object sender, EventArgs e)
        {

        }

        private void FormStudents1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {

            List<Student> students = this.studentBusiness.GetStudents();

            foreach (Student s in students)
            {
              dataGridView1.DataSource = students;
                    
            }

        }
           

        private void buttonShow_Click(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            if (this.studentBusiness.UpdateStudent(s))
            {
                MessageBox.Show("Uspesno ste izmenili podatak studenta!");
                RefreshData();
            }
            else
            {
                MessageBox.Show("Neuspesno, pokusajte ponovo!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdNew.Text);


            if (this.studentBusiness.DeleteStudent1(id))
            {
                MessageBox.Show("Uspesno ste obrisali studenta!");
                RefreshData();
            }
            else
            {
                MessageBox.Show("Neuspesno, pokusajte ponovo!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Id = Convert.ToInt32(textBoxiD.Text);
            s.Name = textBoxName.Text;
            s.Surname = textBoxSurname.Text;
            s.IndexNumber = textBoxIndexNumber.Text;
            s.Colloquium = Convert.ToInt32(textBoxColloquium.Text);
            s.SeminaryWork = Convert.ToInt32(textBoxSeminaryWork.Text);
            s.Homework = Convert.ToInt32(textBoxHomework.Text);
            s.Activity = Convert.ToInt32(textBoxActivity.Text);



            if (this.studentBusiness.InsertStudent(s))
            {
                dataGridView1.DataSource = s;
                RefreshData();
                MessageBox.Show("Uspesno unet podatak!");
            }
            else
            {
                MessageBox.Show("Greska, pokusajte ponovo!");
            }
        }

        private void listBoxLaidColl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            List<Student> students = this.studentBusiness.LaidColl();

            foreach (Student s in students)
            {
                listBoxLaidColl.Items.Add(s.Name + "  " + s.Surname + "  " + s.IndexNumber + " -  " + s.Colloquium  + " bodova" );
            }
        }
    }
    }
