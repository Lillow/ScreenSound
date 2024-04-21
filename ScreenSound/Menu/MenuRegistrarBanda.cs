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

        if (!ExisteBanda(bandasRegistradas, Console.ReadLine()!))
        {
            bandasRegistradas.Add(Banda.Nome, Banda);

            try
            {
                var cliente = new OpenAIAPI(OpenAIkey);
                var chat = cliente.Chat.CreateConversation();
                chat.AppendSystemMessage($"Resuma a banda {Banda.Nome} em um parágrafo.");
                string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
                Banda.Resumo = resposta;
            }
            catch (Exception)
            {
                Console.WriteLine($"\nNão foi possível criar um resumo da banda {Banda.Nome}");
            }

            RegistroSucessoEsperar();
            Console.WriteLine($"\nA banda {Banda.Nome} foi registrada com sucesso!\n");
        }
        else
        {
            Console.WriteLine($"\n{Msg}");
        }
    }
}
