using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MySqlX.XDevAPI.Common;
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

            optionsBuilder.UseSqlServer(@"Data Source=LUKA-USHVERIDZE;
    Initial Catalog=AdventureWorks2019_luka;encrypt=true;TrustServerCertificate=true;persist security info=True;
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
            Teacher[] teachers = (
                from t in context.Teachers
                join s in context.Subjects on t.Subject_Id equals s.Id
                join st in context.Students on s.Id equals st.Subject_id
                where st.Fname == studentName
                select t
            ).Distinct().ToArray();


            return teachers;
        }
    }
}
