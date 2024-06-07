using QueridoLeitor.Model;

namespace QueridoLeitor.Paginas;

public partial class EditaUsuarioPage : ContentPage
{
    Usuario _usuario;
    public EditaUsuarioPage()
    {
        _usuario = new Usuario();

        this.BindingContext = _usuario;

        InitializeComponent();
    }

    private async void btnCriar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_usuario.Email) && string.IsNullOrEmpty(_usuario.Senha) && string.IsNullOrEmpty(_usuario.Nome))
        {
            await DisplayAlert("Erro", "Preencha todas as informações", "Fechar");
            return;
        }
        var cadastro = await App.BancoDados.UsuarioDataTable.SalvarUsuario(_usuario);

        if (cadastro > 0)
        {
            await DisplayAlert("Sucesso", "Usuário cadastrado com sucesso", "Fechar");
            await Navigation.PopAsync();
        }
    }
}