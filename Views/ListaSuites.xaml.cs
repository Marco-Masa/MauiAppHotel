namespace MauiAppHotel.Views;

public partial class ListaSuites : ContentPage
{
    App PropriedadesApp;

    public ListaSuites()
    {
        InitializeComponent();

        // Obtém a instância global do aplicativo
        PropriedadesApp = (App)Application.Current;

        // Alimenta o CollectionView de forma 100% dinâmica com a lista oficial
        coll_suites.ItemsSource = PropriedadesApp.lista_quartos;
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}