namespace ScreenSound.Modelos;

internal class Banda(string nome) : IAvaliavel
{
    public readonly List<Album> Albuns = [];
    private readonly List<Avaliacao> notas = [];

    public string Nome { get; } = nome;
    public float Media
    {
        get
        {
            float total = (notas.Count == 0) ? 0 : notas.Average(avaliacao => avaliacao.Nota);
            Math.Round(total, 2);
            return total;
        }
    }

    public void AdicionarAlbum(Album album) 
    { 
        Albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in Albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal}) - Média: {album.Media}");
        }
    }
}