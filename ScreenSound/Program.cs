// Screen Sound


using ScreenSound.Menu;
using ScreenSound.Modelos;


Dictionary <string, Banda> bandasRegistradas = [];
bandasRegistradas.Add("Linkin Park", new Banda("Linkin Park"));
bandasRegistradas["Linkin Park"].AdicionarNota(new Avaliacao(10));
bandasRegistradas["Linkin Park"].AdicionarNota(new Avaliacao(9));
bandasRegistradas["Linkin Park"].AdicionarNota(new Avaliacao(9.5f));

bandasRegistradas.Add("Slipknot", new("Slipknot"));
bandasRegistradas.Add("System of a Down", new("System of a Down"));
bandasRegistradas.Add("Coldplay", new("Coldplay"));




void ExibirLogo()
{
    const string mensaemDeBoasVindas = @"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

Boas vindas ao Screen Sound
";
    Console.WriteLine(mensaemDeBoasVindas);

}

MenuExibirOpcoes menuExibirOpcoes = new(bandasRegistradas);

menuExibirOpcoes.ExibirOpcoesMenu();

