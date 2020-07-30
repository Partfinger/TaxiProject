using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaxiProject.Models;
using TaxiProject.Models.Orders;
using TaxiProject.Models.Orders.Status;

namespace TaxiProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order("Пушкінська, 59", "Леваневського, 37"));
            orders.Add(new Order("Олександрійський, 144", "Піщана, 12"));
            orders.Add(new Order("Водопійна, 2", "Партизанська, 17"));
            orders.Add(new Order("Ярослава Мудрого, 20", "Київська, 31"));
            orders.Add(new Order("Шолом Алейхема, 28", "Таращанський, 14"));
            return View(orders);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
