using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.Models;
using System.Linq;

namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _dataContext;

        public ProductController(DataContext db)
        {
            _dataContext = db;
        }

        public IActionResult Category()
        {
            var categories = _dataContext.Categories.OrderBy(c => c.CategoryName).ToList();
            return View(categories);
        }

        public IActionResult Index(int id)
        {
            var products = _dataContext.Products.Where(p => p.CategoryId == id && !p.Discontinued).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }
    }
}