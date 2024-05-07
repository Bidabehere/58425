using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Producto
    {
        private int _codigo;
        private string _descripcion;
        private double _precioDeCompra;
        private double _precioDeVenta;
        private string _categoria;


        public Producto(int codigo, string descripcion, double precioCompra, double precioVenta, string categoria )
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._precioDeCompra = precioCompra;
            this._precioDeVenta = precioVenta; 
            this._categoria = categoria;
        }

        public string categoria
        {
            get
            {
                if(!string.IsNullOrEmpty( this._categoria )) 
                {
                    return this._categoria; 
                }
                else 
                {
                    return "SIN CATEGORIA"; 
                }
            }
            set
            {
                this._categoria = value;
            }
        }

        public bool hayPrecioDeVenta()
        {
            return this._precioDeVenta > 0;

        }
    }
}
