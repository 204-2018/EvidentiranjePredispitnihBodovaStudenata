using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interface.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetStudent();
        int Insert(Student s);
        int Update(Student s);
        int Delete1(int id);




    }
}
