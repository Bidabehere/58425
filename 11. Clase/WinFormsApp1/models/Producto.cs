using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.models
{
    public class Producto
    {
        public int Id { get ; set; }
        public string Descripcion { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public double Stock { get; set; }
        public double TotalProducto { get; set; }
        public string Categoria { get; set; }

    }
}
