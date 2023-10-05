using DemoMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
public class Democontroller : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string userId, string password)
    {
        string str = "Hello" + "" + userId + "-" + password;
        ViewBag.thongbao = str;
        return View();
    }

}