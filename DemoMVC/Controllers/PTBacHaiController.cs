using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using DemoMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
public class PTBacHaiController : Controller
{
    public IActionResult IndexPTBacHai()
    {
        return View();
    }
    [HttpPost]

    /* public IActionResult IndexPTBacHai(double a, double b, double c, double delta, double x1, double x2)
    {
        GiaiPTBac2 model = new GiaiPTBac2();
        model.a = a;
        model.b = b;
        model.c = c;
        delta = b * b - 4 * a * c;
        if (delta > 0)
        {
            System.Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");
            model.x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            model.x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        }
        else if (delta == 0)
        {
            System.Console.WriteLine("Phuong trinh co nghiem:");
            model.x1 = x2 = -b / (2 * a);
        }
        else
        {
            model.x1 = x2 = double.NaN;
            System.Console.WriteLine("Phuong trinh vo nghiem");
        }
        ViewBag.thongbao = model;

        return View(); */
    public IActionResult IndexPTBacHai(GiaiPTBac2 model)
    {
        double delta = model.b * model.b - 4 * model.a * model.c;

        if (delta < 0)
        {
            ViewData["Result"] = "Phuong trinh vo nghiem";
        }
        else if (delta == 0)
        {
            model.x1 = -model.b / (2 * model.a);
            ViewData["Result"] = "Phuong trinh co nghiem kep: " + model.x1;
        }
        else
        {
            model.x1 = (-model.b + Math.Sqrt(delta)) / (2 * model.a);
            model.x2 = (-model.b - Math.Sqrt(delta)) / (2 * model.a);
            ViewData["Result"] = "Phuong trinh co 2 nghiem: x1 = " + model.x1 + ", x2 = " + model.x2;
        }

        return View("IndexPTBacHai", model);
    }
}




