using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class ProductosConE
    {
        private List<Producto> _productosConE;   

        public ProductosConE() 
        {
            _productosConE = new List<Producto>();
        }
        public void InsertarEnLista(Producto[] arrayProductos)
        {
            for (int i = 0; i < arrayProductos.Length; i++)
            {
                if (arrayProductos[i].descripcion.Contains("E") || arrayProductos[i].descripcion.Contains("e"))
                {
                    _productosConE.Add(new Producto(arrayProductos[i].codigo, arrayProductos[i].descripcion));
                    
                }
            }
        }
        public List<Producto> MostrarLista()
        {
            return _productosConE;
        }
        public void LimpiarLista()
        {
            _productosConE.Clear();
        }
    }
}
