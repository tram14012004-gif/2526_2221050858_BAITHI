using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _2526_2221050858_BaiThi.Models;

namespace _2526_2221050858_BaiThi.Controllers;

public class NhanVienController : Controller
{
    private readonly ILogger<NhanVienController> _logger;

    public NhanVienController(ILogger<NhanVienController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Update()
    {
        return Update();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
