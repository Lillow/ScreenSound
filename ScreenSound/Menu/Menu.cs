using GenerativeAI.Models;
using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal abstract class Menu
{
    protected Banda Banda { get; set; } = new("");
    protected Album Album { get; set; } = new("");
    protected static string OpenAIkey { get; } = "";
    protected static string? Msg { get; set; }
    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }

    protected static void ExibirTitulo(string titulo)
    {
        string enfeiteTitulo = string.Empty.PadRight(titulo.Length + 2, '*');
        Console.WriteLine($"{enfeiteTitulo}\n {titulo}\n{enfeiteTitulo}\n");
    }

    protected static void VoltarMenu(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        MenuExibirOpcoes menuExibirOpcoes = new();
        menuExibirOpcoes.Executar(bandasRegistradas);
    }

    protected bool ExisteAlbum(Banda banda, string nomeAlbum)
    {
        var msg = $"O álbum {nomeAlbum}";

        if (banda.Albuns.Any(album => album.Nome.Equals(nomeAlbum)))
        {
            Album = Banda.Albuns.First(album => album.Nome.Equals(nomeAlbum));
            Msg = $"{msg} já existe.";
            return true;
        }
        else
        {
            Album = new(nomeAlbum);
            Msg = $"{msg} não foi encontrado.";
            return false;
        }
    }
    protected bool ExisteBanda(Dictionary<string, Banda> bandasRegistradas, string nomeBanda)
    {
        var msg = $"A banda {nomeBanda}";
        if (bandasRegistradas.TryGetValue(nomeBanda, out Banda? banda))
        {
            Banda = banda;
            Msg = $"{msg} já foi registrada.";
            return bandasRegistradas.ContainsKey(nomeBanda);
        }
        else 
        {
            Banda = new(nomeBanda);
            Msg = $"{msg} não foi encontrada.";
            return false;
        }
    }
    protected void RegistroSucessoEsperar() => Thread.Sleep(1500);
    protected async void GeraResumoBanda(string apiKey, Banda banda)
    {
        try
        {
            var model = new GenerativeModel(apiKey);

            var resposta = await model.GenerateContentAsync($"Resuma a banda {banda.Nome} em um parágrafo.");

            banda.Resumo = resposta + "\n\n";
        }
        catch (Exception)
        {
            Console.WriteLine($"\nNão foi possível criar um resumo da banda {Banda.Nome}");
        }

    }
}
