using Microsoft.AspNetCore.Mvc;
using AngularWithASP.Server.Models;

namespace AngularWithASP.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartLineController : Controller
    {
        private ICartLineRepository repository;
        public CartLineController(ICartLineRepository repoService)
        {
            repository = repoService;
        }
        [HttpPost]
        public void CreateCartLine( CartLine cartline)
        {
            repository.SaveCartLine(cartline);
            return ;
        }

    }
}
