// See https://aka.ms/new-console-template for more information

class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
    public void InputInfo()
    {
        Console.WriteLine("Nhap ma sinh vien: ");
        Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap ten sinh vien: ");
        Name = Console.ReadLine();
        Console.WriteLine("Nhap so dien thoai sinh vien:");
        PhoneNumber = Console.ReadLine();
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Thong tin sinh vien: ");
        Console.WriteLine("Ma sinh vien:" + Id);
        Console.WriteLine("Ten sinh vien: " + Name);
        Console.WriteLine("So dien thoai sinh vien: " + PhoneNumber);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.InputInfo();
        student.DisplayInfo();

        Console.ReadLine();
    }
}
