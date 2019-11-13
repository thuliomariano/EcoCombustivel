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
            try
            {
            Controle controle = new Controle();
            Combustivel combustivel = new Combustivel(1, 1);
            combustivel.CustoEtanol = Convert.ToDouble(txbPrecoAlcool.Text);
            combustivel.KmEtanol = Convert.ToDouble(txbKmPorLitroAlcool.Text);
            combustivel.CustoGasolina = Convert.ToDouble(txbPrecoGasolina.Text);
            combustivel.KmGasolina = Convert.ToDouble(txbKmPorLitroGasolina.Text);
            combustivel.Km_dia = Convert.ToInt32(txbDias.Text);
            combustivel.Rodagem = Convert.ToDouble(txbKmTotal.Text);
            lblResultado.Text = $" {combustivel}                    R$ {Convert.ToString(controle.CalcularEtanol(combustivel).ToString("F2", CultureInfo.InvariantCulture))}                      R$   {Convert.ToString(controle.CalcularGasolina(combustivel).ToString("F2", CultureInfo.InvariantCulture))}";

            }
            catch (FormatException error)
            {
                MessageBox.Show("Erro de formatação: " + error.Message);
            }
            catch (OverflowException error)
            {
                MessageBox.Show("Erro: " + error.Message);
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro inesperado: " + error.Message);
            }
            if (lblResultado.Text == "")
            {
                MessageBox.Show("Erro, tente novamente");
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
