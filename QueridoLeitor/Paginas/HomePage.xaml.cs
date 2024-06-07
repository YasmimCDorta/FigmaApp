namespace QueridoLeitor.Paginas;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void personagem_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PersonagemPage());
    }

    private async void serie_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SeriePage());
    }


}