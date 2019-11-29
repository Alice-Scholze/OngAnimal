using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class ListarAdotante : Form
    {
        public AdopterService adopterService { get; set; }
        public ListarAdotante()
        {
            InitializeComponent();
            ConfigurarDatagrid();
            adopterService = new AdopterService();
        }

        private void ConfigurarDatagrid()
        {
            dgAdotantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAdotantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Adopter> adotantes = adopterService.GetAll();
            dgAdotantes.DataSource = adotantes;
        }
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastroAdotante tela = new CadastroAdotante();
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void ListarAdotante_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dgAdotantes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um adotante");
                return;
            }

            int adotanteId = (int)dgAdotantes.SelectedRows[0].Cells[0].Value;
            CadastroAdotante tela = new CadastroAdotante();
            tela.FormClosed += Tela_FormClosed;
            tela.AdotanteId = adotanteId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgAdotantes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um adotante");
                return;
            }

            try
            {
                long adotanteId = (long)dgAdotantes.SelectedRows[0].Cells[0].Value;
                var resultado = MessageBox.Show("Tem certeza que deseja excluir o adotante?", "Apagar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    adopterService.Delete(adotanteId);
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
