using GenerativeAI.Models;
using ScreenSound.Modelos;
using ScreenSound.Outros;

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

            var apiKey = ApiKey.Key;

            GeraResumoBanda(apiKey, Banda);

            RegistroSucessoEsperar();
            Console.WriteLine($"\nA banda {Banda.Nome} foi registrada com sucesso!\n");
        }
        else
        {
            Console.WriteLine($"\n{Msg}");
        }
    }

    private async void GeraResumoBanda(string apiKey, Banda banda)
    {
        try
        {
            var model = new GenerativeModel(apiKey);

            var resposta = await model.GenerateContentAsync($"Resuma a banda {banda.Nome} em um parágrafo.");

            banda.Resumo = resposta + "\n\n";
        }
        catch (Exception)
        {
            Console.WriteLine($"\nNão foi possível criar um resumo da banda {Banda.Nome}");
        }

    }

}

