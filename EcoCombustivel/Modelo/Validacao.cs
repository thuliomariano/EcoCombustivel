using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoCombustivel.Modelo
{
    public class Validacao
    {
        private String mensagem = "";
        public Validacao()
        {

        }

        public string Mensagem { get => mensagem; set => mensagem = value; }
    }
}
