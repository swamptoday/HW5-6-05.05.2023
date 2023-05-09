using Microsoft.AspNetCore.Mvc;
using EF_Core.Domain;
using EF_Core.Domain.Entities;
using EF_Core.Service;

namespace EF_Core.Controllers
{
    public class OrderController : Controller
    {
        private readonly DataManager dataManager;

        public OrderController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult GetOrders(int id)
        {
            var model = dataManager.Orders.GetOrders();
            return View(model);
        }

        public IActionResult GetOrder(int id)
        {
            var model = dataManager.Orders.GetOrderById(id);
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var entity = id == default ? new Order() : dataManager.Orders.GetOrderById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Order model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Orders.SaveOrder(model);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }


  
        public IActionResult Delete(int id)
        {
            dataManager.Orders.DeleteOrder(id);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult FilterByYear()
        {
            int year = int.Parse(Request.Query["year"]);

            return RedirectToAction("Index", "Home", new { year = year });
        }

    }
}
