namespace Slidesix.Models
{
    public class Fruit
    {
        public string? FruitID { get; set; }
        public string? FruitName { get; set; }
        public int FruitQuantity { get; set; }

        public Fruit()
        {
            FruitID = "2322";
            FruitName = "qua na";
            FruitQuantity = 4;
        }

        public void NhapThongTin()
        {
            System.Console.WriteLine("FruitID: ");
            FruitID = Console.ReadLine();
            System.Console.WriteLine("FruitName:");
            FruitName = Console.ReadLine();
            System.Console.WriteLine("FruitQuantity: ");
            FruitQuantity = Convert.ToInt16(Console.ReadLine());
        }
        public void HienThiThongTin()
        {
            System.Console.WriteLine("Thong tin ve Fruit:");
            System.Console.WriteLine("FruitID:" + FruitID);
            System.Console.WriteLine("FruitName:" + FruitName);
            System.Console.WriteLine("FruitQuantity:" + FruitQuantity);
        }
        public void Display4(string Ten, int Soluong)
        {
            System.Console.WriteLine(Ten + "-" + Soluong);
        }
        public int GetOfQuantity(int Soluong)
        {
            int Quantity = 50 - Soluong;
            return Quantity;
        }
    }
}