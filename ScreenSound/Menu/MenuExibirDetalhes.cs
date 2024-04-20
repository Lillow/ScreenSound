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
            Banda banda = new(nomeBanda);
            foreach (var album in banda.Albuns) { Console.WriteLine(album.Nome); }

            var total = Banda.Media;

            Console.WriteLine($"A média da banda {nomeBanda} é {Math.Round(total, 2)}\n");
        }
        else
        {
            MsgBandaInexistente(nomeBanda);
        }

        /***foreach (var valor in bandasRegistradas[nomeBanda])
        {
            count ++;
            total += valor;
        }***/



        VoltarMenu(bandasRegistradas);
    }
}
