using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Taikhoan
    {
        private string tentaikhoan;
        private string matkhau;
        private string email;
        private string phanquyen;

        public Taikhoan()
        {}

        public Taikhoan(string tentaikhoan, string matkhau, string email, string phanquyen)
        {
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.email = email;
            this.phanquyen = phanquyen;
        }

        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Email { get => email; set => email = value; }
        public string Phanquyen { get => phanquyen; set => phanquyen = value; }
    }
}
