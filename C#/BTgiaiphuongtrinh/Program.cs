// See https://aka.ms/new-console-template for more information
namespace BTgiaiphuongtrinh.Giaiphuongtrinh2phuongthuc
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Giai phuong trinh bac nhat:");
            string ketquaPTbacNhat = Giaiphuongtrinh2phuongthuc.GiaiPhuongTrinhBacNhat(2, 4);
            System.Console.WriteLine(ketquaPTbacNhat);


            Console.WriteLine("Giai phuong trinh bac hai:");
            string ketquaPTbacHai = Giaiphuongtrinh2phuongthuc.GiaiPhuongTrinhBacHai(2, 4, 3);
            System.Console.WriteLine(ketquaPTbacHai);
        }
    }
}


