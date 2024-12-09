using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InternshipsManageApp
{
    public class sinhvien
    {
        public class Student
        {
            public string student_code { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
    

            public StudentClass Class { get; set; }


        }
        public class StudentClass
        {
            public int Id { get; set; }
            public string Name { get; set; }  
            public Faculty Faculty { get; set; } 
        }
        public class Faculty
        {
            public int Id { get; set; }  
            public string Name { get; set; }  
        }


    }
}
