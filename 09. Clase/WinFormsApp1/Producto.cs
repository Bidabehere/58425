using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }

        public Producto(int id, string descripcion, double costo, double precioventa)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioventa;
        }

        public Producto() { }
    }
}
