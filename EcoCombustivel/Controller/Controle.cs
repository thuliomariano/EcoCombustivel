using System;

namespace EcoCombustivel.Modelo
{
    public class Controle
    {
        public double CalcularEtanol(Combustivel combustivel)
        {
            //etanol         
            return combustivel.Etanol(combustivel.CustoEtanol, combustivel.KmEtanol);
        }

        public Double CalcularGasolina(Combustivel combustivel)
        {
            //Gasolina
            return combustivel.Gasolina(combustivel.CustoGasolina, combustivel.KmGasolina);
        }
    }
}
