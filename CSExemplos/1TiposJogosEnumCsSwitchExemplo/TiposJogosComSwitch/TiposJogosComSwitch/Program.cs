﻿using System;

namespace TiposJogosComSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            TipoJogo tipoJogo = TipoJogo.RPG;

            Console.WriteLine(tipoJogo.GetDescricao());
            // No console --> Role-playing game
        }
    }
}
