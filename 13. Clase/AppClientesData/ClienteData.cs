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
        public static bool CreateCliente(Cliente cliente)
        {
           string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
           using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cliente(nombre, apellido, domicilio, telefono) values(@nombre, @apellido, @domicilio, @telefono)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("nombre", cliente.Nombre);
                command.Parameters.AddWithValue("apellido", cliente.Apellido);
                command.Parameters.AddWithValue("domicilio", cliente.Domicilio);
                command.Parameters.AddWithValue("telefono", cliente.Telefono);
                connection.Open();
                
                return command.ExecuteNonQuery() > 0;

            }
        }

        public static bool DeleteCliente(int id)
        {
           string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Cliente WHERE Id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("id", id);

                return command.ExecuteNonQuery() > 0;
            }
        }

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

        public static bool UpdateCliente(Cliente cliente)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Cliente SET nombre = @nombre, apellido = @apellido, domicilio = @domicilio, telefono = @telefono WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("nombre", cliente.Nombre);
                command.Parameters.AddWithValue("apellido", cliente.Apellido);
                command.Parameters.AddWithValue("domicilio", cliente.Domicilio);
                command.Parameters.AddWithValue("telefono", cliente.Telefono);
                command.Parameters.AddWithValue("id", cliente.id);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }
    }
}
