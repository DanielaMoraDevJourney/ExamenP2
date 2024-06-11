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
    }
}
