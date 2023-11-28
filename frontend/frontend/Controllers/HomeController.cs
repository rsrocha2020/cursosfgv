using frontend.Models;
using frontend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace frontend.Controllers;

public class HomeController : Controller
{
    private readonly ICursoService _service;
    public IEnumerable<CursoInfo> Cursos;
    public HomeController(ICursoService service)
    {
        _service = service;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult GetCursos()
    {
        Cursos = _service.GetCursos();

        if (Cursos is null)
            return View("Error");

        return View(Cursos);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}