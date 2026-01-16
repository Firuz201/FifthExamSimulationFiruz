using System.Threading.Tasks;
using FifthExamSimulationFiruz.Contexts;
using FifthExamSimulationFiruz.ViewModels.EventViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FifthExamSimulationFiruz.Areas.Admin.Controllers;

[Area("Admin")]
public class EventController(AppDbContext _context) : Controller
{
    public async Task <IActionResult> Index()
    {
        var events = await _context.Events.Select(x => new EventGetVM()
        {
            Id = x.Id,
            Title = x.Title,
            Description = x.Description,
            LocationName = x.Location.Place,
            ImagePath = x.ImagePath,
            Price = x.Price,
            Date = x.Date
        }).ToListAsync();
        return View();
    }

    public async Task<IActionResult> Create()
    {
        var locations = await _context.Locations.ToListAsync();
        ViewBag.Locations = locations;
        return View();
    }
}

