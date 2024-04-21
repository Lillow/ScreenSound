using OpenAI_API;
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
            try
            {
                var cliente = new OpenAIAPI(OpenIaKey);
                var chat = cliente.Chat.CreateConversation();
                chat.AppendSystemMessage($"Resuma a banda {banda.Nome} em um parágrafo.");
                string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
                banda.Resumo = resposta;
            }
            catch (Exception)
            {
                Console.WriteLine($"\nNão foi possível criar um resumo da banda {banda.Nome}");
            }
           RegistroSucessoEsperar();
            Console.WriteLine($"\nA banda {banda.Nome} foi registrada com sucesso!\n");
        }
        else
        {
            MsgBandaExistente(banda.Nome);
        }
    }
}
