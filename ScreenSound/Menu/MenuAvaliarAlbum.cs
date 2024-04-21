using ScreenSound.Modelos;
using System.Collections.Frozen;

namespace ScreenSound.Menu;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTitulo("Avaliar Álbum");
        Console.Write("\nDigite o nome da banda que deseja dar uma nota: ");

        if (ExisteBanda(bandasRegistradas, Console.ReadLine()!))
        {
            
            Console.Write("\nDigite o nome do álbum que deseja dar uma nota: ");
            if (ExisteAlbum(Banda, Console.ReadLine()!))
            {
                 Console.Write($"\nDigite a nota do álbum {Album.Nome}: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                Album.AdicionarNota(nota);
                RegistroSucessoEsperar();
                Console.WriteLine($"\nA nota {nota.Nota} foi adicionada para o álbum {Album.Nome} da banda {Banda.Nome}\n");
            }
            else
            {
                Console.WriteLine($"\n{Msg}");
            }
        }
    }
}
