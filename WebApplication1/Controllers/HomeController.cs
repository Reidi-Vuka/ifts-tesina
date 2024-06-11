using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Pianodistudio()
    {
        return View();
    }

    public IActionResult Tecnologie()
    {
        return View();
    }

    public IActionResult Progetti()
    {
        return View();
    }
    public IActionResult Ubuntu()
    {
        return View();
    }

    public IActionResult FileZilla()
    {
        return View();
    }

    public IActionResult Resume()
    {
        return View();
    }

    public IActionResult ASPnet()
    {
        return View();
    }
    public IActionResult Bootstrap()
    {
        return View();
    }

    public IActionResult Github()
    {
        return View();
    }

    public IActionResult Alwaysdata()
    {
        return View();
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
