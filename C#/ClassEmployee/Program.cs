// See https://aka.ms/new-console-template for more information
public class Employee
{
    public int id { get; set; }
    public string? name { get; set; }
    public int age { get; set; }
    public double salary { get; set; }
    public void EnterInformation()
    {
        Console.Write("Nhap ma nhan vien: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap ten nhan vien: ");
        name = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap luong: ");
        salary = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayInformation()
    {
        Console.WriteLine("Thong tin nhan vien: ");
        Console.WriteLine("Ma nhan vien: " + id);
        Console.WriteLine("Ten nhan vien: " + name);
        Console.WriteLine("Tuoi: " + age);
        Console.WriteLine("Luong: " + salary);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EnterInformation();
            employee.DisplayInformation();

            Console.ReadKey();
        }
    }
}
