using System;
using System.Collections.Generic;
using System.Text;

namespace TiposJogosComAtributo.Atributos
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class Descricao : Attribute
    {
        public string Valor { get; private set; }

        public Descricao(string valor)
        {
            Valor = valor;
        }
    }
}
