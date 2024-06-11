using AppClientesData;
using AppClientesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesBussiness
{
    public class ClienteBussiness
    {
        public static void AltaCliente(Cliente cliente)
        {
            ClienteData.CreateCliente(cliente);
        }

        public static void EliminarCliente(int id)
        {
            ClienteData.DeleteCliente(id);
        }

        public static List<Cliente> GetClientes()
        {
            return ClienteData.GetClientes();    
        }

        public static void ModificarCliente(Cliente cliente)
        {
            ClienteData.UpdateCliente(cliente);
        }
    }
}
