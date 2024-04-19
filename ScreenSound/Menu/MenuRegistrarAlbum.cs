using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuRegistrarAlbum : Menu
{



    public MenuRegistrarAlbum(Dictionary<string, Banda> bandasRegistradas) : base(bandasRegistradas)
    {

        Console.Clear();
        ExibirTitulo("Registro de álbuns");
        Console.Write("\nDigite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (ExisteBanda(BandasRegistradas, nomeDaBanda))
        {
            Console.Write("\nAgora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            BandasRegistradas[nomeDaBanda].AdicionarAlbum(new(tituloAlbum));
            Console.WriteLine($"\nO álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
            //VoltarMenu();

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            //VoltarMenu();
        }
        
        /**
         * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
         */
        //VoltarMenu();

    }
}
