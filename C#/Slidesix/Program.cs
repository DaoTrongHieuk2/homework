// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using Slidesix.Models;
public class Program
{
    private static void Main(string[] args)
    {
        /* // Chay code bai giang slide
        Person ps = new Person();
        Person ps1 = new Person();
        Person ps2 = new Person();

        ps2.FullName = "Nguyen Van A";
        ps2.Address = "Ha Noi";
        ps2.Age = 18;
        ps.EnterData();
        ps.Display();
        ps2.Display();

        string str = "Lo Thi B";
        int a = 22;
        ps1.Display2(str, a);

        System.Console.WriteLine(str + "sinh nam" + ps.GetYearOfBirth(a));

        Student std = new Student();
        std.EnterData();
        std.Display();  */



        //chay code Employee
        /*  Employee emp = new Employee();
         try
         {
             emp.NhapThongTin();
             emp.HienThiThongTin();
         }
         catch
         {
             System.Console.WriteLine("Nhap sai du lieu");
         } */

        /* string str = "Dao Trong Hieu";
        int a = 21;
        emp.Display3(str, a);
        System.Console.WriteLine(str, emp.GetYearOfBirth(a)); */




        //chay code Fruit
        /* Fruit fr = new Fruit();
        try
        {
            fr.NhapThongTin();
            fr.HienThiThongTin();
        }
        catch
        {
            System.Console.WriteLine("Nhap sai du lieu");
        } */
        /* string str1 = "Qua na";
        int a1 = 5;
        fr.Display4(str1, a1);
        System.Console.WriteLine(str, fr.GetOfQuantity(a));  */





        //chaycodeStudentBT
        /* StudentBT bt = new StudentBT();

        try
        {
            bt.EnterData();
            bt.Display();
        }
        catch
        {
            System.Console.WriteLine("Nhap sai du lieu");
        } */
        /* string st = "Dao Trong Hieu";
        int aa = 21;
        bt.Display5(st, aa);
        System.Console.WriteLine(str, bt.GetYearOfBirth(a)); */


        /* //BT kế thừa Employee từ Person
        EmployeeKT kt = new EmployeeKT();
        kt.NhapThongTin();
        kt.HienThiThongTin(); */


        /*  //BT kế thừa xây dựng class kế thừa từ class Fruit
         FruitKT ft = new FruitKT();
         ft.NhapThongTinKT();
         ft.HienThiThongTinKT(); */

    }
}
