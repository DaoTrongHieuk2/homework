// See https://aka.ms/new-console-template for more information
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("So sanh 2 so:");
        Console.WriteLine("Nhap so thu nhat: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so thu hai: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("So thu nhat lon hon so thu hai.");
        }
        else if (a < b)
        {
            Console.WriteLine("So thu nhat nho hon so thu hai.");
        }
        else
        {
            Console.WriteLine("Hai so bang nhau");
        }
    }
}
