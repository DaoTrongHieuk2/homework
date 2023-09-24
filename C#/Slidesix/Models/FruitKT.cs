namespace Slidesix.Models
{
    public class FruitKT : Fruit
    {
        public string? FruitCode { get; set; }
        public void NhapThongTinKT()
        {
            base.NhapThongTin();
            System.Console.WriteLine("FruitCode: ");
            FruitCode = Console.ReadLine();

        }
        public void HienThiThongTinKT()
        {
            base.HienThiThongTin();
            System.Console.WriteLine("Thong tin ve FruitCode:" + FruitCode);
        }
    }
}