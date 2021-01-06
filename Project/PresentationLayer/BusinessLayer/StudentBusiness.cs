using DataAccessLayer;
using DataAccessLayer.Models;
using Shared.Interface.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBusiness : IBusinessRepository
    {

        public readonly StudentRepository studentRepository;

        public StudentBusiness(IStudentRepository _studentRepository)
        {
            this.studentRepository = _studentRepository;
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

        public bool DeleteStudent1(int id)
        {

            if (this.studentRepository.Delete1(id) > 0)
            {

                return true;
            }
            else
            {
                return false;
            }


        }

        public List<Student> LaidColl()
        {
            return this.studentRepository.GetStudent().Where(s => s.Colloquium >= 10).ToList();
        }
    }
}
