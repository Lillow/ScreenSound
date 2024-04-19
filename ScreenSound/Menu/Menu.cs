namespace ScreenSound.Menu;

internal class Menu
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

}
