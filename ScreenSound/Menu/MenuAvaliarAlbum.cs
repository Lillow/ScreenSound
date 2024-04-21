using ScreenSound.Modelos;
using System.Collections.Frozen;

namespace ScreenSound.Menu;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTitulo("Avaliar Álbum");
        Console.WriteLine("\nDigite o nome da banda que deseja dar uma nota: ");
        var nomeBanda = Console.ReadLine()!;

        if (ExisteBanda(bandasRegistradas, nomeBanda))
        {
            
            Console.WriteLine("\nDigite o nome do álbum que deseja dar uma nota: ");
            var nomeAlbum = Console.ReadLine()!;
            if (Banda.Albuns.Any(album => album.Nome.Equals(nomeAlbum)))
            {
                Album album = Banda.Albuns.First(album => album.Nome.Equals(nomeAlbum));
                Console.Write($"\nDigite a nota do álbum {nomeAlbum}: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                RegistroSucessoEsperar();
                Console.WriteLine($"\nA nota {nota.Nota} foi adicionada para o álbum {album.Nome} da banda {nomeBanda}\n");
            }
            else
            {
                MsgAlbumInexistente(nomeAlbum);
            }
        }
    }
}
