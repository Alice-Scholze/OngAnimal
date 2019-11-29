using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class ListarServico : Form
    {
        public ServiceService serviceService { get; set; }
        public ListarServico()
        {
            InitializeComponent();
            ConfigurarDatagrid();
            serviceService = new ServiceService();
        }

        private void ConfigurarDatagrid()
        {
            dgServico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgServico.AutoGenerateColumns = true;
            //dgServico.ColumnCount = 4;
            //dgServico.ColumnHeadersVisible = true;
            //dgServico.Columns[0].Name = "Código";
            //dgServico.Columns[0].DataPropertyName = "Id";
            //dgServico.Columns[1].Name = "Descrição";
            //dgServico.Columns[1].DataPropertyName = "Descricao";
            //dgServico.Columns[2].Name = "Tipo de Serviço";
            //dgServico.Columns[2].DataPropertyName = "Tipo";
            //dgServico.Columns[3].Name = "Necessita Veterinário?";
            //dgServico.Columns[3].DataPropertyName = "Veterinario";
            dgServico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Service> servicos = serviceService.GetAll();
            dgServico.DataSource = servicos;
        }

        private void ListarServico_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastroServico tela = new CadastroServico();
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dgServico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um serviço");
                return;
            }

            long servicoId = (long)dgServico.SelectedRows[0].Cells[0].Value;
            CadastroServico tela = new CadastroServico();
            tela.FormClosed += Tela_FormClosed;
            tela.ServicoId = servicoId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgServico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um serviço");
                return;
            }

            try
            {
                long servicoId = (long)dgServico.SelectedRows[0].Cells[0].Value;
                var resultado = MessageBox.Show("Tem certeza que deseja excluir o serviço?", "Apagar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    serviceService.Delete(servicoId);
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
