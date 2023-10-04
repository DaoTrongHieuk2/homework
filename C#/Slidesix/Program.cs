// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.ComponentModel.DataAnnotations;
using Slidesix.Models;
public class Program
{
    private static int i;

    private static void Main(string[] args)
    {
        Employee[] stdArray = new Employee[2];
        // Nhap thong tin
        for (int i = 0; i < stdArray.Length; i++)
        {
            System.Console.WriteLine("Nhap phan tu thu " + i);
            Employee std = new Employee();
            std.NhapThongTin();
            stdArray[i] = std;
        }
        // Hien thi thong tin
        for (int i = 0; i < stdArray.Count(); i++) ;
        {
            System.Console.Write(stdArray[i] + "\t");
        }
        foreach (Employee std in stdArray)
        {
            string ID = std.Manhanvien;
            string Name = std.Tennhanvien;
            int Age = std.Tuoi;
            int Luong = std.Luong;
            System.Console.WriteLine(ID + Name + Age + Luong);
        }





        /* //BT ArrayList
        ArrayList StudentList = new ArrayList();
        System.Console.WriteLine("Nhap so luong sinh vien muon them: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine("\n Sinh vien thu: " + (i + 1));
            StudentBT std = new StudentBT();
            std.EnterData();
            StudentList.Add(std);
        }
        System.Console.WriteLine($"\n Thong tin cac sinh vien trong danh sach:");
        foreach (StudentBT std in StudentList)
        {

            System.Console.WriteLine($"ID: {std.StudentID}, Name: {std.StudentName}, Tuoi: {std.Age}");
        } */
    }


}

