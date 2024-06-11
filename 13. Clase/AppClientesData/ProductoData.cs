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
    
        public static bool DeleteProducto(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Productos WHERE Id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("id", id);

                return command.ExecuteNonQuery() > 0;
            }
        }
    
        public static bool CreateProducto(Producto producto) 
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
            using(SqlConnection connection = new SqlConnection( connectionString))
            {
                string query = "INSERT INTO Productos(Descripcion,Costo,PrecioVenta,Stock,IdUsuario) values(@descripcion,@costo,@precioVenta,@stock,@idUsuario)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("costo", producto.Costo);
                command.Parameters.AddWithValue("precioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("stock", producto.Stock);
                command.Parameters.AddWithValue("idUsuario", producto.IdUsuario);

                return command.ExecuteNonQuery() > 0;

            }
        }
        
        public static bool EditProducto(Producto producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Productos SET Descripcion = @descripcion, Costo = @costo, PrecioVenta = @precioVenta, Stock = @stock, IdUsuario = @idUsuario WHERE  Id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("costo", producto.Costo);
                command.Parameters.AddWithValue("precioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("stock", producto.Stock);
                command.Parameters.AddWithValue("idUsuario", producto.IdUsuario);
                command.Parameters.AddWithValue("id", producto.Id);
                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }
    }
}
