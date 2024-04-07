using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.Models;
using System;
using System.Linq;

namespace Northwind.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _dataContext;

        public HomeController(DataContext db)
        {
            _dataContext = db;
        }

        public IActionResult Index()
        {
            var discounts = _dataContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now).Take(3).ToList();
            return View(discounts);
        }
    }
}