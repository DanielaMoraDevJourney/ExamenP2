namespace AppNotesDanielaMoraMAUI.Views
{
    public partial class Longitud : ContentPage
    {
        public Longitud()
        {
            InitializeComponent();
        }

        private void CalcularKMD(object sender, EventArgs e)
        {
            string Kminput = cantidad_DM.Text;
            numerosKm.Text = CalculoKM(Kminput);
        }

        private void CalcularDCD(object sender, EventArgs e)
        {
            string Dcinput = cantidad_DM.Text;
            numerosDc.Text = CalculoDC(Dcinput);
        }

        private void CalcularMMD(object sender, EventArgs e)
        {
            string Mminput = cantidad_DM.Text;
            numerosMm.Text = CalculoMM(Mminput);
        }

        private string CalculoKM(string Kminput)
        {
            if (double.TryParse(Kminput, out double kilometros))
            {
                double metros = kilometros * 1000;
                return metros.ToString();
            }
            else
            {
                return "Valor mal añadido";
            }
        }

        private string CalculoDC(string Dcinput)
        {
            if (double.TryParse(Dcinput, out double decimetros))
            {
                double metros = decimetros * 100;
                return metros.ToString();
            }
            else
            {
                return "Valor mal añadido";
            }
        }

        private string CalculoMM(string Mminput)
        {
            if (double.TryParse(Mminput, out double milimetros))
            {
                double metros = milimetros * 1000;
                return metros.ToString();
            }
            else
            {
                return "Valor mal añadido";
            }
        }
    }
}
