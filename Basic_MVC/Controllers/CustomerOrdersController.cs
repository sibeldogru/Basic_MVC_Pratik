using Microsoft.AspNetCore.Mvc;
using Basic_MVC.Models;



namespace Basic_MVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer()
            {
                Id = 1,
                Name = "Ayşe",
                LastName = "Yılmaz",
                Email = "ayseyilmaz@mail.com"
            };

            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Tabak", Price = 50, Quantity = 40 },
                new Order { Id = 2, ProductName = "Çatal", Price = 70, Quantity = 100 },
                new Order { Id = 3, ProductName = "Bıçak", Price = 100, Quantity = 25 }

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

