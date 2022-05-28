using CongressionalConsolationGenerator.Models;
using CongressionalConsolationGenerator.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CongressionalConsolationGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICondolenceService _condolenceService;
        public HomeController(ILogger<HomeController> logger, ICondolenceService condolenceService)
        {
            _logger = logger;
            _condolenceService = condolenceService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private async Task<IActionResult> GenerateCondolenceAsync(bool isRandom, CondolenceInput input)
        {
            if (isRandom)
            {
                Condolence randomCondolence = await _condolenceService.GenerateRandomCondolence();
                return View(randomCondolence);
            }

            Condolence userCondolence = await _condolenceService.GenerateCalculatedCondolence(input);

            return View(userCondolence);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}