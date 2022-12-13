using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PFD.Models;

namespace PFD.Controllers;

public class ClientAreaController : Controller
{
    private readonly ILogger<ClientAreaController> _logger;

    public ClientAreaController(ILogger<ClientAreaController> logger)
    {
        _logger = logger;
    }

    public IActionResult Dashboard()
    {
        return View();
    }

    public IActionResult Accounts()
    {
        return View();
    }

    public IActionResult AccPlans()
    {
        return View();
    }
    public IActionResult Transactions()
    {
        return View();
    }
    public IActionResult Reports()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
