using System;
using System.Runtime.Intrinsics.Arm;

namespace Slidesix.Models
{
    public class StudentBT
    {
        public string? StudentID { get; set; }
        public string? StudentName { get; set; }
        public int Age { get; set; }

        public void EnterData()
        {
            Console.WriteLine("StudentID: ");
            StudentID = Console.ReadLine();
            Console.WriteLine("StudentName : ");
            StudentName = Console.ReadLine();
            Console.WriteLine("Age: ");
            Age = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine(StudentID + "-" + StudentName + "-" + Age + "tuoi");
        }

    }
}