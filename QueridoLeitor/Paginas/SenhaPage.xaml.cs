namespace QueridoLeitor.Paginas;

public partial class SenhaPage : ContentPage
{
	public SenhaPage()
	{
		InitializeComponent();
	}

    private async void btnSenha_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}