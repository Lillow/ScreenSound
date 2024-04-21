using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {

        base.Executar(bandasRegistradas);
        ExibirTitulo("Registro de álbuns");
        Console.Write("\nDigite a banda cujo álbum deseja registrar: ");
        
        if (ExisteBanda(bandasRegistradas, Console.ReadLine()!))
        {
            Console.Write("\nAgora digite o título do álbum: ");
            if (!ExisteAlbum(Banda, Console.ReadLine()!))
            {
                Banda.AdicionarAlbum(Album);
                RegistroSucessoEsperar();
                Console.WriteLine($"\nO álbum {Album.Nome} de {Banda.Nome} foi registrado com sucesso!");
            }
            else
            {
               Console.WriteLine($"\n{Msg}"); 
            }

        }
        else
        {
            Console.WriteLine($"\n{Msg}");
            
        }
        
        /**
         * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
         */
        

    }
}
