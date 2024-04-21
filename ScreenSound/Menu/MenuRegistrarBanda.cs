//using OpenAI_API;
using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuRegistrarBanda : Menu
{

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTitulo("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        Banda banda = new(Console.ReadLine()!);

        if (!ExisteBanda(bandasRegistradas, banda.Nome))
        {
            bandasRegistradas.Add(banda.Nome, banda);
            /***
             * Não funcionando
            var cliente = new OpenAIAPI("API key");
            var chat = cliente.Chat.CreateConversation();
            chat.AppendSystemMessage($"Resuma a banda {banda.Nome} em um parágrafo.");
            string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
            */

            RegistroSucessoEsperar();
            Console.WriteLine($"\nA banda {banda.Nome} foi registrada com sucesso!\n");
        }
        else
        {
            MsgBandaExistente(banda.Nome);
        }
    }
}
