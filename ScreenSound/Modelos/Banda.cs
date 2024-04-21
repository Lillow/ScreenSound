namespace ScreenSound.Modelos;

internal class Banda(string nome) : IAvaliavel
{
    private readonly List<Album> albuns = [];
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
    public List<Album> Albuns => albuns;

    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}