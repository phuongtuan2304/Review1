using Review;
using Review1;

namespace Review
{
    public class Program
    {
        public static void Main()
        {
            LopHoc lophoc = new LopHoc();

            lophoc.Nhap();

            int tong = lophoc.TongTienDongPhuc();

            

            Console.WriteLine($"Tong tien dong phuc la:{tong}");
        }
    }

    
}
