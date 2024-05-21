using System.Data.SqlClient;


namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string connectionString = "Server=. ; Database=SistemaGestion2; Trusted_Connection=True;";
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Usuario";
                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = comando.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var dato = dataReader.GetString(1);
                                Console.WriteLine(dato);
                            }
                        }
                    }
                }
                connection.Close();


            }
        }
    }
}
   