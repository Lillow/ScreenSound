namespace ScreenSound.Modelos;

internal class Album(string nome) : IAvaliavel
{
    private readonly List<Musica> musicas = [];
    private readonly List<Avaliacao> notas = [];
    public string Nome { get; } = nome;
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);
    public List<Musica> Musicas => musicas;
    public float Media
    {
        get
        {
            float total = (notas.Count == 0) ? 0 : notas.Average(avaliacao => avaliacao.Nota);
            Math.Round(total, 2);
            return total;
        }
    }


    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }
}