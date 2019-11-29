using ONG.Domain;
using ONG.Services;
using System;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class CadastroCaixa : Form
    {
        public CadastroCaixa()
        {
            InitializeComponent();
        }

        private void CadastroCaixa_Load(object sender, EventArgs e)
        {

        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                FinancialBoxService financialBoxService = new FinancialBoxService();
                FinancialBox caixa = new FinancialBox();
                DateTime data;

                var x = DateTime.TryParse(tbData.Text, out data);

                if (x == false)
                {
                    throw new Exception("Data invalida");
                }
                caixa.Date = data;
                caixa.Description = tbDescricao.Text;
                caixa.Value = Convert.ToDecimal(tbValor.Text);
                financialBoxService.Insert(caixa);
                MessageBox.Show("Valor adicionado ao caixa!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
