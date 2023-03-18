using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sweeft_test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft_test
{
    public class GetTeachers
    {
        public static void PrintTeachers(string studentName)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniContext>();

            optionsBuilder.UseSqlServer(@"Data Source=localhost;
    Initial Catalog=AdventureWorks2019_luka;persist security info=True;
    Integrated Security=SSPI;");
            
            using (var context = new UniContext(optionsBuilder.Options))
            {
                Teacher[] teachers = GetAllTeachersByStudent(studentName, context);
                
                foreach(var teacher in teachers)
                {
                    Console.WriteLine($"{teacher.Id}, {teacher.Fname} {teacher.Lname}");
                }
            }
        
        }
            
        public static Teacher[] GetAllTeachersByStudent(string studentName, UniContext context)
        {
            return context.Students.Where
                (s => s.Fname == studentName)
                .SelectMany(s => s.Teachers).ToArray();
        }        
    }
}
