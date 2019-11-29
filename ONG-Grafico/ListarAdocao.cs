using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class ListarAdocao : Form
    {
        public AdoptionService adoptionService { get; set; }
        public ListarAdocao()
        {
            InitializeComponent();
            ConfigurarDatagrid();
            adoptionService = new AdoptionService();
        }

        private void ConfigurarDatagrid()
        {
            dgAdoacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAdoacao.AutoGenerateColumns = true;
            dgAdoacao.ColumnCount = 4;
            dgAdoacao.ColumnHeadersVisible = true;
            dgAdoacao.Columns[0].Name = "Código";
            dgAdoacao.Columns[0].DataPropertyName = "Id";
            dgAdoacao.Columns[1].Name = "Data";
            dgAdoacao.Columns[1].DataPropertyName = "Date";
            dgAdoacao.Columns[2].Name = "Animal";
            dgAdoacao.Columns[2].DataPropertyName = "Animal";
            dgAdoacao.Columns[3].Name = "Adotante";
            dgAdoacao.Columns[3].DataPropertyName = "Adopter";
            dgAdoacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Adoption> adoacoes = adoptionService.GetAll();
            dgAdoacao.DataSource = adoacoes;
        }

        private void ListarAdocao_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaAdocao tela = new TelaAdocao();
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
