﻿using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuExibirBandas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTitulo("Exibindo bandas registradas");
        foreach (var nomeBanda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {nomeBanda}");
        }
    }
}
