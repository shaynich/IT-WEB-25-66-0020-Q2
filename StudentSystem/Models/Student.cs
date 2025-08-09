using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        // Foreign Key
        [ForeignKey("ID")]
        public int MyProperty { get; set; }
    }
}
