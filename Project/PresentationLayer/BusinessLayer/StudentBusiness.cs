using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBusiness
    {

        public readonly StudentRepository studentRepository;

        public StudentBusiness()
        {
            this.studentRepository = new StudentRepository();
        }

        public List<Student> GetStudents()
        {
            return this.studentRepository.GetStudent();
        }
        public bool InsertStudent(Student s)
        {
            if (this.studentRepository.Insert(s) > 0)
            {
                return true;
            }
            return false;

        }

        public bool UpdateStudent(Student s)
        {
            if (this.studentRepository.Update(s) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteStudent1(Student s)
        {
            
            if(this.studentRepository.Delete1(s)  > 0)
            {

                return true;
            }
            else
            {
                return false;
            }


        }

        public List<Student> LaidColl(int sem)
        {
            return this.studentRepository.GetStudent().Where(s => s.Colloquium >= 10).ToList();
        }
    }
}
