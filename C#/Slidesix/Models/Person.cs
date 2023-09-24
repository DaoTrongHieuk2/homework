using System;
using System.Runtime.Intrinsics.Arm;

namespace Slidesix.Models
{
    public class Person
    {
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }

        public void EnterData()
        {
            Console.WriteLine("Full name: ");
            FullName = Console.ReadLine();
            Console.WriteLine("Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Age: ");
            Age = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine(FullName + "-" + Address + "-" + Age + "tuoi");
        }
        public void Display2(string ten, int tuoi)
        {
            System.Console.WriteLine(ten + "-" + tuoi);
        }

        public int GetYearOfBirth(int age)
        {
            int yearOfBirth = 2023 - age;
            return yearOfBirth;
        }
    }
}