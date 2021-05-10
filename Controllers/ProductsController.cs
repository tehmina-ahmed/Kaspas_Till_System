using KaspasApp.Data;
using KaspasApp.Models;
using KaspasApp.Models.Binding;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace KaspasApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ProductsController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        #region
        //Reads the View 
        //public IActionResult Index()
        //{
        //    var allProducts = dbContext.Products.ToList();
        //    return View(allProducts);
        //}
        //[Route("details/{int:id}")]
        //public IActionResult Details(int id)
        //{
        //    var productById = dbContext.Products.FirstOrDefault(p => p.ID == id);
        //    return View(productById);
        //}

        ////CREATEs the actions 
        //[Route("create")]
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost("create")]
        //public IActionResult Create(AddProductBindingModel bindingModel)
        //{
        //    var productToCreate = new Product
        //    {
        //        Name = bindingModel.Name,
        //        Description = bindingModel.Description,
        //        Price = bindingModel.Price,
        //        PictureURL = bindingModel.PictureURL,
        //        CreatedAt = DateTime.Now
        //    };
        //    dbContext.Products.Add(productToCreate);
        //    dbContext.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        ////UPDATE
        //[Route("update/{id:int}")]
        //public IActionResult Update(int id)
        //{
        //    var productById = dbContext.Products.FirstOrDefault(p => p.ID == id);
        //    return View(productById);
        //}
        //[HttpPost]
        //[Route("update/{id:int}")]
        //public IActionResult Update(Product products, int id)
        //{
        //    var productToUpdate = dbContext.Products.FirstOrDefault(p => p.ID == id);
        //    productToUpdate.Name = products.Name;
        //    productToUpdate.Description = products.Description;
        //    productToUpdate.Price = products.Price;
        //    productToUpdate.PictureURL = products.PictureURL;
        //    dbContext.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        ////DELETE
        //[Route("delete/{id:int}")]
        //public IActionResult Delete(int id)
        //{
        //    var productToDelete = dbContext.Products.FirstOrDefault(p => p.ID == id);
        //    dbContext.Products.Remove(productToDelete);
        //    dbContext.SaveChanges();
        //    return RedirectToAction("Index");
        //}
#endregion
        #region Toppings
        //Toppings Section
        //CREATE
        [Route("addtopping/{productID:int}")]
        public IActionResult CreateToppings(int productID)
        {
            var product = dbContext.Products.FirstOrDefault(p => p.ID == productID);
            ViewBag.ProductName = product.Name;
            return View();
        }
        [HttpPost]
        [Route("addtopping/{productID:int}")]
        public IActionResult CreateToppings(AddToppingBindingModel bindingModel, int productID)
        {
            bindingModel.ProductID = productID;
            var toppingsToCreate = new Topping
            {
                Name = bindingModel.Name,
                Description = bindingModel.Description,
                
                //ProductID = dbContext.Products.FirstOrDefault(p => p.ID == productID),
                Product = dbContext.Products.FirstOrDefault(p => p.ID == productID),

                PictureURL = bindingModel.PictureURL
                
            };
            dbContext.Toppings.Add(toppingsToCreate);
            dbContext.SaveChanges();
            //return RedirectToAction("Index");
            return RedirectToAction("Index", new { id = productID });
        }
        [Route("{id:int}/toppings")]
        public IActionResult ViewToppings(int id)
        {
            var product = dbContext.Products.FirstOrDefault(p => p.ID == id);
            var toppings = dbContext.Toppings.Where(p => p.ProductID == id).ToList();
            ViewBag.ProductName = product.Name;
            return View(toppings);

        }
        #endregion
        #region Product
        //READ
        [Route("")]
        public IActionResult ProductIndex()
        {
            var allProducts = dbContext.Products.ToList();
            return View(allProducts);
        }
        [Route("details/{id:int}")]
        public IActionResult ProductDetails(int id)
        {
            var productById = dbContext.Products.FirstOrDefault(p => p.ID == id);
            return View(productById);
        }
        //CREATE
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(AddProductBindingModel bindingModel)
        {
            var productToCreate = new Models.Product
            {
                Name = bindingModel.Name,
                Description = bindingModel.Description,
                Price = bindingModel.Price,

                PictureURL = bindingModel.PictureURL,
                CreatedAt = DateTime.Now
            };
            dbContext.Products.Add(productToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var productById = dbContext.Products.FirstOrDefault(p => p.ID == id);
            return View(productById);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Models.Product product, int id)
        {
            var productToUpdate = dbContext.Products.FirstOrDefault(p => p.ID == id);
            productToUpdate.Name = product.Name;
            productToUpdate.Description = product.Description;
            productToUpdate.PictureURL = product.PictureURL;
            productToUpdate.Price = product.Price;
            
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var productToDelete = dbContext.Products.FirstOrDefault(p => p.ID == id);
            dbContext.Products.Remove(productToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion
        #region Topping
        //Topping Section
        //CREATE
        [Route("addtopping/{productID:int}")]
        public IActionResult CreateTopping(int productID)
        {
            var product = dbContext.Products.FirstOrDefault(p => p.ID == productID);
            ViewBag.ProductName = product.Name;
            return View();
        }
        [HttpPost]
        [Route("addtopping/{productID:int}")]
        public IActionResult CreateTopping(AddToppingBindingModel bindingModel, int productID)
        {
            bindingModel.ProductID = productID;
            var toppingToCreate = new Topping//had to add s
            {
                Name = bindingModel.Name,
                Description = bindingModel.Description,
                
                Product = dbContext.Products.FirstOrDefault(p => p.ID == productID),

                PictureURL = bindingModel.PictureURL,
                CreatedAt = DateTime.Now,
            };
            dbContext.Toppings.Add(toppingToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("{id:int}/toppings")]
        public IActionResult ViewProductToppings(int id)
        {
            var product = dbContext.Products.FirstOrDefault(p => p.ID == id);
            var topping = dbContext.Toppings.Where(p => p.Product.ID == id).ToList();
            ViewBag.ProductName = product.Name;
            return View(topping);
        }
        #endregion
    }
}
