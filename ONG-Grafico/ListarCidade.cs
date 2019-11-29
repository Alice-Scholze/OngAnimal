using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class ListarCidade : Form
    {
        public CityService cityService { get; set; }
        public ListarCidade()
        {
            InitializeComponent();
            ConfigurarDatagrid();
            cityService = new CityService();
        }

        private void ConfigurarDatagrid()
        {
            dgCidade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCidade.AutoGenerateColumns = true;
            //dgCidade.ColumnCount = 5;
            //dgCidade.ColumnHeadersVisible = true;
            //dgCidade.Columns[0].Name = "Código";
            //dgCidade.Columns[0].DataPropertyName = "Id";
            //dgCidade.Columns[1].Name = "Nome";
            //dgCidade.Columns[1].DataPropertyName = "Nome";
            //dgCidade.Columns[2].Name = "UF";
            //dgCidade.Columns[2].DataPropertyName = "UF";
            //dgCidade.Columns[3].Name = "País";
            //dgCidade.Columns[3].DataPropertyName = "Pais";
            //dgCidade.Columns[4].Name = "Código Fiscal";
            //dgCidade.Columns[4].DataPropertyName = "CodigoFiscal";
            dgCidade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<City> cidades = cityService.GetAll();
            dgCidade.DataSource = cidades;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastroCidade tela = new CadastroCidade();
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void button3_Click(object sender, EventArgs e) //alterar
        {
            if (dgCidade.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma cidade");
                return;
            }

            long cidadeId = (long)dgCidade.SelectedRows[0].Cells[0].Value;
            CadastroCidade tela = new CadastroCidade();
            tela.FormClosed += Tela_FormClosed;
            tela.CidadeId = cidadeId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void ListarCidade_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgCidade.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma cidade");
                return;
            }

            try
            {
                long cidadeId = (long)dgCidade.SelectedRows[0].Cells[0].Value;
                var resultado = MessageBox.Show("Tem certeza que deseja excluir a cidade?", "Apagar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    cityService.Delete(cidadeId);
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
