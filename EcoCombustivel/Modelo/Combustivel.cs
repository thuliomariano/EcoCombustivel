using System;

namespace EcoCombustivel.Modelo
{
    public class Combustivel
    {
        //etanol
        private double custoEtanol;
        private double kmEtanol;

        //gasolina
        private double custoGasolina;
        private double kmGasolina;

        //rodagem total percorrida
        private int km_dia;
        private double rodagem;

        //mensagem de resposta
        private String mensagem;
        private double resposta;

        //encapsulamento das variaveis
        public double CustoEtanol { get => custoEtanol; set => custoEtanol = value; }
        public double KmEtanol { get => kmEtanol; set => kmEtanol = value; }
        public double CustoGasolina { get => custoGasolina; set => custoGasolina = value; }
        public double KmGasolina { get => kmGasolina; set => kmGasolina = value; }

        public string Mensagem { get => mensagem; set => mensagem = value; }
        public double Resposta { get => resposta; set => resposta = value; }
        public int Km_dia { get => km_dia; set => km_dia = value; }
        public double Rodagem { get => rodagem; set => rodagem = value; }

        //Construtor para inicializar valor do qtd de dias e os km rodados
        public Combustivel(int km_dia, double rodagem)
        {
            Km_dia = km_dia;
            Rodagem = rodagem;
        }

        //calcular o gasto com etanol
        public double Etanol(double custoEtanol, double kmEtanol)
        {
            CustoEtanol = custoEtanol;
            KmEtanol = kmEtanol;

            return (Rodagem * Km_dia) / KmEtanol * CustoEtanol;
        }

        //calcular o gasto com a gasolina
        public double Gasolina(double custoGasolina, double kmGasolina)
        {
            CustoGasolina = custoGasolina;
            KmGasolina = kmGasolina;

            return (KmGasolina / (Rodagem * Km_dia)) * CustoGasolina;
        }




    }
}
