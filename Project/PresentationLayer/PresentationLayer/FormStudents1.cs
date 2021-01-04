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
        public  readonly PointBusiness pointBusiness;

        public FormStudents1()
        {
            this.studentBusiness = new StudentBusiness();
            this.pointBusiness = new PointBusiness();
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
            RefreshData1();
        }
        private void RefreshData()
        {

            listBoxStudents.Items.Clear();
            List<Student> students = this.studentBusiness.GetStudents();

            foreach (Student s in students)
            {
                listBoxStudents.Items.Add(s.Id + ". " + s.Name + "(" + s.IndexNumber + ")");
            }

        }
            private void RefreshData1()
            {
                List<PreexeminationPoints> points = this.pointBusiness.GetPointss();
                listBoxStudents.Items.Clear();

                foreach (PreexeminationPoints p in points)
                {
                    listBoxStudents.Items.Add(p.Colloquium + p.SeminaryWork + p.Homework + p.Activity);

                }
            }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBoxName.Text;
            s.Surname = textBoxSurname.Text;
            s.IndexNumber = textBoxIndexNumber.Text;

            PreexeminationPoints p = new PreexeminationPoints();
            p.Colloquium = Convert.ToInt32(textBoxColloquim.Text);
            p.SeminaryWork = Convert.ToInt32(textBoxSeminaryWork.Text);
            p.Homework = Convert.ToInt32(textBoxHomework.Text);
            p.Activity = Convert.ToInt32(textBoxActivity.Text);

            if (this.studentBusiness.InsertStudent(s) && this.pointBusiness.InsertPoints(p))
            {
                RefreshData();
                MessageBox.Show("Uspesno!");
            }
            else
            {
                MessageBox.Show("Greska, pokusajte ponovo!");
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            PreexeminationPoints p = new PreexeminationPoints();
            if (this.studentBusiness.UpdateStudent(s) && (this.pointBusiness.UpdatePoints(p)))
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
            Student s = new Student();
            PreexeminationPoints p = new PreexeminationPoints();

            int idNew= Convert.ToInt32(textBoxIdNew.Text);
            if (this.studentBusiness.DeleteStudent1(s, idNew) && (this.pointBusiness.DeletePoints1(p, idNew)))
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
    }
    }
