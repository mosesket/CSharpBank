using CSharpBank.Data;
using CSharpBank.Models;
using CSharpBank.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharpBank.Controllers;

[Route("api/customers")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly CustomerService _customerService;

    public CustomerController(CustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    public IActionResult GetALlCustomers()
    {
        var customers = _customerService.GetAllCustomers();

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