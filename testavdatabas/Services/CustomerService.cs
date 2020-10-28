using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using testavdatabas.Models;

namespace testavdatabas.Services
{
    public static class CustomerService
    {
        public static async Task AddCustomerAsync(string fullName, string email, int phoneNr)
        {
            using ExampleContext context = new ExampleContext();
            context.Customer.Add(new Customer(fullName, email, phoneNr));
            await context.SaveChangesAsync();
        }

        public static async Task<IEnumerable<Customer>> ReadCustomersAsync()
        {
            using ExampleContext context = new ExampleContext();

            return await context.Customer.ToListAsync();
        }

        public static async Task<Customer> GetCustomerAsync(int id)
        {
            using ExampleContext context = new ExampleContext();
            return await context.Customer.FindAsync(id);
        }


    }
}
