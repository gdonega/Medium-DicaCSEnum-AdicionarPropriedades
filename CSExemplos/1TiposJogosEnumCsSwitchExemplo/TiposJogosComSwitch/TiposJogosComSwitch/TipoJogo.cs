using System;
using System.Collections.Generic;
using System.Text;

namespace TiposJogosComSwitch
{
    public enum TipoJogo
    {
        ACAO, AVENTURA, RPG
    }

    public static class TipoJogoDescricao
    {
        public static string GetDescricao(this TipoJogo tipoJogo)
        {
            switch (tipoJogo)
            {
                case TipoJogo.ACAO:
                    return "Ação";
                case TipoJogo.AVENTURA:
                    return "Aventura";
                case TipoJogo.RPG:
                    return "Role-playing game";
            }

            throw new Exception("Descrição não encontrada");
        }
    }
}
