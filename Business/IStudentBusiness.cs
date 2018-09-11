using Common.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IStudentBusiness
    {
        List<StudnetDTO> GetAll();
        string Delete(string id);
        string Insert(StudnetDTO dto);
        string Update(StudnetDTO dto);
        StudnetDTO GetByID(string id);
    }
}
