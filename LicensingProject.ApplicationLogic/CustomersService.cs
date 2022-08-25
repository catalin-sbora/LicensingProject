using LicensingProject.DataAccess.Abstractions;
using LicensingProject.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensingProject.ApplicationLogic
{
    public class CustomersService
    {
        private readonly ICustomersRepository customersRepository;
        private readonly IProductsRepository productsRepository;

        public CustomersService(ICustomersRepository customersRepository, IProductsRepository productsRepository)
        {
            this.customersRepository = customersRepository;
            this.productsRepository = productsRepository;
        }
        public Customer GetCustomer(Guid id)
        {
            return customersRepository.GetById(id);
        }
        public IEnumerable<Customer> GetCustomers()
        {
            //extra validation
            return customersRepository.GetCustomersWithAssociatedLicenses();
        }
        public Customer AddCustomer(Customer toAdd)
        {
            //extra validation
            return customersRepository.Add(toAdd);
        }
        public void DeleteCustomer(Guid customerId)
        {
            customersRepository.DeleteById(customerId);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var existingCustomer = customersRepository.GetById(customer.Id);
            existingCustomer.Phone = customer.Phone;
            existingCustomer.Address = customer.Address;
            existingCustomer.Name = customer.Name;
            return existingCustomer;
        }

        public void CreateCustomerLicense(Guid customerId, Guid productId, License license)
        {

            var customer = customersRepository.GetById(customerId);
            var product = productsRepository.GetById(productId);
            //create license
            var licensedProduct = customer.LicensedProducts
                                           .Where(lp => lp.Product?.Id == productId)
                                           .SingleOrDefault();
            if (licensedProduct == default)
            {
                var existingProduct = productsRepository.GetById(productId);
                licensedProduct = new LicensedProduct
                {
                    Licenses = new List<License> { license },
                    Product = existingProduct
                };

            }
            else
            {
                licensedProduct.Licenses.Add(license);
            }

            customersRepository.Update(customer);
            
        }
    }
}
