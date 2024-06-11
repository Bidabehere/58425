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

        [HttpDelete(Name ="EliminarCliente")]
        public void Delete([FromBody] int id)
        {
            ClienteBussiness.EliminarCliente(id);
        }
        [HttpPut(Name ="ModificarCliente")]
        public void Put([FromBody] Cliente cliente)
        {
            ClienteBussiness.ModificarCliente(cliente);
        }
        [HttpPost(Name ="AltaCliente")]
        public void Post([FromBody] Cliente cliente) 
        {
            ClienteBussiness.AltaCliente(cliente);

        }

    }
}