using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class ListarRaca : Form
    {
        public RaceService raceService { get; set; }
        public ListarRaca()
        {
            InitializeComponent();
            ConfigurarDatagrid();
            raceService = new RaceService();
        }

        private void ConfigurarDatagrid()
        {
            dgRaca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRaca.AutoGenerateColumns = true;
            dgRaca.ColumnCount = 6;
            dgRaca.ColumnHeadersVisible = true;
            dgRaca.Columns[0].Name = "Código";
            dgRaca.Columns[0].DataPropertyName = "Id";
            dgRaca.Columns[1].Name = "Nome";
            dgRaca.Columns[1].DataPropertyName = "Name";
            dgRaca.Columns[2].Name = "Espécie";
            dgRaca.Columns[2].DataPropertyName = "Specie";
            dgRaca.Columns[3].Name = "Porte";
            dgRaca.Columns[3].DataPropertyName = "Size";
            dgRaca.Columns[4].Name = "Classe";
            dgRaca.Columns[4].DataPropertyName = "Class";
            dgRaca.Columns[5].Name = "Observação";
            dgRaca.Columns[5].DataPropertyName = "Note";
            dgRaca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Race> racas = raceService.GetAll();
            dgRaca.DataSource = racas;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastroRaca tela = new CadastroRaca();
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgRaca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma raça");
                return;
            }

            long racaId = (long)dgRaca.SelectedRows[0].Cells[0].Value;
            CadastroRaca tela = new CadastroRaca();
            tela.FormClosed += Tela_FormClosed;
            tela.RacaId = racaId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void ListarRaca_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgRaca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma raça");
                return;
            }

            try
            {
                long racaId = (long)dgRaca.SelectedRows[0].Cells[0].Value;
                var resultado = MessageBox.Show("Tem certeza que deseja excluir a raça?", "Apagar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    raceService.Delete(racaId);
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
