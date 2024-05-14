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
            Dictionary<string, Dictionary<string, double>> catalogoPetShop = new Dictionary<string, Dictionary<string, double>>();
            catalogoPetShop.Add("Alimento para Gatos Adultos",
                new Dictionary<string, double> { { "Cat Chow", 900 }, { "Wiskas", 1200 }, { "Pedigres", 1800 } });

            catalogoPetShop.Add("Alimento para perros cachorros",
                new Dictionary<string, double> { {"Dog Chow", 1500}, {"Pro Plan", 2500 }, {"Pedigres", 5850 } }); 


            lstAlimentos.Items.Add("Seccion\t\t\t\t\tProducto\t\tPrecio");

            foreach (KeyValuePair<string, Dictionary<string,double>> seccion in catalogoPetShop)
            {
                lstAlimentos.Items.Add(seccion.Key);

                foreach (KeyValuePair<string,double> productoPrecio in seccion.Value)
                {
                    lstAlimentos.Items.Add("\t\t\t\t\t" + productoPrecio.Key + "\t\t" + productoPrecio.Value);
                    
                }

            }


        }
    }
}
