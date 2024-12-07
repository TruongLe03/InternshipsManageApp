using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipsManageApp.Classes
{
    public class Giangvien
    {
        public class lecturers
        {
            public string id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public string faculty_id { get; set; }
            public Faculty faculty { get; set; }
        }
        public class Faculty
        {
            public string id { get; set; }
            public string name { get; set; }
        }

    }
}
