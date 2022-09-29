using midterm_project.Models;
using midterm_project.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace midterm_project.Controllers;

public class DragonsController : Controller
{
    private readonly ILogger<DragonsController> _logger;
    private readonly IDragonsRepository _dragonRepository;

    public DragonsController(ILogger<DragonsController> logger, IDragonsRepository repository)
    {
        _logger = logger;
        _dragonRepository = repository;
    }

    public IActionResult Index() {
        return RedirectToAction("List");
    }

    public IActionResult List()
    {
        return View(_dragonRepository.GetAllDragons());
    }

    public IActionResult Detail(int id)
    {
        var dragon = _dragonRepository.GetDragonById(id);

        if (dragon == null) {
            return RedirectToAction("List");
        }

        return View(dragon);
    }

    [HttpPost]
    public IActionResult Detail(Dragons dragon) 
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        return View(_dragonRepository.UpdateDragon(dragon));
    }

    [HttpGet]
    public IActionResult New() 
    {
        return View();
    }

    [HttpPost]
    public IActionResult New(Dragons dragon) 
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        
        _dragonRepository.CreateDragon(dragon);

        return RedirectToAction("List");
    }

    public IActionResult Delete(int id) 
    {
        _dragonRepository.DeleteDragonById(id);

        return RedirectToAction("List");
    }
}