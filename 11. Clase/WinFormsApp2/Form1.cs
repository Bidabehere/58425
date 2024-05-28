using WinFormsApp2.database;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new DatabaseContext();

            var clientes = db.Clientes
                .OrderBy(b => b.id)
                .ToList();
            dgvCliente.AutoGenerateColumns = true;
            dgvCliente.DataSource = clientes;
        }
    }
}
