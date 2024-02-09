using APP1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace APP1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult ItPracujpl()
        {
                DateTime? lastDate = _dbContext.daily_data.Max(d => d.date);
                ViewData["LastDate"] = lastDate.HasValue ? lastDate.Value.ToString("yyyy-MM-dd") : "No data available";
                ViewData["Count"] = _dbContext.daily_data.Count();
                ViewBag.DailyData = _dbContext.daily_data.ToList();
                ViewBag.DailyEtat = _dbContext.daily_etat.ToList();
                ViewBag.DailyKontrakt = _dbContext.daily_kontrakt.ToList();
                ViewBag.DailyManagementLevel = _dbContext.daily_management_level.ToList();
                ViewBag.DailySpecjalizacje = _dbContext.daily_specjalizacje.ToList();
                ViewBag.DailyTMW = _dbContext.daily_technologie_mile_widziane.ToList();
                ViewBag.DailyTW = _dbContext.daily_technologie_wymagane.ToList();
                ViewBag.DailyWorkType = _dbContext.daily_work_type.ToList();
                ViewData["Title"] = "Dane z portalu it.pracuj.pl";
                ViewData["SecondTitle"] = "Dane z portalu it.pracuj.pl";
                ViewData["SiteLink"] = "https://it.pracuj.pl/praca";
                ViewData["SiteTitle"] = "it.pracuj.pl";
                string[] LowerMenuOptions = { "Wynagrodzenie", "Etat", "Kontrakt", "Poziom" , "Tryb pracy", "Specjalizacje", "Technologie wymagane", "Technologie mile widziane", "Lokacje" };
                ViewBag.LowerMenuOptions = LowerMenuOptions;
                string[,] LowerMenuhrefs = { { "oferty", "etat", "kontrakt", "poziom", "tryb", "techwym", "techmil", "lokacje" }, { "Ilość ofert", "Etat", "Kontrakt", "Poziom", "Tryb pracy", "Technologie wymagane", "Technologie mile widziane", "Lokacje" } };
                ViewBag.LowerMenuhrefs = LowerMenuhrefs;
                return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Glowna()
        {
            ViewData["Title"] = "Strona Główna";
            ViewData["SecondTitle"] = "Strona Główna";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}