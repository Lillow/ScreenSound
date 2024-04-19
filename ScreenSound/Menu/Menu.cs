using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class Menu(Dictionary<string, Banda> bandasRegistradas)
{
    public static void ExibirTitulo(string titulo)
    {
        string enfeiteTitulo = string.Empty.PadRight(titulo.Length + 2, '*');
        Console.WriteLine($"{enfeiteTitulo}\n {titulo}\n{enfeiteTitulo}\n");
    }

    public static void VoltarMenu()
    {
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
        Console.Clear();
        Console.ReadKey();
        //ExibirOpcoesMenu();
    }

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

    public Dictionary<string, Banda> BandasRegistradas { get; set; } = bandasRegistradas;
    public Banda Banda { get; set; }
}
