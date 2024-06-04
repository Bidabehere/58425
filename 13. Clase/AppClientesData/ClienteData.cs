using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppClientesEntities;
using System.Runtime.CompilerServices;

namespace AppClientesData
{
    public class ClienteData
    {
   
        public static List<Cliente> GetClientes()
        {
           string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

            List<Cliente> listaCliente = new List<Cliente>();

            string query = "SELECT * FROM Cliente";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                while (reader.Read()) 
                                {
                                    Cliente cliente = new Cliente();
                                    cliente.id = Convert.ToInt32(reader["Id"]);
                                    cliente.Nombre = reader["Nombre"].ToString();
                                    cliente.Apellido = reader["Apellido"].ToString();
                                    cliente.Domicilio = reader["Domicilio"].ToString();
                                    cliente.Telefono = reader["Telefono"].ToString();

                                    listaCliente.Add(cliente);

                                }

                            }
                            return listaCliente;
                        }
                    }
                }

            }catch (Exception ex)
            {
                return listaCliente;
            }

        }
    }
}
