namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> ciudadesxPaises = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] razasDePerrosArray = new string[5];
            razasDePerrosArray[0] = "Policia";
            razasDePerrosArray[1] = "Pequines";
            razasDePerrosArray[2] = "Caniche";
            razasDePerrosArray[3] = "Chihuahua";
            razasDePerrosArray[4] = "Bull Terrier";

            for (int i = 0; i < razasDePerrosArray.Length; i++)
            {
                lstRazasDePerros.Items.Add(razasDePerrosArray[i]);
            }
            //Ciudades por Pais

            ciudadesxPaises.Add("Buenos Aires", "Argentina");
            ciudadesxPaises.Add("Madrid", "España");
            ciudadesxPaises.Add("París", "Francia");
            ciudadesxPaises.Add("Roma", "Italia");
            ciudadesxPaises.Add("Londres", "Reino Unido");
            ciudadesxPaises.Add("Lima", "Bolivia");
            ciudadesxPaises.Add("Bogota", "Colombia");

            foreach (KeyValuePair<string, string> ciudad in ciudadesxPaises)
            {
                lstCiudadesPais.Items.Add(ciudad.Key + " - " + ciudad.Value);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstCiudadesPais.Items.Clear();
            ciudadesxPaises.Clear();
            MessageBox.Show("Se limpio el contenido del diccionario");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ciudadesxPaises["Londres"] = "Madrid";
            
            lstCiudadesPais.Items.Clear();
            
            foreach (KeyValuePair<string, string> ciudad in ciudadesxPaises)
            {
                lstCiudadesPais.Items.Add(ciudad.Key + " - " + ciudad.Value);

            }
        }
    }
}
