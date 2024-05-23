using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Usuario
    {

        private int id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string password;
        private string email;

        public Usuario() { }
        public Usuario(string nombre, string apellido, string nombreUsuario, string password, string email)
        {

            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.email = email;
        }
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string password, string email) : this(nombre, apellido, nombreUsuario, password, email)
        {
            this.id = id;

        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }


        public override string ToString()
        {
            return $"Id = {this.id} - Nombre = {this.nombre} - Apellido = {this.apellido} - Nombre de Usuario = {this.nombreUsuario}  - Password = {this.password} - Email = {this.email}";
        }
    }
}
