using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class Menu(Dictionary<string, Banda> listaBandas)
{
    public Dictionary<string, Banda> ListaBandas { get; set; } = listaBandas;
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

    public static bool ExisteBanda(Dictionary<string, Banda> bandasRegistradas, string nome)
    {
        return bandasRegistradas.ContainsKey(nome);
    }
}
