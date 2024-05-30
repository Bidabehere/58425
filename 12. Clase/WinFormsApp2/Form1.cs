using WinFormsApp2.database;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public int id;
        public string datosCargados;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargaClientes();
        }

        public void CargaClientes()
        {
            comboBox1.SelectedIndex = 0;
            var db = new DatabaseContext();

            var clientes = db.Clientes
                .OrderBy(b => b.id)
                .ToList();
            dgvClienteProducto.AutoGenerateColumns = true;
            dgvClienteProducto.DataSource = clientes;
            datosCargados = "Clientes";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (datosCargados == "Productos")
            {
                ProductoForm productoForm = new ProductoForm();
                Program.form1.Hide();
                productoForm.Show();
            }
            else
            {
                ClienteForm clienteForm = new ClienteForm();
                Program.form1.Hide();
                clienteForm.Show();
            }
            
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                id = int.Parse(dgvClienteProducto[0, filaSeleccionada].Value.ToString());
            }


            if (datosCargados == "Productos")
            {
                ProductoForm productoForm = new ProductoForm();
                Program.form1.Hide();
                productoForm.Show();
            }
            else
            {
                ClienteForm clienteForm = new ClienteForm();
                Program.form1.Hide();
                clienteForm.Show();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectValue = comboBox1.SelectedItem.ToString();
            if(selectValue == "Clientes")
            {
                CargaClientes();
            }
            else if (selectValue == "Productos")
            {
                CargaProductos();
            }else
            {
                CargaClientes();

            }
        }

        internal void CargaProductos()
        {
            comboBox1.SelectedIndex = 1;
            var db = new DatabaseContext();

            var productos = db.Productos
                .OrderBy(b => b.Id)
                .ToList();
            dgvClienteProducto.AutoGenerateColumns = true;
            dgvClienteProducto.DataSource = productos;
            datosCargados = "Productos";
        }
    }
}
