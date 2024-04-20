using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuExibirDetalhes : Menu
{
    public MenuExibirDetalhes(Dictionary<string, Banda> bandasRegistradas) //: base(bandasRegistradas)
    {
        Console.Clear();
        Console.WriteLine($"Digite o nome da banda que quer ver a média: ");
        var nomeBanda = Console.ReadLine()!;


        if (ExisteBanda(bandasRegistradas, nomeBanda))
        {

            // EsperarLimpar(2000);

            var total = Banda.Media;

            Console.WriteLine($"A média da banda {nomeBanda} é {Math.Round(total, 2)}\n");
        }
        else
        {
            Console.WriteLine($"A banda {nomeBanda} não está registrada\n");
        }

        /***foreach (var valor in bandasRegistradas[nomeBanda])
        {
            count ++;
            total += valor;
        }***/



        VoltarMenu(bandasRegistradas);
    }
}
