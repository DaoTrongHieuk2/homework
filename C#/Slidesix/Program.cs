// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.ComponentModel.DataAnnotations;
using Slidesix.Models;
public class Program
{
    private static int i;

    private static void Main(string[] args)
    {
        StudentBT[] stdArray = new StudentBT[2];
        // Nhap thong tin
        for (int i = 0; i < stdArray.Length; i++)
        {
            System.Console.WriteLine("Nhap phan tu thu " + i);
            StudentBT std = new StudentBT();
            std.EnterData();
            stdArray[i] = std;
        }
        // Hien thi thong tin
        for (int i = 0; i < stdArray.Count(); i++) ;
        {
            System.Console.Write(stdArray[i] + "\t");
        }
        foreach (StudentBT std in stdArray)
        {
            string ID = std.StudentID;
            string Name = std.StudentName;
            int Age = std.Age;
            System.Console.WriteLine(ID + Name + Age);
        }


        /* //Them thong tin 
        StudentBT newStudent = new StudentBT();
        AddNewStudent(ref stdArray, );
 */



    }


}

