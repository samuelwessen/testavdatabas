using System;
using System.Threading.Tasks;
using testavdatabas.Services;

namespace testavdatabas
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //await CreateCustomerAsync("Samuel Wessen", "samuelwessen@hotmail.com", Convert.ToInt32("0763398344"));
            //await ListAllCustomersAsync();
            await GetCustomerAsync();

        }

        private static async Task CreateCustomerAsync(string fullName, string email, int phoneNr)
        {
            await CustomerService.AddCustomerAsync(fullName, email, phoneNr);
            Console.WriteLine("hej");
        }

        private static async Task ListAllCustomersAsync()
        {
            var customers = await CustomerService.ReadCustomersAsync();
            Console.WriteLine("Listing all customers from the Database");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Id: {customer.Id}");
                Console.WriteLine($"FullName: {customer.FullName}");
                Console.WriteLine($"Email: {customer.Email}");
                Console.WriteLine($"Id: {customer.PhoneNr}");
                Console.WriteLine(new string('-', 20));
            }

        }

        private static async Task GetCustomerAsync()
        {
            Console.Write("Enter id of a Customer: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var customer = await CustomerService.GetCustomerAsync(id);

            Console.WriteLine($"Id: {customer.Id}");
            Console.WriteLine($"FullName: {customer.FullName}");
            Console.WriteLine($"Email: {customer.Email}");
            Console.WriteLine($"Id: {customer.PhoneNr}");

        }
    }
}
