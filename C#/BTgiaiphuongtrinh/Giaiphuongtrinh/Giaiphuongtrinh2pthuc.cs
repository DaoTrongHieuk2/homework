namespace BTgiaiphuongtrinh.Giaiphuongtrinh2phuongthuc
{

    public class Giaiphuongtrinh2phuongthuc
    {

        public static string GiaiPhuongTrinhBacNhat(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return " Phuong trinh vo so nghiem.";
                }
                else
                {
                    return " Phuong trinh vo nghiem";
                }
            }
            else
            {
                double x = -b / a;
                return " Nghiem cua phuong trinh la: " + x.ToString();
            }
        }
        public static string GiaiPhuongTrinhBacHai(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return "Phuong trinh vo nghiem";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return "Nghiem kep cua phuong trinh la:" + x;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                return "Nghiem cua phuong trinh la:" + x1.ToString() + " va " + x2.ToString();
            }
        }
    }
}