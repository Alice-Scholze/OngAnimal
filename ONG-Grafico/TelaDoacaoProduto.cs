using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class TelaDoacaoProduto : Form
    {
        public Donation Doa { get; set; }
        public ProductDonation doacaoProduto { get; set; }
        public ProductDonationService productDonationService { get; set; }
        public ProductService productService { get; set; }

        public TelaDoacaoProduto()
        {
            InitializeComponent();
            ConfigurarCombobox();
            ConfigurarDatagrid();
            doacaoProduto = new ProductDonation();
            productService = new ProductService();
            productDonationService = new ProductDonationService();
        }

        private void ConfigurarDatagrid()
        {
            dgProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProdutos.AutoGenerateColumns = false;
            dgProdutos.ColumnCount = 10;
            dgProdutos.ColumnHeadersVisible = true;
            dgProdutos.Columns[0].Name = "Código";
            dgProdutos.Columns[0].DataPropertyName = "Id";
            dgProdutos.Columns[1].Name = "Nome";
            dgProdutos.Columns[1].DataPropertyName = "Nome";
            dgProdutos.Columns[2].Name = "Tamanho";
            dgProdutos.Columns[2].DataPropertyName = "Tamanho";
            dgProdutos.Columns[3].Name = "Tipo Produto";
            dgProdutos.Columns[3].DataPropertyName = "Tipo";
            dgProdutos.Columns[4].Name = "Quantidade de Compra";
            dgProdutos.Columns[4].DataPropertyName = "QuantCompra";
            dgProdutos.Columns[5].Name = "ValorUnitario";
            dgProdutos.Columns[5].DataPropertyName = "ValorUnitario";
            dgProdutos.Columns[5].Visible = false;
            dgProdutos.Columns[6].Name = "Total";
            dgProdutos.Columns[6].DataPropertyName = "Total";
            dgProdutos.Columns[6].Visible = false;
            dgProdutos.Columns[7].Name = "Quantidade";
            dgProdutos.Columns[7].DataPropertyName = "Quantidade";
            dgProdutos.Columns[7].Visible = false;
            dgProdutos.Columns[8].Name = "Outro";
            dgProdutos.Columns[8].DataPropertyName = "Outro";
            dgProdutos.Columns[8].Visible = false;
            dgProdutos.Columns[9].Name = "Observacao";
            dgProdutos.Columns[9].DataPropertyName = "Observacao";
            dgProdutos.Columns[9].Visible = false;
            dgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ConfigurarCombobox()
        {
            cbProduto.DisplayMember = "Nome";
            cbProduto.ValueMember = "Id";
        }

        private void CarregarComboboxProduto()
        {
            List<Product> produtos = productService.GetAll();
            cbProduto.DataSource = produtos;
        }

        private void DoacaoProduto_Load(object sender, EventArgs e)
        {
            CarregarComboboxProduto();
            doacaoProduto.Products = new List<Product>();
        }

        private void CarregarDados()
        {
            //Carrega os produtos pro grid
            dgProdutos.DataSource = doacaoProduto.Products.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product novo = new Product();
            Int64 produtoId = (Int64)cbProduto.SelectedValue;
            novo = productService.GetById(produtoId);
            novo.QuantBuy = Convert.ToDecimal(tbQuantidade.Text);
            novo.Total = novo.QuantBuy * novo.UnitaryValue;
            doacaoProduto.Products.Add(novo);

            CarregarDados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }

            long produtoId = (long)dgProdutos.SelectedRows[0].Cells[0].Value;
            int posicao = 0;
            foreach (Product pos in doacaoProduto.Products.ToList())
            {
                if (pos.Id == produtoId)
                {
                    break;
                }
                posicao++;
            }
            doacaoProduto.Products.RemoveAt(posicao);

            CarregarDados();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                doacaoProduto.Date = Doa.Date;
                doacaoProduto.Donor = Doa.Donor;
                doacaoProduto.Note = Doa.Note;
                doacaoProduto.Type = "Produto";

                productDonationService.Insert(doacaoProduto);
                
                MessageBox.Show("Doação cadastrada com sucesso!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
