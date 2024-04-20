using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuAvaliarBanda : Menu
{
    public MenuAvaliarBanda(Dictionary<string, Banda> bandasRegistradas) //: base(bandasRegistradas)
    {
        Console.Clear();
        ExibirTitulo("Avaliar Banda");
        Console.WriteLine("\nDigite o nome da banda que deseja dar uma nota: ");
        var nomeBanda = Console.ReadLine()!;

        if (ExisteBanda(bandasRegistradas, nomeBanda))
        {
            Console.Write($"\nDigite a nota da banda {nomeBanda}: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            Banda.AdicionarNota(nota);
            RegistroSucessoEsperar();
            Console.WriteLine($"\nA nota foi adicionada para a banda {nomeBanda}\n");
        }
        else
        {
            Console.WriteLine($"\nBanda {nomeBanda} não encontrada\n");
        }

        VoltarMenu(bandasRegistradas);
    }
}
