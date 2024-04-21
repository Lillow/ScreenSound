using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTitulo("Avaliar Banda");
        Console.Write("\nDigite o nome da banda que deseja dar uma nota: ");

        if (ExisteBanda(bandasRegistradas, Console.ReadLine()!))
        {
            Console.Write($"\nDigite a nota da banda {Banda.Nome}: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            Banda.AdicionarNota(nota);
            RegistroSucessoEsperar();
            Console.WriteLine($"\nA nota foi adicionada para a banda {Banda.Nome}\n");
        }
        else
        {
            Console.WriteLine($"\n{Msg}");
        }
    }
}
