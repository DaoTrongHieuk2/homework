using System.Text;
using System;
using System.Runtime.Intrinsics.Arm;
namespace Slidesix.Models
{
    public class EmployeeKT : Person
    {

        public int Luong { get; set; }

        public void NhapThongTin()
        {
            base.EnterData();
            System.Console.WriteLine("Nhap luong:");
            Luong = Convert.ToInt16(Console.ReadLine());

        }
        public void HienThiThongTin()
        {
            base.Display();
            System.Console.WriteLine("Luong nhan vien:" + Luong);
        }
    }
}