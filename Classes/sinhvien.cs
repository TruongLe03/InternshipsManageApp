using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InternshipsManageApp
{
    internal class sinhvien
    {
        public class Student
        {
            public string student_code { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string Class { get; set; }  
            public string Major { get; set; }  
        }
        public class Faculty
        {
            public int Id { get; set; }  // ID của khoa
            public string Name { get; set; }  // Tên khoa (ví dụ: CNTT)
        }


    }
}
