using ONG.Domain;
using ONG.Services;
using System;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class CadastroServico : Form
    {
        public long ServicoId { get; set; }
        private Service Servico { get; set; }
        public ServiceService serviceService { get; set; }

        public CadastroServico()
        {
            InitializeComponent();
            serviceService = new ServiceService();
        }

        private void LimparCampos()
        {
            tbDescricao.Text = "";
            gbTipo.Text = "";
            cbVeterinario.Text = "";
        }

        private void CadastroServico_Load(object sender, EventArgs e)
        {
            if (ServicoId == 0)
            {
                Servico = new Service();
            }
            else
            {
                Servico = serviceService.GetById(ServicoId);
                tbCodigo.Text = Servico.Id.ToString();
                tbDescricao.Text = Servico.Description;
                if(Servico.Type == "Higiene")
                {
                    rbHigiene.Checked = Servico.Type == "Higiene";
                }
                else
                {
                    rbMedico.Checked = Servico.Type == "Médico";
                }
                
                cbVeterinario.Checked = Servico.Vet == "Sim";
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Servico.Description = tbDescricao.Text;
                // groupbox 
                if (rbHigiene.Checked)
                {
                    Servico.Type = "Higiene";
                }
                else
                {
                    Servico.Type = "Médico";
                }
                //fim
                // serviço veterinario 
                if(cbVeterinario.Checked)
                {
                    Servico.Vet = "Sim";
                }
                else
                {
                    Servico.Vet = "Não";
                }
                //fim
                if (ServicoId == 0)
                {
                    serviceService.Insert(Servico);
                    MessageBox.Show("Serviço adicionado com sucesso!");
                }
                else
                {
                    Servico.Id = ServicoId;
                    serviceService.Update(Servico);
                    MessageBox.Show("Serviço alterado com sucesso!");
                }
                LimparCampos();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
