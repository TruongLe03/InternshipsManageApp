using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipsManageApp
{
    internal class datacombobox
    {
        public class Class
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
