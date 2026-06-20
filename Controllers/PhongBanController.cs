using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _2526_2221050858_BaiThi.Models;

namespace _2526_2221050858_BaiThi.Controllers;

public class PhongBanController : Controller
{
    private readonly ILogger<PhongBanController> _logger;

    public PhongBanController(ILogger<PhongBanController> logger)
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


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
