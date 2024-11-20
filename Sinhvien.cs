using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipsManageApp
{
    public class Sinhvien
    { 
        public int Masinhvien { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public string Malop { get; set; }
        public Sinhvien() { 

        
        }

        public Sinhvien(int masinhvien, string hoten, string diachi, string malop)
        {
            Masinhvien = masinhvien;
            Hoten = hoten;
            Diachi = diachi;
            Malop = malop;
        }
    }
}
