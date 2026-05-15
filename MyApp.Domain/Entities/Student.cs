using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string Class { get; set; } = null;
        public string FatherName { get; set; } = null;
        public string MotherName { get; set; } = null;
    }
}
