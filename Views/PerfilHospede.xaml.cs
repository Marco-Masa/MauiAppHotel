namespace MauiAppHotel.Views;

public partial class PerfilHospede : ContentPage
{
    public PerfilHospede()
    {
        InitializeComponent();
    }

    private async void OnSalvarClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Perfil", "Dados salvos localmente com sucesso!", "OK");
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
