using ScreenSound.Modelos;


namespace ScreenSound.Menu;
internal class MenuRegistrarBanda : Menu
{

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTitulo("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");

        if (!ExisteBanda(bandasRegistradas, Console.ReadLine()!))
        {
            bandasRegistradas.Add(Banda.Nome, Banda);

            GeraResumoBanda(Banda);

            RegistroSucessoEsperar();
            Console.WriteLine($"\nA banda {Banda.Nome} foi registrada com sucesso!\n");
        }
        else
        {
            Console.WriteLine($"\n{Msg}");
        }
    }

}

