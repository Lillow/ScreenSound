using ScreenSound.Modelos;
using ScreenSound.Outros;

namespace ScreenSound.Menu;

internal class MenuExibirOpcoes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {

        base.Executar(bandasRegistradas);
        Logo logo = new(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");
        logo.ExibirLogo();
        Console.WriteLine("Boas vindas ao Screen Sound\n");

        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
        Console.WriteLine("Digite 3 para mostrar todas as bandas");
        Console.WriteLine("Digite 4 para avaliar uma banda");
        Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite a sua opção: ");
       


        Dictionary<int, Menu> opcoes = [];
        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuRegistrarAlbum());
        opcoes.Add(4, new MenuExibirBandas());
        opcoes.Add(3, new MenuAvaliarBanda());
        opcoes.Add(5, new MenuExibirDetalhes());
        opcoes.Add(-1, new MenuSair());

        if (int.TryParse(Console.ReadLine()!, out int opcaoEscolhida) )
        {
            if (opcaoEscolhida != 1 && opcaoEscolhida != 2 && opcaoEscolhida != 3 && opcaoEscolhida != 4 && opcaoEscolhida != 5 && opcaoEscolhida != -1)
            {
                Executar(bandasRegistradas);
                VoltarMenu(bandasRegistradas);
            }
            else
            {
                Menu menu = opcoes[opcaoEscolhida];
                menu.Executar(bandasRegistradas);
                VoltarMenu(bandasRegistradas);
            }
        }
        else
        {
            Executar(bandasRegistradas);
            VoltarMenu(bandasRegistradas);
        }
    }
}