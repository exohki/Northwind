using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using System.Linq;

namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Category()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Product()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}

