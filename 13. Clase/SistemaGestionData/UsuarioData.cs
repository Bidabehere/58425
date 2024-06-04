using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaGestionEntities;


namespace SistemaGestionData
{
    public class UsuarioData
    {
        public static List<Usuario> GetUsuarios()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

            List<Usuario> listaUsuario = new List<Usuario>();

            string query = "SELECT * FROM Usuario";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                            {
                                while (dataReader.Read())
                                {
                                    var usuario = new Usuario();

                                    usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                    usuario.Nombre = dataReader["Nombre"].ToString();
                                    usuario.Apellido = dataReader["Apellido"].ToString();
                                    usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                    usuario.Password = dataReader["Contraseña"].ToString();
                                    usuario.Email = dataReader["Mail"].ToString();
                                    
                                    listaUsuario.Add(usuario);

                                }

                            }
                            return listaUsuario;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                return listaUsuario;
            }

        }
    }
}
