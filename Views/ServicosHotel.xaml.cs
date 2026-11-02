namespace MauiAppHotel.Views;

public partial class ServicosHotel : ContentPage
{
    private int _larguraDoItem = 340; // 320 de WidthRequest + 20 de Margem lateral somada

    public ServicosHotel()
    {
        InitializeComponent();

        var dados = new List<object>
        {
            new {
                Titulo = "Restaurante Central",
                Horario = "Café: 06h às 10h | Jantar: 19h às 22h",
                Descricao = "Cardápio variado de culinária internacional e pratos regionais inclusos na sua modalidade de estadia diária.",
                Foto = "restaurante.png"
            },
            new {
                Titulo = "Piscina & Bar",
                Horario = "Aberto das 08h às 20h",
                Descricao = "Área climatizada com borda infinita, toalhas cortesia disponíveis na portaria e serviço de bar completo.",
                Foto = "piscina.png"
            },
            new {
                Titulo = "Espaço SPA & Massagem",
                Horario = "Agendamento na Recepção",
                Descricao = "Tratamentos corporais relaxantes, saunas seca e úmida para renovar as energias durante sua hospedagem.",
                Foto = "spa.png"
            }
        };

        col_servicos.ItemsSource = dados;
        indicatorView.ItemsSource = dados;
    }

    // Método seguro que atualiza as bolinhas conforme você arrasta de lado
    private void OnCollectionViewScrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        // Descobre em qual índice o usuário parou dividindo os pixels rolados pelo tamanho do card
        int posicaoAtual = (int)Math.Round(e.HorizontalOffset / _larguraDoItem);

        if (posicaoAtual >= 0 && posicaoAtual < 3)
        {
            indicatorView.Position = posicaoAtual;
        }
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}