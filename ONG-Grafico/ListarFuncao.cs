using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class ListarFuncao : Form
    {
        public FunctionService functionService { get; set; }
        public ListarFuncao()
        {
            InitializeComponent();
            ConfigurarDatagrid();
            functionService = new FunctionService();
        }

        private void ConfigurarDatagrid()
        {
            dgFuncao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgFuncao.AutoGenerateColumns = true;
            //dgFuncao.ColumnCount = 4;
            //dgFuncao.ColumnHeadersVisible = true;
            //dgFuncao.Columns[0].Name = "Código";
            //dgFuncao.Columns[0].DataPropertyName = "Id";
            //dgFuncao.Columns[1].Name = "Nome";
            //dgFuncao.Columns[1].DataPropertyName = "Nome";
            //dgFuncao.Columns[2].Name = "Área";
            //dgFuncao.Columns[2].DataPropertyName = "Area";
            //dgFuncao.Columns[3].Name = "Procedimento";
            //dgFuncao.Columns[3].DataPropertyName = "Procedimento";
            dgFuncao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Function> funcoes = functionService.GetAll();
            dgFuncao.DataSource = funcoes;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastroFuncao tela = new CadastroFuncao();
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgFuncao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma função");
                return;
            }

            long funcaoId = (long)dgFuncao.SelectedRows[0].Cells[0].Value;
            CadastroFuncao tela = new CadastroFuncao();
            tela.FormClosed += Tela_FormClosed;
            tela.FuncaoId = funcaoId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void ListarFuncao_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgFuncao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma função");
                return;
            }

            try
            {
                long funcaoId = (long)dgFuncao.SelectedRows[0].Cells[0].Value;
                var resultado = MessageBox.Show("Tem certeza que deseja excluir a função?", "Apagar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    functionService.Delete(funcaoId);
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
