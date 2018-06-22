using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLayer.Application;
using NLayer.Application.Interfaces;

namespace NLayer.Web.Asp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEventsService _eventsService;

        public HomeController(IEventsService eventsService)
        {
            _eventsService = eventsService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _eventsService.GetEvents());
        }
    }
}
