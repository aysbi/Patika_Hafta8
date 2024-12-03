using Microsoft.AspNetCore.Mvc;
using Pratik2.Models;

namespace Pratik2.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Aysel",
                LastName = "Bilmez",
                Email = "BongBong@gmail.com"
            };

            var orders = new List<Order>
            {
                new Order {Id= 1, ProductName = "Bilgisayar", Price = 33000, Quantity = 1},
                new Order {Id= 2, ProductName = "Tablet", Price = 7000, Quantity=1},
                new Order {Id= 3, ProductName = "fare", Price = 300, Quantity = 2 }
            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}
