using AppClientesBussiness;
using AppClientesEntities;

namespace AppClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = ClienteBussiness.GetClientes();
            dgvCliente.AutoGenerateColumns = true;
            dgvCliente.DataSource = clientes;
        }
    }
}
