using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class ListarDoador : Form
    {
        public DoadorServico doadorServico { get; set; }
        public ListarDoador()
        {
            InitializeComponent();
            ConfigurarDatagrid();
            doadorServico = new DoadorServico();
        }

        private void ConfigurarDatagrid()
        {
            dgDoador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDoador.AutoGenerateColumns = true;
            //dgDoador.ColumnCount = 9;
            //dgDoador.ColumnHeadersVisible = true;
            //dgDoador.Columns[0].Name = "Código";
            //dgDoador.Columns[0].DataPropertyName = "Id";
            //dgDoador.Columns[1].Name = "CPF";
            //dgDoador.Columns[1].DataPropertyName = "CPF";
            //dgDoador.Columns[2].Name = "Nome";
            //dgDoador.Columns[2].DataPropertyName = "Nome";
            //dgDoador.Columns[3].Name = "Email";
            //dgDoador.Columns[3].DataPropertyName = "Email";
            //dgDoador.Columns[4].Name = "Tipo Pessoa";
            //dgDoador.Columns[4].DataPropertyName = "Pessoa";
            //dgDoador.Columns[5].Name = "Endereço";
            //dgDoador.Columns[5].DataPropertyName = "Endereco";
            //dgDoador.Columns[6].Name = "Cidade";
            //dgDoador.Columns[6].DataPropertyName = "Cidade";
            //dgDoador.Columns[7].Name = "Telefone";
            //dgDoador.Columns[7].DataPropertyName = "Telefone";
            //dgDoador.Columns[8].Name = "Observação";
            //dgDoador.Columns[8].DataPropertyName = "Observacao";
            dgDoador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Donor> doadores = doadorServico.GetAll();
            dgDoador.DataSource = doadores;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastroDoador tela = new CadastroDoador();
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void button3_Click(object sender, EventArgs e) //alterar
        {
            if (dgDoador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um doador");
                return;
            }

            long doadorId = (long)dgDoador.SelectedRows[0].Cells[0].Value;
            CadastroDoador tela = new CadastroDoador();
            tela.FormClosed += Tela_FormClosed;
            tela.DoadorId = doadorId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void ListarDoador_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgDoador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um doador");
                return;
            }

            try
            {
                long doadorId = (long)dgDoador.SelectedRows[0].Cells[0].Value;
                var resultado = MessageBox.Show("Tem certeza que deseja excluir o doador?", "Apagar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    doadorServico.Delete(doadorId);
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
