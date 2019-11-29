using ONG.Domain;
using ONG.Services;
using System;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class CadastroFuncao : Form
    {
        public long FuncaoId { get; set; }
        private Function Funcao { get; set; }
        public FunctionService functionService { get; set; }

        public CadastroFuncao()
        {
            InitializeComponent();
            functionService = new FunctionService();
        }

		private void LimparCampos()
		{
			tbNome.Text = "";
            tbArea.Text = "";
			cbProcedimento.Text = "";
		}

		private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void btConfirmar_Click(object sender, EventArgs e)
		{
			try
			{
				Funcao.Name = tbNome.Text;
                Funcao.Area = tbArea.Text;
                // realiza procedimento 
                if (cbProcedimento.Checked)
                {
                    Funcao.Procedure = "Sim";
                }
                else
                {
                    Funcao.Procedure = "Não";
                }
                //fim
                if (FuncaoId == 0)
				{
					functionService.Insert(Funcao);
					MessageBox.Show("Função adicionada com sucesso!");
				}
				else
				{
                    Funcao.Id = FuncaoId;
                    functionService.Update(Funcao);
					MessageBox.Show("Função alterada com sucesso!");
				}
				LimparCampos();
				this.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void CadastroFuncao_Load(object sender, EventArgs e)
        {
			if(FuncaoId == 0)
			{
				Funcao = new Function();
			}
			else
			{
				Funcao = functionService.GetById(FuncaoId);
				tbCodigo.Text = Funcao.Id.ToString();
				tbNome.Text = Funcao.Name;
                tbArea.Text = Funcao.Area;
				cbProcedimento.Checked = Funcao.Procedure == "Sim";
			}
        }		
	}
}
