using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Index()
        {
            var products = _context.Products
                .Include(p => p.Category)
                .Select(p => new ProductViewModel
                {
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                    CategoryName = p.Category.CategoryName
                })
                .ToList();

            return View(products);
        }

    }
}

