using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTitulo("Detalhes da Banda");
        Console.Write($"Digite o nome da banda: ");

        if (ExisteBanda(bandasRegistradas, Console.ReadLine()!))
        {
            var total = Banda.Media;

            Console.WriteLine(Banda.Resumo);

            Console.WriteLine($"\nA média da banda {Banda.Nome} é {Math.Round(total, 2)}\n");

            Banda.ExibirDiscografia();
        }
        else
        {
            Console.WriteLine(Msg);
        }

        

    }
}
