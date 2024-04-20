using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {

        Console.Clear();
        ExibirTitulo("Registro de álbuns");
        Console.Write("\nDigite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        

        if (ExisteBanda(bandasRegistradas, nomeDaBanda))
        {
            Banda banda = new(nomeDaBanda);
            Console.Write("\nAgora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (!ExisteAlbum(banda, tituloAlbum))
            {
                bandasRegistradas[nomeDaBanda].AdicionarAlbum(new(tituloAlbum));
                RegistroSucessoEsperar();
                Console.WriteLine($"\nO álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
                
            }
            else
            {
               MsgAlbumExistente(tituloAlbum);
               
            }

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            
        }
        
        /**
         * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
         */
        

    }
}
