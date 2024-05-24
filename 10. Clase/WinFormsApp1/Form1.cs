using WinFormsApp1.Database;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public int idUsuario;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Program.form1.Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.Refresh();
            GestorBaseDeDatos database = new GestorBaseDeDatos();
            dgvUsuarios.AutoGenerateColumns = true;
            dgvUsuarios.DataSource = database.ListaUsuarios();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            idUsuario = 0;
            GestorBaseDeDatos database = new GestorBaseDeDatos();
            dgvUsuarios.AutoGenerateColumns = true;
            dgvUsuarios.DataSource = database.ListaUsuarios();

        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  //Verifica si se hizo clic en una fila valida
            {
                int filaSeleccionada = (int)e.RowIndex;
                idUsuario = int.Parse(dgvUsuarios[0, filaSeleccionada].Value.ToString());
            }
            Form2 form2 = new Form2();
            Program.form1.Hide();
            form2.Show();
        }

       
    }
}
