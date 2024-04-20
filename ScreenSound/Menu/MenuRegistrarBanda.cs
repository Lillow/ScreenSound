using ScreenSound.Modelos;

namespace ScreenSound.Menu
{
    internal class MenuRegistrarBanda : Menu
    {
        public MenuRegistrarBanda(Dictionary<string, Banda> bandasRegistradas) //: base(bandasRegistradas)
        {
            Console.Clear();
            ExibirTitulo("Registro de bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            Banda banda = new(Console.ReadLine()!);

            if (!ExisteBanda(bandasRegistradas, banda.Nome))
            {
            bandasRegistradas.Add(banda.Nome, banda);
            RegistroSucessoEsperar();
            Console.WriteLine($"\nA banda {banda.Nome} foi registrada com sucesso!\n");
            VoltarMenu(bandasRegistradas);
            }
            else
            {
                MsgBandaExistente(banda.Nome);
                VoltarMenu(bandasRegistradas);
            }

        }
    }
}
