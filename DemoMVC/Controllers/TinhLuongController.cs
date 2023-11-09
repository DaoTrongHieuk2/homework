using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using DemoMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
public class TinhLuongController : Controller
{
    public IActionResult IndexEmployee()
    {
        return View();
    }
    [HttpPost]

    public IActionResult IndexEmployee(string HoTen, decimal LuongCoBan, decimal HeSoLuong, decimal PhuCap)
    {
        decimal luong = LuongCoBan * HeSoLuong + PhuCap;
        string tl = HoTen + "-" + luong;
        ViewBag.thongbao = tl;
        return View();
    }
    //Dao Trong Hieu 2021050258//



}