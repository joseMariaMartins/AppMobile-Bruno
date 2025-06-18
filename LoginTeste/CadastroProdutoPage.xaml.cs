namespace AppCadastro;

public partial class CadastroProdutoPage : ContentPage
{
    bool darkTheme = false;
    public CadastroProdutoPage()
    {
        InitializeComponent();
    }

    private void btnConcluirCadastro_Clicked(object sender, EventArgs e)
    {
        var novoProduto = new Produtos.Produto
        {
            nomeProd = nomeProd.Text,
            descProd = descProd.Text,
            categoriaProd = categoriaProd.Text,
            precoProd = decimal.Parse(precoProd.Text)
        };

        AppData.Produtos.Add(novoProduto);

        DisplayAlert("Sucesso", "Produto cadastrado com sucesso!", "OK");

        nomeProd.Text = "";
        descProd.Text = "";
        categoriaProd.Text = "";
        precoProd.Text = "";
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
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

