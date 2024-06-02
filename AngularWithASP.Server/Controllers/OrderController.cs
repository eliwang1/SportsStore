using Microsoft.AspNetCore.Mvc;
using AngularWithASP.Server.Models;

namespace AngularWithASP.Server.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller {
        private IOrderRepository repository;

        public OrderController(IOrderRepository repoService) {
            repository = repoService;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return repository.Orders.ToList();
        }

        [HttpPost]
        public void CreateOrder([FromBody] Order order)
        {            
        repository.SaveOrder(order);
                return ;
        }
    }
}
