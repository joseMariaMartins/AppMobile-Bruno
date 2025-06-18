using AppCadastro.Resources.Theme;
using LoginTeste;

namespace AppCadastro;

public partial class UsuarioPage : ContentPage
{
    bool darkTheme = false;
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
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            darkTheme = !darkTheme;
            if (darkTheme)
            {

                mergedDictionaries.Add(new Resources.Theme.DarkTheme());
            }
            else
            {

                mergedDictionaries.Add(new Resources.Theme.WhiteTheme());
            }
        }
    }
}