using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.Models;
using System;
using System.Linq;

namespace Northwind.Controllers;
public class CustomerController : Controller
{
    private readonly DataContext _dataContext;

    public CustomerController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(Customer customer)
    {
        if (ModelState.IsValid)
        {
            // Check for unique company name
            if (_dataContext.Customers.Any(c => c.CompanyName == customer.CompanyName))
            {
                ModelState.AddModelError("CompanyName", "Company name must be unique");
                return View(customer);
            }

            _dataContext.Customers.Add(customer);
            _dataContext.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }

        return View(customer);
    }
}