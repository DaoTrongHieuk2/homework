using System.Security.AccessControl;
// See https://aka.ms/new-console-template for more information
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap 2 so a va b:");
        int a, b;
        System.Console.Write("a = ");
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("b = ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tinh hieu 2 so vua nhap: ");
        System.Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        Console.WriteLine("Tinh tich 2 so vua nhap: ");
        System.Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        Console.WriteLine("Thuc hien phep chia lay nguyen va lay du 2 so vua nhap: ");
        System.Console.WriteLine("Phan nguyen: " + "{0} / {1} = {2}", a, b, a / b);
        System.Console.WriteLine("Phan du: " + "{0} % {1} = {2}", a, b, a % b);
    }
}

