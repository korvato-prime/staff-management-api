using System.ComponentModel.DataAnnotations;

namespace StaffManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public required string Fullname { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Dateofbirth { get; set; }   
    }
}
