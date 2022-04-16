using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Investments.Models;

namespace Investments.Controllers
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
            return View();
        }

        public IActionResult StockInvestments()
        {
            return View();
        }

        public IActionResult NewHomeInvestment()
        {
            return View();
        }

        public IActionResult CalculateHouseInfomation(HouseInvestment houseInvestment)
        {
            // new
            ListOfHouse listOfHouses = new ListOfHouse();
            listOfHouses.CalculatePaymentAtDifferentIntrestRates(houseInvestment);

            // old 
            //houseInvestment.Principle = houseInvestment.PriceOfHouse;
            //houseInvestment.CalculateMortgagePayment();
            //houseInvestment.CalculateTotalCostAndPayedIntrest();

            return View(listOfHouses);
        }

        public IActionResult CalculateInvestments(Client client)
        {
            if (client.StockInvestment == null)
            {
                return RedirectToAction("Index", "Home");
            }

            client.StockInvestment.CalculateReturns();

            return View(client);
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
