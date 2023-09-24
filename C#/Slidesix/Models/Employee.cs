using System.Text;
using System;
using System.Runtime.Intrinsics.Arm;
namespace Slidesix.Models
{
    public class Employee
    {

        public string? Manhanvien { get; set; }
        public string? Tennhanvien { get; set; }
        public int Tuoi { get; set; }
        public int Luong { get; set; }

        public Employee()
        {
            Manhanvien = "12344";
            Tennhanvien = "Hieu";
            Tuoi = 23;
            Luong = 4000000;
        }
        public void NhapThongTin()
        {
            System.Console.WriteLine("Nhap ma nhan vien:");
            Manhanvien = Console.ReadLine();
            System.Console.WriteLine("Nhap ten nhan vien:");
            Tennhanvien = Console.ReadLine();
            System.Console.WriteLine("Nhap tuoi:");
            Tuoi = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Nhap luong:");
            Luong = Convert.ToInt16(Console.ReadLine());

        }
        public void HienThiThongTin()
        {
            System.Console.WriteLine("Thong tin Employee la: ");
            System.Console.WriteLine("Ma nhan vien:" + Manhanvien);
            System.Console.WriteLine("Ten nhan vien:" + Tennhanvien);
            System.Console.WriteLine("Tuoi nhan vien:" + Tuoi);
            System.Console.WriteLine("Luong nhan vien:" + Luong);
        }
        public void Display3(string ten, int tuoi)
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