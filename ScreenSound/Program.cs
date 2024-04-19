// Screen Sound


using ScreenSound.Menu;
using ScreenSound.Modelos;


Dictionary <string, Banda> bandasRegistradas = [];
bandasRegistradas.Add("Linkin Park", new Banda("Linkin Park"));
bandasRegistradas["Linkin Park"].AdicionarNota(new Avaliacao(10));
bandasRegistradas["Linkin Park"].AdicionarNota(new Avaliacao(9));
bandasRegistradas["Linkin Park"].AdicionarNota(new Avaliacao(9.5f));

bandasRegistradas.Add("Slipknot", new("Slipknot"));
bandasRegistradas.Add("System of a Down", new("System of a Down"));
bandasRegistradas.Add("Coldplay", new("Coldplay"));




void ExibirLogo()
{
    const string mensaemDeBoasVindas = @"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

Boas vindas ao Screen Sound
";
    Console.WriteLine(mensaemDeBoasVindas);

}

void ExibirOpcoesMenu()
{
    ExibirLogo();
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
                MenuRegistrarBanda _1 = new(bandasRegistradas);
                break;
            case 2:
                MenuRegistrarAlbum _2 = new(bandasRegistradas);
                break;
            case 3:
                MenuExibirBandas _3 = new(bandasRegistradas);
                break;
            case 4:
                MenuAvaliarBanda _4 = new(bandasRegistradas);
                break;
            case 5:
                MenuExibirDetalhes _5 = new(bandasRegistradas);
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







//string PegarNomeBanda(string msg)
//{
//    EsperarLimpar(500);
//    Console.WriteLine($"Digite o nome da banda {msg}: ");
//    var nomeBanda = Console.ReadLine();
//    return nomeBanda;

//}

//void EsperarLimpar(int ms)
//{
//    Thread.Sleep(ms);
//    Console.Clear();
//}

void ExibirTitulo(string titulo)
{
    string enfeiteTitulo = string.Empty.PadRight(titulo.Length + 2, '*');
    Console.WriteLine($"{enfeiteTitulo}\n {titulo}\n{enfeiteTitulo}\n");
}

void VoltarMenu()
{
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    ExibirOpcoesMenu();
}



ExibirOpcoesMenu();

