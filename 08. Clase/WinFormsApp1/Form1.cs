namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ListaMayores mayores;
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarMayores()
        {
            dgMayores.AutoGenerateColumns = true;
            dgMayores.DataSource = mayores.GetListaMayores();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mayores = new ListaMayores();

            Cliente[] clientes =
            {
                new Cliente( "Juan Perez", "Larrea 432",12354,  52),
                new Cliente("Elisabeth Aguirre","La Rioja 852", 25426,  35),
                new Cliente("Rodrigo Ruiz", "Larrea 435",87165, 85),
                new Cliente("Laura Gonzalez","Av La Plata 1535",78965,45),
                new Cliente("Rene Mendez","San Bautista 789",46289, 25),
                new Cliente("Elena Gonzales","Larrea 487",65852, 49)
            };
            mayores.InsertarEnLista(clientes);
            CargarMayores();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente clienteAModificar = new Cliente("Laura Gonzalez", "Av La Plata 1535", 78965, 45);
            Cliente clienteNuevo = new Cliente("Laura Fernandez", "Av Cabildoa 2600", 78965, 45);

            mayores.Modificar(clienteAModificar, clienteNuevo);

            dgMayores.DataSource = null;

            CargarMayores();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Cliente clienteABorrar = new Cliente("Juan Perez", "Larrea 432", 12354, 52);

            mayores.Borrar(clienteABorrar);

            dgMayores.DataSource = null;

            CargarMayores();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            dgMayores.DataSource = null;
            mayores.Ordenar();
            CargarMayores();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgMayores.DataSource= null;
            dgMayores.Refresh();
            mayores.LimpiarLista();
        }
    }
}
