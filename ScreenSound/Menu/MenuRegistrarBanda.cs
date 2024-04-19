using ScreenSound.Modelos;

namespace ScreenSound.Menu
{
    internal class MenuRegistrarBanda : Menu
    {
        public MenuRegistrarBanda(Dictionary<string, Banda> listaBandas)
        {
            Console.Clear();
            ExibirTitulo("Registro de bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            Banda banda = new(Console.ReadLine()!);
            listaBandas.Add(banda.Nome, banda);

            Console.WriteLine($"\nA banda {banda.Nome} foi registrada com sucesso!\n");
            //VoltarMenu();
        }
    }
}
