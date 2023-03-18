using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft_test
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Gender { get; set; }
        public int Subject_Id { get; set; }
        public Subject Subject { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
