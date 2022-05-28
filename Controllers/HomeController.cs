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

        public IActionResult Index(CondolenceInput? input)
        {
            if (input is not null)
            {
                return View(input);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public async Task<IActionResult> GenerateCondolenceAsync(bool isRandom, CondolenceInput input)
        {
            if (isRandom)
            {
                Condolence randomCondolence = await _condolenceService.GenerateRandomCondolence();
                return View(randomCondolence);
            }

            Condolence userCondolence = await _condolenceService.GenerateCalculatedCondolence(input);

            return View(userCondolence);
        }


        public async Task<IActionResult> RandomCondolence()
        {
            if (ModelState.IsValid)
            {
                Condolence randomCondolence = await _condolenceService.GenerateRandomCondolence();
                return View(randomCondolence);

            }

            return RedirectToAction("Index");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}