using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    public  class HocSinh
    {
        public string _hoten { get; set; }

        public virtual void NhapHocSinh()
        {
            Console.WriteLine("Nhap ten hoc sinh:");
            this._hoten = Console.ReadLine();
        }

        public virtual int TienDongPhuc()
        {
            return 0;
        }
       
    }
}
