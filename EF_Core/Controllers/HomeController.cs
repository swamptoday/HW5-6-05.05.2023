using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using EF_Core.Domain;
using EF_Core.Domain.Entities;

namespace EF_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(int year)
        {
            IEnumerable<Order> model;
            if (year == default)
            {
                model = dataManager.Orders.GetOrders();
            }
            else
            {
                model = dataManager.Orders.GetOrdersByYear(year);
            }
            return View(model);
        }
    }
}
