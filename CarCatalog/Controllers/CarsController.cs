using Microsoft.AspNetCore.Mvc;
using CarCatalog.Models;
using System.Collections.Generic;

namespace CarCatalog.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            var carsList = new List<Car>
            {
                new Car { Brand = "McLaren", Model = "P1", Price = 25434000 },
                new Car { Brand = "BMW", Model = "M5", Price = 95000 },
                new Car { Brand = "Tesla", Model = "Model 3", Price = 40000 },
                new Car { Brand = "Ford", Model = "Mustang", Price = 55000 }
            };

            return View(carsList);
        }
    }
}