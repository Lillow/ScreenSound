using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTitulo("Detalhes da Banda");
        Console.Write($"Digite o nome da banda: ");
        var nomeBanda = Console.ReadLine()!;


        if (ExisteBanda(bandasRegistradas, nomeBanda))
        {
            Banda banda = new(nomeBanda);
            foreach (var album in banda.Albuns) { Console.WriteLine(album.Nome); }

            var total = Banda.Media;

            Console.WriteLine($"\nA média da banda {nomeBanda} é {Math.Round(total, 2)}\n");

            Banda.ExibirDiscografia();
        }
        else
        {
            MsgBandaInexistente(nomeBanda);
        }

        

    }
}
