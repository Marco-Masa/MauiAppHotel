using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                Detalhes = "Cama casal king-size ou cama solteiro, jardim de inverno, banheira dupla, olho mágico, TV 43″ a cabo, espelho de aumento, ar-condicionado, espelho corpo inteiro, secador de cabelo, cofre para laptop, armário para bagagem com cabides, shampoo e condicionador, frigobar e cortina black-out.",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0,
                Imagem = "suite_super_luxo.jpg"
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                Detalhes = "Cama casal king-size, jardim de inverno, olho mágico, 2 chuveiros de teto, TV 43″ a cabo, espelho de aumento, ar-condicionado, espelho corpo inteiro, secador de cabelo, cofre para laptop, armário para bagagem com cabides, shampoo e condicionador, frigobar e cortina black-out.",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0,
                Imagem = "suite_luxo.jpg"
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                Detalhes = "Cama solteiro, banheiro privativo, guarda-roupa, mesa de cabeceira com luminária, escrivaninha, suporte para malas, ar-condicionado, televisão, frigobar, telefone, acesso à internet Wi-Fi, kit de roupas de cama e de banho, sabonete, shampoo e condicionador individuais.",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 25.0,
                Imagem = "suite_single.jpg"
            },
            new Quarto()
            {
                Descricao = "Suíte Light",
                Detalhes = "Cama de casal, TV, ducha/chuveiro, secador de cabelo, sabonete, toalhas, wi-fi gratuito e sistema de som ambiente, frigobar, mesa e garagem coletiva.",
                ValorDiariaAdulto = 25.0,
                ValorDiariaCrianca = 12.5,
                Imagem = "suite_light.jpg"
            },
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }
}
