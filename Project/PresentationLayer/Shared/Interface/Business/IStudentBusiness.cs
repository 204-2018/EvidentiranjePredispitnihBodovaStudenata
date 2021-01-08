using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interface.Business
{
    public interface IStudentBusiness
    {
        List<Student> GetStudents();
        bool InsertStudent(Student s);
        bool UpdateStudent(Student s);
        bool DeleteStudent1(int id);
        List<Student> LaidColl();
    }
}
