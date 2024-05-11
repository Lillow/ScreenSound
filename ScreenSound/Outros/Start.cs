// Screen Sound

using ScreenSound.Menu;
using ScreenSound.Modelos;

namespace ScreenSound.Outros;

internal class Start
{
     public Start ()
     {
        Dictionary<string, Banda> bandasRegistradas = [];
        bandasRegistradas.Add("Linkin Park", new Banda("Linkin Park"));
        bandasRegistradas["Linkin Park"].AdicionarNota(new Avaliacao(10));
        bandasRegistradas["Linkin Park"].AdicionarNota(new Avaliacao(9));
        bandasRegistradas["Linkin Park"].AdicionarNota(new Avaliacao(9.5f));
        bandasRegistradas["Linkin Park"].AdicionarAlbum(new Album("Meteora"));
        bandasRegistradas["Linkin Park"].Resumo = "Formada em 1996, o Linkin Park é uma banda americana de rock alternativo que alcançou sucesso global com sua mistura única de rock pesado, rap e melodias cativantes. Liderada pelo vocalista Chester Bennington e pelo rapper Mike Shinoda, a banda se destacou com seu álbum de estreia, Hybrid Theory (2000), que vendeu mais de 30 milhões de cópias em todo o mundo. Com álbuns subsequentes como Meteora (2003) e Minutes to Midnight (2007), o Linkin Park cimentou seu status como uma das bandas mais vendidas e influentes dos anos 2000. Sua música aborda temas de perda, raiva e alienação, conectando-se profundamente com ouvintes de todas as idades. A trágica perda de Bennington em 2017 marcou um momento sombrio para a banda, mas seu legado continua a inspirar fãs e músicos em todo o mundo.\r\n";

        bandasRegistradas.Add("Slipknot", new("Slipknot"));
        bandasRegistradas["Slipknot"].Resumo = "\nO Slipknot é uma banda americana de metal fundada em 1995 em Des Moines, Iowa. Conhecidos por suas máscaras assustadoras, uniformes e performances energéticas ao vivo, eles são considerados um dos pioneiros do gênero nu metal. A banda é composta por nove membros, incluindo os vocalistas Corey Taylor e Sid Wilson, os percussionistas Shawn Crahan e Chris Fehn, os guitarristas Mick Thomson e Jim Root, o baixista Alessandro Venturella, o baterista Jay Weinberg e o tecladista Craig Jones. O Slipknot lançou seis álbuns de estúdio, incluindo os sucessos de platina \"Iowa\" (2001) e \"Vol. 3: (The Subliminal Verses)\" (2004), que lhes renderam um Grammy Award de Melhor Performance de Metal. Eles são conhecidos por sua música pesada, letras sombrias e espetáculos ao vivo intensos que incluem pirotecnia, percussão e elementos teatrais.\r\n";

        bandasRegistradas.Add("System of a Down", new("System of a Down"));
        bandasRegistradas["System of a Down"].Resumo = "\nSystem of a Down foi uma banda de metal alternativo de Los Angeles, Califórnia, formada em 1994. Conhecida por sua música agressiva, letras politicamente carregadas e melodias cativantes, a banda era composta pelo vocalista Serj Tankian, o guitarrista Daron Malakian, o baixista Shavo Odadjian e o baterista John Dolmayan. Com cinco álbuns de estúdio aclamados pela crítica, incluindo \"Toxicity\" (2001) e \"Mezmerize\" (2005), o System of a Down ganhou um Grammy Award e vendeu mais de 40 milhões de discos em todo o mundo. A banda ficou em hiato desde 2006, mas se reuniu para uma série de shows ao vivo e lançou duas músicas novas em 2020.\r\n";

        bandasRegistradas.Add("Coldplay", new("Coldplay"));
        bandasRegistradas["Coldplay"].Resumo = "\nColdplay é uma banda britânica de rock alternativo formada em Londres em 1996. Liderada pelo vocalista Chris Martin, a banda é conhecida por seus arranjos orquestrais épicos, letras introspectivas e refrãos cativantes. Com nove álbuns de estúdio lançados, Coldplay vendeu mais de 100 milhões de cópias em todo o mundo e ganhou inúmeros prêmios, incluindo 9 prêmios Grammy. A banda é aclamada por suas performances ao vivo emocionantes e pela capacidade de criar músicas que conectam com uma ampla gama de ouvintes, tornando-se uma das bandas mais populares e bem-sucedidas do século XXI.\r\n";


        MenuExibirOpcoes menuExibirOpcoes = new();
        menuExibirOpcoes.Executar(bandasRegistradas);
    }







}
