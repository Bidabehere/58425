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
        public static List<Cliente> GetClientes()
        {
            return ClienteData.GetClientes();    
        }

    }
}
