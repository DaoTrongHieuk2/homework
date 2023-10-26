using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using DemoMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
public class PersonConytroller : Controller
{
    public IActionResult IndexPerson()
    {
        return View();
    }
    [HttpPost]

    public IActionResult IndexPerson(Personn ps)
    {
        string tl = ps.PersonID + "-" + ps.FullName;
        ViewBag.thongbao = tl;
        return View();
    }
    //Dao Trong Hieu 2021050258//



}