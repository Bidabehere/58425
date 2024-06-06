using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet(Name ="GetCliente")]
        public string Cliente()
        {
            return "Hola Coders!!";
        }
    }
}
