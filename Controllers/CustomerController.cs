using CSharpBank.Data;
using CSharpBank.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharpBank.Controllers;

[Route("api/customers")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly AppDbContext _context;

    public CustomerController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetALlCustomers()
    {
        // Retrieve all customers from the database
        var customers = _context.Customers.ToList();

        if (customers.Any())
        {
            return Ok(customers);
        }
        else
        {
            return NotFound("No customers found");
        }
    }
}