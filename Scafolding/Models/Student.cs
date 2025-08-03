using System.ComponentModel;

namespace Scaffoulding.Models
{
    public class Student
    {
        [DisplayName("Name :")]
        public string name { get; set; }

        [DisplayName("Roll :")]
        public int role { get; set; }

        [DisplayName("Gender :")]
        public string gender { get; set; }

        [DisplayName("Email :")]
        public string email { get; set; }

    }
}
