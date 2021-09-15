using EFCore.BulkExtensions;
using ExcelUploadReadSaveExampleCore.Context;
using ExcelUploadReadSaveExampleCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUploadReadSaveExampleCore.Service
{
    public class StudentService : IStudentService
    {
        DatabaseContext _dbContext = null;
        public StudentService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Student> GetStudents()
        {
            return _dbContext.Students.ToList();
        }

        public List<Student> SaveStudents(List<Student> students)
        {
            _dbContext.BulkInsert(students);
            return students;
        }
    }
}
