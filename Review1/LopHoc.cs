using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    public class LopHoc
    {
        public List<HocSinh> DanhSachHocSinh { get; set; }

        public LopHoc()
        {
            DanhSachHocSinh = new List<HocSinh>();
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap so luong hoc sinh:");
            int n = int.Parse(Console.ReadLine());


            

            HocSinh hocSinh = new HocSinh();

            for (int i = 0; i <n; i++)
            {
                Console.WriteLine("Nhap gioi tinh hoc sinh (1.Nam, 2.Nu)");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    hocSinh = new NAM();


                }

                else
                    hocSinh = new NU();

                
                Console.WriteLine($"Nhap hoc sinh thu {i+1}:");
                hocSinh.NhapHocSinh();
                this.DanhSachHocSinh.Add(hocSinh);
            }

        }
        public int TongTienDongPhuc()
        {
            int tong = 0;
            foreach (HocSinh hs in DanhSachHocSinh)
            {
                tong += hs.TienDongPhuc();
            }

            return tong;
        }
    }
}
