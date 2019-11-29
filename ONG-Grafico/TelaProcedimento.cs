using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class TelaProcedimento : Form
    {
        Procedure procedimentoProduto = new Procedure();
        public ProcedureService procedureService { get; set; }
        public ProductService productService { get; set; }
        public AnimalService animalService { get; set; }
        public ServiceService serviceService { get; set; }
        public VoluntaryService voluntaryService { get; set; }

        public TelaProcedimento()
        {
            InitializeComponent();
            ConfigurarCombobox();
            ConfigurarDatagrid();
            procedureService = new ProcedureService();
            productService = new ProductService();
            animalService = new AnimalService();
            serviceService = new ServiceService();
            voluntaryService = new VoluntaryService();
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

            cbAnimal.DisplayMember = "Nome";
            cbAnimal.ValueMember = "Id";

            cbServico.DisplayMember = "Descricao";
            cbServico.ValueMember = "Id";

            cbVoluntario.DisplayMember = "Nome";
            cbVoluntario.ValueMember = "Id";

        }

        private void CarregarComboboxProduto()
        {
            List<Product> produtos = productService.GetAll();
            cbProduto.DataSource = produtos;
        }

        private void CarregarComboboxAnimal()
        {
            List<Animal> animais = animalService.GetAll();
            cbAnimal.DataSource = animais;
        }

        private void CarregarComboboxServico()
        {
            List<Service> servicos = serviceService.GetAll();
            cbServico.DataSource = servicos;
        }

        private void CarregarComboboxVoluntario()
        {
            List<Voluntary> voluntarios = voluntaryService.GetAll();
            cbVoluntario.DataSource = voluntarios;
        }

        private void CarregarDados()
        {
            //Carrega os produtos pro grid
            dgProdutos.DataSource = procedimentoProduto.Products.ToList();
        }

        private void TelaProcedimento_Load(object sender, EventArgs e)
        {
            
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {//confirmar
            try
            {
                procedimentoProduto.Animal = new Animal();
                procedimentoProduto.Services = new Service();
                procedimentoProduto.Voluntary = new Voluntary();

                DateTime data;

                var x = DateTime.TryParse(tbData.Text, out data);

                if (x == false)
                {
                    throw new Exception("Data invalida");
                }

                procedimentoProduto.Data = data;


                long animalId = (long)cbAnimal.SelectedValue;
                procedimentoProduto.Animal = animalService.GetById(animalId);

                Int64 servicoId = (Int64)cbServico.SelectedValue;
                procedimentoProduto.Services = serviceService.GetById(servicoId);

                Int64 voluntarioId = (Int64)cbVoluntario.SelectedValue;
                procedimentoProduto.Voluntary = voluntaryService.GetById(voluntarioId);


                procedureService.Insert(procedimentoProduto);

                MessageBox.Show("Procedimento cadastrado com sucesso!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }

            long produtoId = (long)dgProdutos.SelectedRows[0].Cells[0].Value;
            int posicao = 0;
            foreach (Product pos in procedimentoProduto.Products.ToList())
            {
                if (pos.Id == produtoId)
                {
                    break;
                }
                posicao++;
            }
            procedimentoProduto.Products.RemoveAt(posicao);

            CarregarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAdicionarProd_Click(object sender, EventArgs e)
        {
            Product novo = new Product();
            Int64 produtoId = (Int64)cbProduto.SelectedValue;
            novo = productService.GetById(produtoId);
            novo.QuantBuy = Convert.ToDecimal(tbQuantidade.Text);
            novo.Total = novo.QuantBuy * novo.UnitaryValue;
            procedimentoProduto.Products.Add(novo);

            CarregarDados();
        }

        private void TelaProcedimento_Load_1(object sender, EventArgs e)
        {
            CarregarComboboxProduto();
            CarregarComboboxAnimal();
            CarregarComboboxServico();
            CarregarComboboxVoluntario();
            procedimentoProduto.Products = new List<Product>();
        }
    }
}