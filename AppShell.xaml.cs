using MauiAppHotel.Views;

namespace MauiAppHotel;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registro da Tela Sobre o Aplicativo
        Routing.RegisterRoute("Sobre", typeof(Sobre));
    }
}
