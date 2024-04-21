// Screen Sound

using ScreenSound.Menu;
using ScreenSound.Modelos;

namespace ScreenSound.Outros;

internal class Start
{
     public Start ()
     {
        Dictionary<string, Banda> bandasRegistradas = [];
        bandasRegistradas.Add("Linkin Park", new Banda("Linkin Park"));
        bandasRegistradas["Linkin Park"].AdicionarNota(new Avaliacao(10));
        bandasRegistradas["Linkin Park"].AdicionarNota(new Avaliacao(9));
        bandasRegistradas["Linkin Park"].AdicionarNota(new Avaliacao(9.5f));
        bandasRegistradas["Linkin Park"].AdicionarAlbum(new Album("Meteora"));

        bandasRegistradas.Add("Slipknot", new("Slipknot"));
        bandasRegistradas.Add("System of a Down", new("System of a Down"));
        bandasRegistradas.Add("Coldplay", new("Coldplay"));


        MenuExibirOpcoes menuExibirOpcoes = new();
        menuExibirOpcoes.Executar(bandasRegistradas);
    }







}
