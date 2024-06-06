using AppClientesData;
using AppClientesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesBussiness
{
    public class ProductoBussiness
    {
        public static Producto GetProductoById(int id)
        {
            return ProductoData.GetProducto(id);
        }
        public static List<Producto> GetProductos()
        {
            return ProductoData.GetProductos();
        }
    }
}
