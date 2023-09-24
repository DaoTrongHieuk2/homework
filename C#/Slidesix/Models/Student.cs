namespace Slidesix.Models
{
    public class Student : Person
    {
        public string StudentCode { get; set; }

        public void EnterData()
        {
            base.EnterData();
            System.Console.WriteLine("Sutdent Code: ");
            StudentCode = Console.ReadLine();
        }
        public void Display()
        {
            base.Display();
            System.Console.WriteLine("ma sinh vien:" + StudentCode);
        }

    }
}