
using System;

public class EquationSolver
{
    public static string SolveLinearEquation(double a, double b)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                return "Phương trình vô số nghiệm";
            }
            else
            {
                return "Phương trình vô nghiệm";
            }
        }
        else
        {
            double x = -b / a;
            return "Nghiệm của phương trình là: " + x;
        }
    }

    public static string SolveQuadraticEquation(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;
        if (delta < 0)
        {
            return "Phương trình vô nghiệm";
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            return "Nghiệm kép của phương trình là: " + x;
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return "Nghiệm của phương trình là: " + x1 + " và " + x2;
        }
    }

    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Giải phương trình bậc nhất");
        Console.Write("Nhập hệ số a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Nhập hệ số b: ");
        b = double.Parse(Console.ReadLine());

        string linearResult = SolveLinearEquation(a, b);
        Console.WriteLine(linearResult);

        Console.WriteLine();

        Console.WriteLine("Giải phương trình bậc hai");
        Console.Write("Nhập hệ số a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Nhập hệ số b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Nhập hệ số c: ");
        c = double.Parse(Console.ReadLine());

        string quadraticResult = SolveQuadraticEquation(a, b, c);
        Console.WriteLine(quadraticResult);

        Console.ReadLine();
    }
}

