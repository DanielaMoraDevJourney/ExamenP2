namespace AppNotesDanielaMoraMAUI.Views;

public partial class Dirrecion_DM : ContentPage
{
	public Dirrecion_DM()
	{
		InitializeComponent();
	}

    private void ClickVolumen(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Longitud());

    }

    private void ClickMoneda(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Moneda());
    }

    private void ClickLongitud(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Volumen());
    }
}