using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiProject.Data;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IBaseRepository<Customer> _customer;
        public CustomersController(IBaseRepository<Customer> customer)
        {
            _customer = customer;
        }


        [Authorize]
        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Customer customer = _customer.Get(id);
            if (customer == null)
            {
                return NotFound("The Customer record couldn't be found.");
            }
            return Ok(customer);
        }
    }
}
