using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            string query = "SELECT Id, Descripciones, Costo, PrecioVenta from Producto";
            List<Producto> listProductos = new List<Producto>();
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
                                Producto producto = new Producto();
                                producto.Id = Convert.ToInt32(dataReader["Id"]);
                                producto.Descripcion = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToInt32(dataReader["PrecioVenta"]);
                                listProductos.Add(producto);
                                
                            }
                        }

                    }
                    connection.Close();

                }
            }
            dgvLista.DataSource = listProductos;
            dgvLista.AutoGenerateColumns = true;
        }
    }
}
