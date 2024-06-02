using Microsoft.AspNetCore.Mvc;
using AngularWithASP.Server.Models;

namespace AngularWithASP.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return repository.Products.ToList();
        }

    }
}
