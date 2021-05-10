using KaspasApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaspasApp.Controllers
{
    [Route("[Controller]")]
    public class ToppingsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public DateTime CreatedAt { get; internal set; }
        public string PictureURL { get; internal set; }
        public Models.Product Product { get; internal set; }
        public string Description { get; internal set; }
        public string Name { get; internal set; }

        public ToppingsController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        //READ
        [Route("")]
        public IActionResult Index()
        {
            var alltoppings = dbContext.Toppings.ToList();
            return View(alltoppings);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var toppingsById = dbContext.Toppings.FirstOrDefault(t => t.ID == id);
            return View(toppingsById);
        }

        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var toppingsById = dbContext.Toppings.FirstOrDefault(p => p.ID == id);
            return View(toppingsById);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(ToppingsController topping, int id)
        {
            var toppingsToUpdate = dbContext.Toppings.FirstOrDefault(p => p.ID == id);
            toppingsToUpdate.Name = topping.Name;
            toppingsToUpdate.Description = topping.Description;
            toppingsToUpdate.PictureURL = topping.PictureURL;
            
            
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var toppingsToDelete = dbContext.Toppings.FirstOrDefault(p => p.ID == id);
            dbContext.Toppings.Remove(toppingsToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

       

