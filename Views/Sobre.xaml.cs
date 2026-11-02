using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
    public Sobre()
    {
        InitializeComponent();
    }

    private async void OnGitHubClicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/Marco-Masa/MauiAppHotel.git");
    }

    private async void OnContatoClicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("mailto:masa@uol.com.br");
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        // Voltar a tela anterior
        await Navigation.PopAsync();
    }
}