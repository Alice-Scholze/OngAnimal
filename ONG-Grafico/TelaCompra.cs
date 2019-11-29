using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class TelaCompra : Form
    {
        Purchase compra = new Purchase();
        public PurchaseService purchaseService { get; set; }
        public ProductService productService { get; set; }

        public TelaCompra()
        {
            InitializeComponent();
            ConfigurarCombobox();
            ConfigurarDatagrid();
            purchaseService = new PurchaseService();
            productService = new ProductService();
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
            dgProdutos.Columns[5].Name = "Valor Unitário";
            dgProdutos.Columns[5].DataPropertyName = "ValorUnitario";
            dgProdutos.Columns[6].Name = "Total";
            dgProdutos.Columns[6].DataPropertyName = "Total";
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
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TelaCompra_Load(object sender, EventArgs e)
        {
            CarregarComboboxProduto();
            compra.Products = new List<Product>();
        }

        private void CarregarDados()
        {
            //Carrega os produtos pro grid
            dgProdutos.DataSource = compra.Products.ToList();

            //Calcula o total e informa no tbTotal
            decimal total = 0;
            foreach (Product valor in compra.Products)
            {
                total = total + valor.Total;
            }
            compra.Total = total;
            tbTotal.Text = "R$ " + Convert.ToString(compra.Total);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product novo = new Product();
            Int64 produtoId = (Int64)cbProduto.SelectedValue;
            novo = productService.GetById(produtoId);
            novo.QuantBuy = Convert.ToDecimal(tbQuantidade.Text);
            novo.UnitaryValue = Convert.ToDecimal(tbUnitario.Text);
            novo.Total = novo.QuantBuy * novo.UnitaryValue;
            compra.Products.Add(novo);
                        
            CarregarDados();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data;

                var x = DateTime.TryParse(tbData.Text, out data);

                if (x == false)
                {
                    throw new Exception("Data invalida");
                }

                compra.Date = data;

                purchaseService.Insert(compra);

                MessageBox.Show("Compra cadastrada com sucesso!");

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarDados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
            foreach(Product pos in compra.Products.ToList())
            {
                if(pos.Id == produtoId)
                {
                    break;
                }
                posicao++;
            }
            compra.Products.RemoveAt(posicao);

            CarregarDados();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
