using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class TelaCaixa : Form
    {
        public FinancialBoxService financialBoxService { get; set; }
        public TelaCaixa()
        {
            InitializeComponent();
            ConfigurarDatagrid();
            financialBoxService = new FinancialBoxService();
        }

        private void ConfigurarDatagrid()
        {
            dgCaixa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCaixa.AutoGenerateColumns = false;
            dgCaixa.ColumnCount = 5;
            dgCaixa.ColumnHeadersVisible = true;
            dgCaixa.Columns[0].Name = "Código";
            dgCaixa.Columns[0].DataPropertyName = "Id";
            dgCaixa.Columns[1].Name = "Descrição";
            dgCaixa.Columns[1].DataPropertyName = "Descricao";
            dgCaixa.Columns[2].Name = "Data";
            dgCaixa.Columns[2].DataPropertyName = "Data";
            dgCaixa.Columns[3].Name = "Valor";
            dgCaixa.Columns[3].DataPropertyName = "Valor";
            dgCaixa.Columns[4].Name = "Total";
            dgCaixa.Columns[4].DataPropertyName = "Total";
            dgCaixa.Columns[4].Visible = false;
            dgCaixa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<FinancialBox> caixa = financialBoxService.GetAll();
            dgCaixa.DataSource = caixa;
            Decimal totalDisp = 0;
            foreach(FinancialBox total in caixa)
            {
                totalDisp = totalDisp + total.Value;
            }
            tbTotal.Text = "R$ " + Convert.ToString(totalDisp);

        }
        private void Caixa_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastroCaixa tela = new CadastroCaixa();
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }
    }
}
