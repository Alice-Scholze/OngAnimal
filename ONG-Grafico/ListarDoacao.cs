using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class ListarDoacao : Form
    {
        public DonationService donationService { get; set; }
        public ListarDoacao()
        {
            InitializeComponent();
            ConfigurarDatagrid();
            donationService = new DonationService();
        }

        private void ConfigurarDatagrid()
        {
            dgDoacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDoacao.AutoGenerateColumns = true;
            //dgDoacao.ColumnCount = 5;
            //dgDoacao.ColumnHeadersVisible = true;
            //dgDoacao.Columns[0].Name = "Código";
            //dgDoacao.Columns[0].DataPropertyName = "Id";
            //dgDoacao.Columns[1].Name = "Data";
            //dgDoacao.Columns[1].DataPropertyName = "Data";
            //dgDoacao.Columns[2].Name = "Doador";
            //dgDoacao.Columns[2].DataPropertyName = "Doador";
            //dgDoacao.Columns[3].Name = "Tipo";
            //dgDoacao.Columns[3].DataPropertyName = "Tipo";
            //dgDoacao.Columns[4].Name = "Observação";
            //dgDoacao.Columns[4].DataPropertyName = "Observacao";
            dgDoacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Donation> doacoes = donationService.GetAll();
            dgDoacao.DataSource = doacoes;
        }

        private void ListarDoacao_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaDoacao tela = new TelaDoacao();
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
