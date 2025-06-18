using LoginTeste;

namespace AppCadastro;

public partial class UsuarioPage : ContentPage
{
    public UsuarioPage()
    {
        InitializeComponent();
        lblUsuario.Text = "" + Preferences.Default.Get("Usuario", "Nome");
    }

    private async void Logout_Clicked(object sender, EventArgs e)
    {
        Preferences.Default.Remove("usuario");
        await Navigation.PushAsync(new LoginPage());
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}