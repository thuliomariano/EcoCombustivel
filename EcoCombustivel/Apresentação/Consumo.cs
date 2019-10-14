using EcoCombustivel.Modelo;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace EcoCombustivel
{
    public partial class Form1 : Form
    {
        public int validar;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //instância as classes controle e combustivel
            Controle controle = new Controle();

            //instância o construtor para inicializar o valor da rodagem
            Combustivel combustivel = new Combustivel(1, 1);

            //inserir os dados do form para a classe combustivel
            try
            {

            combustivel.CustoEtanol = Convert.ToDouble(txbPrecoAlcool.Text);
            combustivel.KmEtanol = Convert.ToDouble(txbKmPorLitroAlcool.Text);
            }
            catch (Exception ErroDeConversaoDecimal)
            {
               
            }
            try
            {
                combustivel.CustoGasolina = Convert.ToDouble(txbPrecoGasolina.Text);
                combustivel.KmGasolina = Convert.ToDouble(txbKmPorLitroGasolina.Text);
            }
            catch (Exception ErroDeConversaoDecimal)
            {
              

            }
            //dados alternativos para um resultado total
            try
            {
                combustivel.Km_dia = Convert.ToInt32(txbDias.Text);
                combustivel.Rodagem = Convert.ToDouble(txbKmTotal.Text);
            }
            catch (Exception ErroDeConversaoDecimal)
            {
               
            }
   
            //realiza o calculo da classe controle e envia para o label
            lblResultado.Text = $" {combustivel}                    R$ {Convert.ToString(controle.CalcularEtanol(combustivel).ToString("F2", CultureInfo.InvariantCulture))}                      R$   {Convert.ToString(controle.CalcularGasolina(combustivel).ToString("F2", CultureInfo.InvariantCulture))}";

            //Condicional para exibir uma informação caso o usuário não consiga realizar o calculo.
            if (lblResultado.Text == "")
            {
                MessageBox.Show("Erro, tente novamente");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //fecha o form
            Close();
        }

    
    }
}
