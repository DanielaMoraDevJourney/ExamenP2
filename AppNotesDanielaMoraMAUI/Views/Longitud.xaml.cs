namespace AppNotesDanielaMoraMAUI.Views;

public partial class Longitud : ContentPage
{
	public Longitud()
	{
		InitializeComponent();
	}

    private void CalcularKM(object sender, EventArgs e)
    {
        string input = cantidad_DM.Text;


    }

    private void CalcularDC(object sender, EventArgs e)
    {
        string input = cantidad_DM.Text;
        int numerosKm = CalculoDC(input);
    }

    private void CalcularM(object sender, EventArgs e)
    {
        string input = cantidad_DM.Text;
        int numerosKm = CalculoM(input);
    }
    private int CalculoKM(string input)
    {
        string input = cantidad_DM.Text;


    }

    private int CalculoM(string input)
    {
       
    }

    private int CalculoDC(string input)
    {
        
    }
}