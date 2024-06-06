using AppClientesBussiness;
using AppClientesEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet(Name = "GetCliente")]
        public IEnumerable<Cliente> cliente()
        {
            return ClienteBussiness.GetClientes().ToArray();
        }
    }
}