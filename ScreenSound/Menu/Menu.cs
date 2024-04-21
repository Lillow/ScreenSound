using ScreenSound.Modelos;
using ScreenSound.Outros;

namespace ScreenSound.Menu;

internal abstract class Menu
{
    public Banda? Banda { get; set; } 
    public Banda? Album { get; set; } 
    public static string OpenAIkey { get; } = OpenAI.OpenAIkey();


    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }
    
    public static void ExibirTitulo(string titulo)
    {
        string enfeiteTitulo = string.Empty.PadRight(titulo.Length + 2, '*');
        Console.WriteLine($"{enfeiteTitulo}\n {titulo}\n{enfeiteTitulo}\n");
    }
    
    public static void VoltarMenu(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        MenuExibirOpcoes menuExibirOpcoes = new();
        menuExibirOpcoes.Executar(bandasRegistradas);
    }

    public bool ExisteAlbum(Banda banda, string nomeAlbum)
    {
        if (banda.Albuns.Any(album => album.Nome.Equals(nomeAlbum)))
        {
            Album = new(nomeAlbum);
            return true;
        }
        else return false;
    }
    public bool ExisteBanda(Dictionary<string, Banda> bandasRegistradas, string nome)
    {
        if (bandasRegistradas.TryGetValue(nome, out Banda ? banda))
        {
            Banda = banda;
            return bandasRegistradas.ContainsKey(nome);
        }
        else return false;
    }

    public static void MsgAlbumExistente(string nomeAlbum) => Console.WriteLine($"\nO álbum {nomeAlbum} já existe\n");
    public static void MsgAlbumInexistente(string nomeAlbum) => Console.WriteLine($"\nO álbum {nomeAlbum} não foi encontrado\n");


    public static void MsgBandaExistente(string nomeBanda) => Console.WriteLine($"\nA banda {nomeBanda} já está registrada\n");

    public static void MsgBandaInexistente(string nomeBanda) => Console.WriteLine($"\nA banda {nomeBanda} não está registrada\n");

    public static void RegistroSucessoEsperar() => Thread.Sleep(1500);
}


