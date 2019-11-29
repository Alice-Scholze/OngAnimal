using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class ListarVoluntario : Form
    {
        public VoluntaryService voluntaryService { get; set; }
        public ListarVoluntario()
        {
            InitializeComponent();
            ConfigurarDatagrid();
            voluntaryService = new VoluntaryService();
        }

        private void ConfigurarDatagrid()
        {
            dgVoluntario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgVoluntario.AutoGenerateColumns = false;
            dgVoluntario.ColumnCount = 12;
            dgVoluntario.ColumnHeadersVisible = true;
            dgVoluntario.Columns[0].Name = "Código";
            dgVoluntario.Columns[0].DataPropertyName = "Id";
            dgVoluntario.Columns[1].Name = "CPF";
            dgVoluntario.Columns[1].DataPropertyName = "CPF";
            dgVoluntario.Columns[2].Name = "Função";
            dgVoluntario.Columns[2].DataPropertyName = "Funcao";
            dgVoluntario.Columns[3].Name = "CRM";
            dgVoluntario.Columns[3].DataPropertyName = "CRM";
            dgVoluntario.Columns[4].Name = "Nome";
            dgVoluntario.Columns[4].DataPropertyName = "Nome";
            dgVoluntario.Columns[5].Name = "Email";
            dgVoluntario.Columns[5].DataPropertyName = "Email";
            dgVoluntario.Columns[6].Name = "Endereço";
            dgVoluntario.Columns[6].DataPropertyName = "Endereco";
            dgVoluntario.Columns[7].Name = "Cidade";
            dgVoluntario.Columns[7].DataPropertyName = "Cidade";
            dgVoluntario.Columns[8].Name = "Telefone";
            dgVoluntario.Columns[8].DataPropertyName = "Telefone";
            dgVoluntario.Columns[9].Name = "Data Entrada";
            dgVoluntario.Columns[9].DataPropertyName = "DataEntrada";
            dgVoluntario.Columns[10].Name = "Data Saída";
            dgVoluntario.Columns[10].DataPropertyName = "DataSaida";
            dgVoluntario.Columns[11].Name = "Observação";
            dgVoluntario.Columns[11].DataPropertyName = "Observacao";
            dgVoluntario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Voluntary> voluntarios = voluntaryService.GetAll();
            dgVoluntario.DataSource = voluntarios;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastroVoluntario tela = new CadastroVoluntario();
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgVoluntario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um voluntário");
                return;
            }

            long voluntarioId = (long)dgVoluntario.SelectedRows[0].Cells[0].Value;
            CadastroVoluntario tela = new CadastroVoluntario();
            tela.FormClosed += Tela_FormClosed;
            tela.VoluntarioId = voluntarioId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void ListarVoluntario_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgVoluntario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um voluntário");
                return;
            }

            try
            {
                long voluntarioId = (long)dgVoluntario.SelectedRows[0].Cells[0].Value;
                var resultado = MessageBox.Show("Tem certeza que deseja excluir o voluntário?", "Apagar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    voluntaryService.Delete(voluntarioId);
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

        private void btSaida_Click(object sender, EventArgs e)
        {
            if (dgVoluntario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um voluntário");
                return;
            }

            long voluntarioId = (long)dgVoluntario.SelectedRows[0].Cells[0].Value;
            CadastroSaidaVoluntario tela = new CadastroSaidaVoluntario();
            tela.FormClosed += Tela_FormClosed;
            tela.VoluntarioId = voluntarioId;
            tela.MdiParent = this.MdiParent;
            tela.Show();

        }
    }
}
