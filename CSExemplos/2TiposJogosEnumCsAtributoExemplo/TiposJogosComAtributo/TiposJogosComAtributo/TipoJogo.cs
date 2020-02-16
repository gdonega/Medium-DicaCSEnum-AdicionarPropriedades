using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TiposJogosComAtributo.Atributos;

namespace TiposJogosComAtributo
{
    public enum TipoJogo
    {
        [Descricao("Ação")]
        ACAO,
        [Descricao("Aventura")]
        AVENTURA,
        [Descricao("Role-playing game")]
        RPG
    }
    public static class TipoFilmeDescricao
    {
        public static string GetDescricao(this TipoJogo tipoJogo)
        {
            // Recupera o tipo da enum
            var tipoJogoType = typeof(TipoJogo);

            var valorDescricao = tipoJogoType
                .GetMember(tipoJogo.ToString()).FirstOrDefault() // Recupera ACAO, AVENTURA ou RPG de acordo com a instancia 
                .GetCustomAttributes(typeof(Descricao), false) // Recupera o atributo Descricao
                .Select(x => (Descricao)x) // Faz o cast
                .FirstOrDefault() // Recupera o primeiro objeto
                .Valor // Recupera o valor Ação, Aventura ou Role-playing game
                ;

            // Retorna o valor
            return valorDescricao;
        }
    }
}
