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
        public static bool AltaProducto(Producto producto)
        {
            return ProductoData.CreateProducto(producto);
        }
        public static bool BorrarProducto(int id)
        {
            return ProductoData.DeleteProducto(id);
        }
        public static bool ModificarProducto(Producto producto)
        {
            return ProductoData.EditProducto(producto);
        }
    }
}
