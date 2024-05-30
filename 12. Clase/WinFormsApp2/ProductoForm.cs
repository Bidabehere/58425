using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.database;
using WinFormsApp2.models;

namespace WinFormsApp2
{
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }

        private void ProductoForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
            Program.form1.CargaProductos();
            Program.form1.Show();
        }

        private void limpiar()
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            var db = new DatabaseContext();

            Producto producto = db.Productos.Find(int.Parse(id));

            db.Productos.Remove(producto);
            db.SaveChanges();
            MessageBox.Show("Se borro el Producto");
            limpiar();
            Program.form1.id = 0;
            this.Close();
            Program.form1.CargaProductos();
            Program.form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string costo = txtCosto.Text;
            string descripcion = txtDescripcion.Text;
            string stock = txtStock.Text;
            string idUsuario = txtIdUsuario.Text;
            string precioVenta = txtPrecioVenta.Text;

            int idProducto = Program.form1.id;
            DatabaseContext db = new DatabaseContext();

            if(idProducto > 0)
            {
                Producto productoEdit = db.Productos.Find(idProducto);
                productoEdit.PrecioVenta = decimal.Parse(precioVenta);
                productoEdit.Descripcion = descripcion;
                productoEdit.Costo = decimal.Parse(costo);  
                productoEdit.IdUsuario = int.Parse(idUsuario);
                productoEdit.Stock = int.Parse(stock);

                MessageBox.Show("Se actualizo el producto");
            }
            else
            {
                Producto newProducto = new Producto();

                newProducto.PrecioVenta = decimal.Parse(precioVenta);
                newProducto.Descripcion = descripcion;
                newProducto.Costo = Decimal.Parse(costo);
                newProducto.Stock = int.Parse(stock);
                newProducto.IdUsuario = int.Parse(idUsuario);

                db.Productos.Add(newProducto);
            }
            db.SaveChanges();
            limpiar();
            this.Close();
            Program.form1.id = 0;
            Program.form1.CargaProductos();
            Program.form1.Show();

        }
    }
}
