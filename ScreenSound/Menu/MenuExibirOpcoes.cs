using ScreenSound.Modelos;
using ScreenSound.Outros;

namespace ScreenSound.Menu;

internal class MenuExibirOpcoes(Dictionary<string, Banda> bandasRegistradas) : Menu(bandasRegistradas)
{
    public void ExibirOpcoesMenu()
    {
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

        if (int.TryParse(Console.ReadLine()!, out int opcaoEscolhida))
        {
            switch (opcaoEscolhida)
            {
                case 1:
                    MenuRegistrarBanda _1 = new(BandasRegistradas);
                    break;
                case 2:
                    MenuRegistrarAlbum _2 = new(BandasRegistradas);
                    break;
                case 3:
                    MenuExibirBandas _3 = new(BandasRegistradas);
                    break;
                case 4:
                    MenuAvaliarBanda _4 = new(BandasRegistradas);
                    break;
                case 5:
                    MenuExibirDetalhes _5 = new(BandasRegistradas);
                    break;
                case -1:
                    Console.WriteLine("Tchau tchau :)");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        else
        {
            ExibirOpcoesMenu();
        }

    }
}
