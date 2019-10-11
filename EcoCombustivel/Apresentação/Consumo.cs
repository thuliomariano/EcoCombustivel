using EcoCombustivel.Modelo;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace EcoCombustivel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //instancia as classes controle e combustivel
            Controle controle = new Controle();

            //instancia o construtor para inicializar o valor da rodagem
            Combustivel combustivel = new Combustivel(1, 1);

            //inserir os dados do form para a classe combustivel
            combustivel.CustoEtanol = Convert.ToDouble(txbPrecoAlcool.Text);
            combustivel.KmEtanol = Convert.ToDouble(txbKmPorLitroAlcool.Text);

            //dados alternativos para um resultado total
            try
            {
                combustivel.Km_dia = Convert.ToInt32(txbDias.Text);
                combustivel.Rodagem = Convert.ToDouble(txbKmTotal.Text);
            }
            catch (Exception)
            {
                   
            }

            //realiza o calculo da classe controle e envia para o label
            lblResultado.Text = $"             R$ {Convert.ToString(controle.CalcularConsumo(combustivel).ToString("F2", CultureInfo.InvariantCulture))}    R$ ";

            //Condicional para exibir uma informação caso o usuário não consiga realizar o calculo.
            if (lblResultado.Text == "")
            {
                MessageBox.Show("Erro, tente novamente");
            }
        }
    }
}
