using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class Usuario
    {
        private string _nombre;
        private string _apellido;
        private int _DNI;
        private string _mail;
        private int _edad;
        private string _domicilio;

        public Usuario(string nombre, string apellido, int DNI, string mail, int edad, string domicilio) {
        
            this._nombre = nombre;
            this._apellido = apellido;
            this._DNI = DNI;
            this._mail = mail;
            this._edad = edad; 
            this._domicilio = domicilio;

        }    

        public string mail
        {
            get
            {
                return this._mail;
            }
            set 
            { 
                this._mail = value; 
            }
        }

        public bool EsMayorDeEdad()
        {
            return this._edad >= 18;
        }
        public string CambiarDireccion(string nuevaDireccion)
        {
            this._domicilio = nuevaDireccion;

            return this._domicilio;
        }
        
        public bool EsGmail()
        {
            if (this._mail.EndsWith("@gmail.com"))
            { 
                return true;
            }
            else
            { 
                return false; 
            }
        }

    }
}
