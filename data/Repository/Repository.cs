using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repository
{
    public class Repository : Irepository
    {
        private TestEntities context;

        public Repository()
        {
            this.context = new TestEntities();
        }

        public void DeleteStudent(string studentID)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByID(string studentId)
        {
            return this.context.Students.Find(studentId);
        }

        public IEnumerable<Student> GetStudents()
        {
            return this.context.Students.ToList().Where(x => x.IsDeteleted == 0);
        }

        public void InsertStudent(Student student)
        {
            this.context.Students.Add(student);
        }

        public void UpdateStudent(Student student)
        {
            this.context.Entry(student).State = System.Data.Entity.EntityState.Modified;
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

      
    }
}
