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
            public string Name { get; set; }  // Tên lớp (ví dụ: CNTT1)
            public Faculty Faculty { get; set; }  // Khoa của lớp
        }
        public class Faculty
        {
            public int Id { get; set; }  // ID của khoa
            public string Name { get; set; }  // Tên khoa (ví dụ: CNTT)
        }


    }
}
