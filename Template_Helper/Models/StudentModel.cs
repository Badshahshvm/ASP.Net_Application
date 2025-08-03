using System.ComponentModel;

namespace Template.Models
{
    public class StudentModel
    {
        [DisplayName("Student Name")]
        public string name { get; set; }
        [DisplayName("Roll Number")]
        public int roll { get; set; }
        [DisplayName("Phone Number")]
        public int phone { get; set; }
        [DisplayName("Date Of birth")]
        public DateTime dob { get; set; }
    }
}
