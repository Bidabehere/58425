using AppClientesBussiness;
using AppClientesEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet (Name = "GetProducto")]
        public IEnumerable<Producto> Productos()
        {
            return ProductoBussiness.GetProductos();
        }
        [HttpGet("{id}")]
        public IActionResult GetProductoById(int id)
        {
            Producto producto = ProductoBussiness.GetProductoById(id);

            return Ok(producto);
        }
    }
}
