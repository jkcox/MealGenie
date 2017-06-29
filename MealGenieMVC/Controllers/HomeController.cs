using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MealGenie.DB;
using MealGenieMVC.Models;

namespace MealGenieMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add([Bind("IngredientId,Name,MeasurementTypeId")] Ingredient ingredient)
        {
            if (ModelState.IsValid)
            {
            IMealGenieService service = MealGenieService.GetService(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MealGenie;Integrated Security=True");
                var newIngredient = service.AddIngredient(ingredient.Name, ingredient.MeasurementTypeId);
                ViewData["Message"] = "Add to DB: ModelState.IsValid";
                //return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
