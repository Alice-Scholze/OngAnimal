using ONG.Domain;
using ONG.Services;
using System;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class CadastroProduto : Form
    {
        public long ProdutoId { get; set; }
        private Product Produto { get; set; }
        public ProductService productService { get; set; }

        public CadastroProduto()
        {
            InitializeComponent();
            productService = new ProductService();
        }

		private void LimparCampos()
		{
			tbTamanho.Text = "";
			tbNome.Text = "";
			gbTipo.Text = "";
			tbOutro.Text = "";
			tbObservacao.Text = "";
		}
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
		{
			try
			{
				Produto.Size = tbTamanho.Text;
				Produto.Name = tbNome.Text;
                // groupbox 
                if (rbMedicamento.Checked)
                {
                    Produto.Type = "Medicamento";
                }
                else if (rbHigiene.Checked)
                {
                    Produto.Type = "Higiene";
                }
                else if (rbAlimento.Checked)
                {
                    Produto.Type = "Alimento";
                }
                else
                {
                    Produto.Type = "Outro";
                    Produto.Other = tbOutro.Text;
                }
                //fim
				Produto.Note = tbObservacao.Text;
				if (ProdutoId == 0)
				{
					productService.Insert(Produto);
					MessageBox.Show("Produto adicionado com sucesso!");
				}
				else
				{
                    Produto.Id = ProdutoId;
                    productService.Update(Produto);
					MessageBox.Show("Produto alterado com sucesso!");
				}
				LimparCampos();
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void CadastroProduto_Load(object sender, EventArgs e)
		{
			if (ProdutoId == 0)
			{
				Produto = new Product();
			}
			else
			{
				Produto = productService.GetById(ProdutoId);
				tbCodigo.Text = Produto.Id.ToString();
                tbTamanho.Text = Produto.Size;
				tbNome.Text = Produto.Name;
                if (Produto.Type == "Medicamento")
                {
                    rbMedicamento.Checked = Produto.Type == "Medicamento";
                }
                if (Produto.Type == "Higiene")
                {
                    rbHigiene.Checked = Produto.Type == "Higiene";
                }
                if (Produto.Type == "Alimento")
                {
                    rbAlimento.Checked = Produto.Type == "Alimento";
                }
                else
                {
                    rbOutro.Checked =  Produto.Type == "Outro";
                }
                tbOutro.Text = Produto.Other;
				tbObservacao.Text = Produto.Note;
			}

		}
	}
}
