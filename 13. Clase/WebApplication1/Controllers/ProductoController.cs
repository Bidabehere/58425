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
        [HttpDelete(Name ="EliminarProducto")]
        public string Delete([FromBody] int id)
        {
            bool status = ProductoBussiness.BorrarProducto(id);
            if(status)
            {
                return "Producto eliminado";
            }
            else
            {
                return "El producto no se elimino";
            }
        }
        [HttpPut(Name = "ModificarProducto")]
        public bool Put([FromBody] Producto producto)
        {
            return ProductoBussiness.ModificarProducto(producto);
        }
        [HttpPost(Name ="AltaProducto")]
        public bool Post([FromBody] Producto producto)
        {
            return ProductoBussiness.AltaProducto(producto);
        }
    }
}
