using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUploadReadSaveExampleCore.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Roll { get; set; } = "";
        public int Age { get; set; } = 0;

    }
}
