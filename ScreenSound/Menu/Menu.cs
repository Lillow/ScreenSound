using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class Menu
{
    public static void ExibirTitulo(string titulo)
    {
        string enfeiteTitulo = string.Empty.PadRight(titulo.Length + 2, '*');
        Console.WriteLine($"{enfeiteTitulo}\n {titulo}\n{enfeiteTitulo}\n");
    }

    public Banda Banda { get; set; } = new("");
    
    public static void VoltarMenu(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        MenuExibirOpcoes menuExibirOpcoes = new(bandasRegistradas);
        menuExibirOpcoes.ExibirOpcoesMenu();
    }

    public static bool ExisteAlbum(Banda banda, string nome)
    {
        var retorno = false;
        foreach (var album in banda.Albuns)
        {
            if (album.Nome.Equals(nome) )
            {
                retorno = true;
            }
        }
        return retorno;
    }

    public static void MsgAlbumExistente(string nomeAlbum) => Console.WriteLine($"\nO álbum {nomeAlbum} já existe\n");

    public bool ExisteBanda(Dictionary<string, Banda> bandasRegistradas, string nome)
    {
        if (bandasRegistradas.TryGetValue(nome, out Banda ? banda))
        {
            Banda = banda;
            return bandasRegistradas.ContainsKey(nome);
        }
        else
        {
            return false;
        }
    }

    public static void MsgBandaExistente(string nomeBanda) => Console.WriteLine($"\nA banda {nomeBanda} já está registrada\n");

    public static void MsgBandaInexistente(string nomeBanda) => Console.WriteLine($"\nA banda {nomeBanda} não está registrada\n");

    public static void RegistroSucessoEsperar() => Thread.Sleep(1500);
}


