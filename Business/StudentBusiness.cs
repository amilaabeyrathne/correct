using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;
using data;
using data.Repository;

namespace Business
{
    public class StudentBusiness : IStudentBusiness
    {
        Repository repo = new Repository();

        public string Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<StudnetDTO> GetAll()
        {
            List<StudnetDTO> list = new List<StudnetDTO>();
            var items = repo.GetStudents();
            foreach (var item in items)
            {
                StudnetDTO dto = new StudnetDTO();
                dto.Id = item.Id;
                dto.StudentName = item.StudentName;

                list.Add(dto);
            }

            return list;
        }

        public StudnetDTO GetByID(string id)
        {
            var itme = repo.GetStudentByID(id);
            StudnetDTO dto = new StudnetDTO();
            dto.Id = itme.Id;
            dto.StudentName = itme.StudentName;
            dto.IsDeteleted = itme.IsDeteleted;

            return dto;
        }

        public string Insert(StudnetDTO dto)
        {
            Student stu = new Student();
            stu.Id ="6";
            stu.StudentName = dto.StudentName;
            stu.IsDeteleted = 0;

            try
            {
                repo.InsertStudent(stu);
                repo.Save();
            }
            catch (DbEntityValidationException dbEx  )
            {
                foreach (DbEntityValidationResult entityErr in dbEx.EntityValidationErrors)
                {
                    foreach (DbValidationError error in entityErr.ValidationErrors)
                    {
                        Console.WriteLine("Error Property Name {0} : Error Message: {1}",
                                            error.PropertyName, error.ErrorMessage);
                    }
                }
            }

            return "s";
        }

        public string Update(StudnetDTO dto)
        {
            Student stu = new Student();
            stu.Id = dto.Id;
            stu.StudentName = dto.StudentName;
            stu.IsDeteleted = 0;
            try
            {
                repo.UpdateStudent(stu);
                repo.Save();
            }
            catch (Exception ex)
            {

                throw;
            }

            return "s";
        }
    }
}
