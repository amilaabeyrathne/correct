using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repository
{
    public interface Irepository
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByID(string studentId);
        void InsertStudent(Student student);
        void DeleteStudent(string studentID);
        void UpdateStudent(Student student);
        void Save();
    }
}
