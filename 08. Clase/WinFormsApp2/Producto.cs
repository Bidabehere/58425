using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Producto
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public Producto(int codigo, string descripcion) 
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
        }
    }
}
