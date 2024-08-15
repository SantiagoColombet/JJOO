using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JJOO.Models;

namespace JJOO.Controllers;

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

    public IActionResult Paises()
    {
        ViewBag.Paises = bd.ListarPaises();
        return View();
    }
    public IActionResult Historia()
    {
        return View();
    }
    public IActionResult Deportes()
    {
        ViewBag.Deportes = bd.ListarDeportes();
        return View();
    }
    public IActionResult AgregarDeportista()
    {
        return View();
    }

[HttpPost] public  IActionResult GuardarDeportista(Deportista dep)
    {
        bd.AgregarDeportista(dep);
        return View("Index");
    }
    public IActionResult Creditos()
    {
        return View();
    }
    public IActionResult EliminarDeportista(int idCandidato)
    {
        bd.EliminarDeportista(idCandidato);
        return View();
    }

   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
