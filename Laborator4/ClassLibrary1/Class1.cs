using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1
{
    public class Class1
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
    }
}
