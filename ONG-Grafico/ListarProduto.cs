using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class ListarProduto : Form
    {
        public ProductService productService { get; set; }
        public ListarProduto()
        {
            InitializeComponent();
            ConfigurarDatagrid();
            productService = new ProductService();
        }

        private void ConfigurarDatagrid()
        {
            dgProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProdutos.AutoGenerateColumns = true;
            //dgProdutos.ColumnCount = 7;
            //dgProdutos.ColumnHeadersVisible = true;
            //dgProdutos.Columns[0].Name = "Código";
            //dgProdutos.Columns[0].DataPropertyName = "Id";
            //dgProdutos.Columns[1].Name = "Nome";
            //dgProdutos.Columns[1].DataPropertyName = "Nome";
            //dgProdutos.Columns[2].Name = "Tamanho";
            //dgProdutos.Columns[2].DataPropertyName = "Tamanho";
            //dgProdutos.Columns[3].Name = "Tipo Produto";
            //dgProdutos.Columns[3].DataPropertyName = "Tipo";
            //dgProdutos.Columns[4].Name = "Tipo Outro";
            //dgProdutos.Columns[4].DataPropertyName = "Outro";
            //dgProdutos.Columns[5].Name = "Quantidade";
            //dgProdutos.Columns[5].DataPropertyName = "Quantidade";
            //dgProdutos.Columns[6].Name = "Observação";
            //dgProdutos.Columns[6].DataPropertyName = "Observacao";
            dgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Product> produtos = productService.GetAll();
            dgProdutos.DataSource = produtos;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastroProduto tela = new CadastroProduto();
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }

            long produtoId = (long)dgProdutos.SelectedRows[0].Cells[0].Value;
            CadastroProduto tela = new CadastroProduto();
            tela.FormClosed += Tela_FormClosed;
            tela.ProdutoId = produtoId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void ListarProduto_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }

            try
            {
                long produtoId = (long)dgProdutos.SelectedRows[0].Cells[0].Value;
                var resultado = MessageBox.Show("Tem certeza que deseja excluir o produto?", "Apagar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    productService.Delete(produtoId);
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
