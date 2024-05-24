using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Database;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtMail.Text = "";
            txtId.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.idUsuario = 0;
            Program.form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int idUsuario = Program.form1.idUsuario;
            if (idUsuario > 0)
            {
                GestorBaseDeDatos gestorBaseDeDatos = new GestorBaseDeDatos();
                Usuario _txtUsuario = gestorBaseDeDatos.GetUserById(idUsuario);

                txtNombre.Text = _txtUsuario.Nombre;
                txtApellido.Text = _txtUsuario.Apellido;
                txtUsuario.Text = _txtUsuario.NombreUsuario;
                txtPass.Text = _txtUsuario.Password;
                txtMail.Text = _txtUsuario.Email;
                txtId.Text = idUsuario.ToString();
            }
            else
            {
                limpiar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            GestorBaseDeDatos gestorBaseDeDatos = new GestorBaseDeDatos();
            gestorBaseDeDatos.DeleteUser(int.Parse(id));
            MessageBox.Show("Se borro el usuario");
            limpiar();
            Program.form1.idUsuario = 0;
            this.Close();
            Program.form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string usuario = txtUsuario.Text;
            string pass = txtPass.Text;
            string mail = txtMail.Text;

            int idUsuario = Program.form1.idUsuario;

            Usuario newUser = new Usuario(nombre, apellido, usuario,pass, mail );

            GestorBaseDeDatos gestorBaseDeDatos = new GestorBaseDeDatos();

            if ( idUsuario > 0)
            {
                gestorBaseDeDatos.UpdateUser(idUsuario, newUser);
                MessageBox.Show("Se actualizo el usuario");
            }
            else
            {
                gestorBaseDeDatos.CreateUser(newUser);
                MessageBox.Show("Se creo el nuevo usuario");
            }

            limpiar();
            this.Close();
            Program.form1.idUsuario = 0;
            Program.form1.Show();

        }
    }
}
