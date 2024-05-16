namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        ProductosConE productosConE;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productosConE = new ProductosConE();

            Producto[] productos =
            {
                new Producto(1,"Notebook Lenovo"),
                new Producto(2,"Mouse Genius"),
                new Producto(3,"Teclado Generico"),
                new Producto(4,"Monitor 20"),
                new Producto(4,"Monitor 25")
            };
            productosConE.InsertarEnLista(productos);
            dgProductosConE.AutoGenerateColumns = true;
            dgProductosConE.DataSource = productosConE.MostrarLista();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgProductosConE.DataSource = null;
            dgProductosConE.Refresh();
            productosConE.LimpiarLista();
        }
    }
}
