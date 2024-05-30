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
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void Volver1_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
            Program.form1.CargaClientes();
            Program.form1.Show();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            int idCliente = Program.form1.id;
            if (idCliente > 0)
            {
                var db = new DatabaseContext();
                Cliente _txtCliente = db.Clientes.Find(idCliente);
                txtNombre.Text = _txtCliente.Nombre;
                txtApellido.Text = _txtCliente.Apellido;
                txtDomicilio.Text = _txtCliente.Domicilio;
                txtTelefono.Text = _txtCliente.Telefono;
                txtId.Text = _txtCliente.id.ToString();

            }
            else
            {
                limpiar();
            }

        }

        private void limpiar()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDomicilio.Text = null;
            txtTelefono.Text = null;
            txtId.Text = null;
        }

        private void Guardar1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            //string idCliente = txtId.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;
            int idUsuario = Program.form1.id;


            DatabaseContext db = new DatabaseContext();



            if (idUsuario > 0)
            {
                Cliente clienteEdit = db.Clientes.Find(idUsuario);
                clienteEdit.Nombre = nombre;
                clienteEdit.Apellido = apellido;
                clienteEdit.Domicilio = domicilio;
                clienteEdit.Telefono = telefono;

                MessageBox.Show("Se modifico el Cliente");

            }
            else
            {
                Cliente clienteNew = new Cliente();
                clienteNew.Nombre = nombre;
                clienteNew.Apellido = apellido;
                clienteNew.Domicilio = domicilio;
                clienteNew.Telefono = telefono;

                db.Clientes.Add(clienteNew);
                MessageBox.Show("Se creo el nuevo Cliente");
            }
            db.SaveChanges();
            limpiar(); 
            this.Close();
            Program.form1.id = 0;
            Program.form1.CargaClientes();
            Program.form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            var db = new DatabaseContext();

            Cliente cliente = db.Clientes.Find(int.Parse(id));
            db.Clientes.Remove(cliente);
            db.SaveChanges();
            MessageBox.Show("Se borro el Cliente");
            limpiar();
            Program.form1.id = 0;
            this.Close();
            Program.form1.CargaClientes();
            Program.form1.Show();


        }
    }
}
