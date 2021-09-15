using ExcelUploadReadSaveExampleCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUploadReadSaveExampleCore.Service
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        List<Student> SaveStudents(List<Student> students);
    }
}
