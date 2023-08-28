// See https://aka.ms/new-console-template for more information
using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {
        Person ps1 = new Person();
        Person ps2 = new Person();
        ps2.InputInfo();
        ps2.DisplayInfo();


    }
    class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public void InputInfo()
        {
            Console.WriteLine("Nhap ma sinh vien: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ten sinh vien: ");
            Name = Console.ReadLine();
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Thong tin sinh vien: ");
            Console.WriteLine("Ma sinh vien:" + Id);
            Console.WriteLine("Ten sinh vien: " + Name);

        }
    }

}
