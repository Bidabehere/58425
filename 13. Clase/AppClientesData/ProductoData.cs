using AppClientesEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesData
{
    public class ProductoData
    {
        public static List<Producto> GetProductos()
        {
            List<Producto> listaProductos = new List<Producto>();

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
            
            var query = "SELECT * FROM Productos";

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
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dataReader["Id"]);
                                producto.Descripcion = dataReader["Descripcion"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                                listaProductos.Add(producto);

                            }
                        }
                        return listaProductos;

                    }


                }
            }
        }
        
        public static Producto GetProducto(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Productos WHERE Id = @id";
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    var producto = new Producto();
                    producto.Id = Convert.ToInt32(dataReader["Id"]);
                    producto.Descripcion = dataReader["Descripcion"].ToString();
                    producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                    producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);

                    return producto;
                }

                throw new Exception("ID NO ENCONTRADO");
            }
        }
    }
}
