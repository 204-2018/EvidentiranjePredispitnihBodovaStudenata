using BusinessLayer;
using Shared.Interface.Business;
using Shared.Models;
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
        public readonly IBusinessRepository studentBusiness;

        public FormStudents1(IBusinessRepository _studentBusiness)
        { 
            this.studentBusiness = _studentBusiness;
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

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
           
        }

        private void listBoxLaidColl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonInsert_Click_1(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Id = Convert.ToInt32(textBox1.Text);
            s.Name = textBox2.Text;
            s.Surname = textBox3.Text;
            s.IndexNumber = textBox4.Text;
            s.Colloquium = Convert.ToInt32(textBox5.Text);
            s.SeminaryWork = Convert.ToInt32(textBox6.Text);
            s.Homework = Convert.ToInt32(textBox7.Text);
            s.Activity = Convert.ToInt32(textBox8.Text);



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

        private void buttonUpdate_Click_1(object sender, EventArgs e)
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

        private void buttonShow_Click_1(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void buttonView_Click_1(object sender, EventArgs e)
        {
            List<Student> students = this.studentBusiness.LaidColl();

            foreach (Student s in students)
            {
                listBoxLaidColl.Items.Add(s.Name + "  " + s.Surname + "  " + s.IndexNumber + " -  " + s.Colloquium + " bodova");
            }
        }
    }
    }
