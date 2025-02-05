using DependencyInjection.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;

        public HomeController(ISingletonService singletonService, IScopedService scopedService, ITransientService transientService)
        {
            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
        }

        public IActionResult Index()
        {
            ViewBag.Transient = _transientService.GuidId;
            ViewBag.Scoped = _scopedService.GuidId;
            ViewBag.Singleton = _singletonService.GuidId;
            return View();
        }
    }
}
