using LicensingProject.ApplicationLogic;
using LicensingProject.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LicensingProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomersService customersService;

        public CustomersController(CustomersService customersService)
        {
            this.customersService = customersService;
        }
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customersService.GetCustomers();
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public Customer Get(Guid id)
        {
            return customersService.GetCustomer(id);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public Customer Post([FromBody] Customer customer)
        {
           return customersService.AddCustomer(customer);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public Customer Put(Guid id, [FromBody] Customer customer)
        {
            return customersService.UpdateCustomer(customer);
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            customersService.DeleteCustomer(id);
        }
    }
}
