using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CertofAppearance.Models;

namespace CertofAppearance.Controllers;

using System.Data.SqlClient;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Client c = new Client();
        return View(c);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}