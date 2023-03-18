using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sweeft_test
{
    public class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Gender { get; set; }
        public int Subject_id { get; set; }
        public Subject Subject { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
