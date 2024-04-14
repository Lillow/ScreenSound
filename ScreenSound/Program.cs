// Screen Sound



//List<string> listaBandas = new List<string> { "Metallica", "AC/DC", "Iron Maiden", "Guns N' Roses", "Led Zeppelin" };
using System.ComponentModel.Design;
using System.Diagnostics;

Dictionary<string, List<double>> listaBandas = new Dictionary<string, List<double>>();
listaBandas.Add("Linkin Park", new List<double> { 10, 9.5, 8.0, 10 });
listaBandas.Add("Slipknot", new List<double> { 10, 9.5, 8.0, 10 });
listaBandas.Add("System of a Down", new List<double> { 10, 10, 10, 10 });
listaBandas.Add("Coldplay", new List<double> { });



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

void ExibirOpcoesDeMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    int opcao = EscolherOpcao();
    AcaoEscolha(opcao);

}

int EscolherOpcao()
{
    Console.Write("\nDigite a sua opção: ");

    string opcaoEscolhidaStr = Console.ReadLine()!;
    int opcaoEscolhidaInt = 0;

    if ((opcaoEscolhidaStr != "1") && (opcaoEscolhidaStr != "2") && (opcaoEscolhidaStr != "3") && (opcaoEscolhidaStr != "4") && (opcaoEscolhidaStr != "-1"))
    {
        LimparEsperar(500);
        ExibirOpcoesDeMenu();
    }
    else
    {
        opcaoEscolhidaInt = int.Parse(opcaoEscolhidaStr);
    }

    return opcaoEscolhidaInt;

}

void AcaoEscolha(int escolha)
{
    switch (escolha)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            LimparEsperar(500);
            Console.WriteLine(" Tchau tchau :)");
            break;

            //default:
            //Console.WriteLine(" Opção inválida");
            //break;
    }
}

void RegistrarBanda()
{

    LimparEsperar(1000);
    ExibirTitulo("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine();

    LimparEsperar(2000);

    listaBandas.Add(nomeBanda, new List<double>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!\n");
    VoltarAoMenu();
}

void ExibirBandas()
{

    LimparEsperar(1000);

    ExibirTitulo("Exibindo bandas registradas");

    foreach (var banda in listaBandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine();
    VoltarAoMenu();
}

void ExibirTitulo(string titulo)
{
    string enfeiteTitulo = string.Empty.PadRight(titulo.Length + 2, '*');
    Console.WriteLine($"{enfeiteTitulo}\n {titulo}\n{enfeiteTitulo}\n");
}

void AvaliarBanda()
{

    ExibirTitulo("Avaliar Banda");

    var nomeBanda = PegarNomeBanda("que deseja dar uma nota");

    LimparEsperar(2000);

    if (listaBandas.ContainsKey(nomeBanda))
    {
        Console.Write($"Digite a nota da banda {nomeBanda}: ");
        double nota = double.Parse(Console.ReadLine());
        listaBandas[nomeBanda].Add(nota);

        LimparEsperar(1500);

        Console.WriteLine($"A nota foi adicionada para a banda {nomeBanda}\n");
    }
    else
    {
        Console.WriteLine($"Banda {nomeBanda} não encontrada\n");
    }
    VoltarAoMenu();
}

void ExibirMedia()
{
    var nomeBanda = PegarNomeBanda("que quer ver a média");
    //var count = 0;
    var total = 0.0;

    if (listaBandas.ContainsKey(nomeBanda))
    {
        List<double> notas = listaBandas[nomeBanda];

        LimparEsperar(2000);

        total = notas.Average();

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



    VoltarAoMenu();
}

string PegarNomeBanda(string msg)
{
    LimparEsperar(500);
    Console.WriteLine($"Digite o nome da banda {msg}: ");
    var nomeBanda = Console.ReadLine();
    return nomeBanda;

}

void VoltarAoMenu()
{
    //ExibirTitulo("Digite qualquer tecla para voltar ao menu");
    Console.WriteLine("Digite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    ExibirOpcoesDeMenu();
}

void LimparEsperar(int ms)
{
    Console.Clear();
    Thread.Sleep(ms);
}


ExibirOpcoesDeMenu();

