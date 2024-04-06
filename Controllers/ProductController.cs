using Microsoft.AspNetCore.Mvc;
using Northwind.Models; 

public class ProductController : Controller
{
    private readonly DataContext _context;

    public ProductController(DataContext context)
    {
        _context = context;
    }

    public ViewResult Category()
    {
        var categories = _context.Categories.ToList();
        return View(categories);
    }
}