// Screen Sound


using ScreenSound.Modelos;


Dictionary <string, Banda> listaBandas = [];
listaBandas.Add("Linkin Park", new Banda("Linkin Park"));
listaBandas["Linkin Park"].AdicionarNota(new Avaliacao(10));
listaBandas["Linkin Park"].AdicionarNota(new Avaliacao(9));
listaBandas["Linkin Park"].AdicionarNota(new Avaliacao(9.5f));

listaBandas.Add("Slipknot", new("Slipknot"));
listaBandas.Add("System of a Down", new("System of a Down"));
listaBandas.Add("Coldplay", new("Coldplay"));




void ExibirLogo()
{
    Console.Clear();
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
                RegistrarBanda();
                break;
            case 2:
                RegistrarAlbum();
                break;
            case 3:
                ExibirBandas();
                break;
            case 4:
                AvaliarBanda();
                break;
            case 5:
                ExibirDetalhes();
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

void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    Banda banda = new(Console.ReadLine()!);
    listaBandas.Add(banda.Nome, banda);

    Console.WriteLine($"\nA banda {banda.Nome} foi registrada com sucesso!\n");
    VoltarMenu();
}

void RegistrarAlbum()
{
    Console.Clear();
    ExibirTitulo("Registro de álbuns");
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;

    //if (listaBandas[nomeDaBanda].)

    Console.Write("Agora digite o título do álbum: ");
    string tituloAlbum = Console.ReadLine()!;
    /**
     * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
     */
    Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
    VoltarMenu();
}

void ExibirBandas()
{

    Console.Clear() ;

    ExibirTitulo("Exibindo bandas registradas");

    foreach (var banda in listaBandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine();
    ExibirOpcoesMenu();
}

void ExibirTitulo(string titulo)
{
    string enfeiteTitulo = string.Empty.PadRight(titulo.Length + 2, '*');
    Console.WriteLine($"{enfeiteTitulo}\n {titulo}\n{enfeiteTitulo}\n");
}

void AvaliarBanda()
{

    ExibirTitulo("Avaliar Banda");

    Console.WriteLine("Digite o nome da banda que deseja dar uma nota: ") ;

    var nomeBanda = Console.ReadLine()!;

    if (listaBandas.TryGetValue(nomeBanda, out Banda? value))
    {
        Console.Write($"Digite a nota da banda {nomeBanda}: "); 
        Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
        value.AdicionarNota(nota);

        //EsperarLimpar(1500);

        Console.WriteLine($"A nota foi adicionada para a banda {nomeBanda}\n");
    }
    else
    {
        Console.WriteLine($"Banda {nomeBanda} não encontrada\n");
    }
    ExibirOpcoesMenu();
}

void ExibirDetalhes()
{
    Console.WriteLine($"Digite o nome da banda que quer ver a média: ");
    var nomeBanda = Console.ReadLine()!;
 

    if (listaBandas.TryGetValue(nomeBanda, out Banda? value))
    {

       // EsperarLimpar(2000);

        var total = value.Media;

        Console.WriteLine($"A média da banda {nomeBanda} é {Math.Round(total, 2)}\n");
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não está registrada\n");
    }

    /***foreach (var valor in listaBandas[nomeBanda])
    {
        count ++;
        total += valor;
    }***/



    ExibirOpcoesMenu();
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


void VoltarMenu()
{
    Console.WriteLine("Digite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    ExibirOpcoesMenu();
}



ExibirOpcoesMenu();

