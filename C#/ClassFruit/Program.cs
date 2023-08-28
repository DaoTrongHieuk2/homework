// See https://aka.ms/new-console-template for more information
public class Fruit
{
    public int id { get; set; }
    public string? name { get; set; }
    public int soluong { get; set; }

    public void EnterInformation()
    {
        Console.Write("Nhap ma hoa qua: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap ten hoa qua: ");
        name = Console.ReadLine();
        Console.Write("Nhap so luong hoa qua: ");
        soluong = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayInformation()
    {
        Console.WriteLine("Thong tin hoa qua: ");
        Console.WriteLine("Ma hoa qua: " + id);
        Console.WriteLine("Ten hoa qua: " + name);
        Console.WriteLine("So luong hoa qua: " + soluong);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fruit Fruit = new Fruit();
            Fruit.EnterInformation();
            Fruit.DisplayInformation();

            Console.ReadLine();
        }
    }
}

