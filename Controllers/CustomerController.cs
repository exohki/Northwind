using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.Models;
using System;
using System.Linq;

namespace Northwind.Controllers;

public class CustomerController(DataContext db) : Controller
{
    private readonly DataContext _dataContext = db;

  public IActionResult Register() => View();
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(Customer customer)
    {
      if (ModelState.IsValid)
      {
       if (_dataContext.Customers.Any(c => c.CompanyName == customer.CompanyName))
        {
          ModelState.AddModelError("", "Company Name must be unique");
        }
        else
        {
          _dataContext.AddCustomer(customer);
          return RedirectToAction("Index", "Home");
        }
      }
      return View();
    }
}