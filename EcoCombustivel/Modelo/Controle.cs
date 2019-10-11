using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoCombustivel.Modelo
{
    public class Controle
    {
        public double CalcularConsumo(Combustivel combustivel)
        {
            //etanol
            Validacao validacao = new Validacao();
            if (validacao.Mensagem.Equals(""))
            {
               return combustivel.Etanol(combustivel.CustoEtanol, combustivel.KmEtanol);
            }
            return 0;
           
        }

        public Double CalcularGasolina(Combustivel combustivel)
        {

            return 0;
        }
    }
}
