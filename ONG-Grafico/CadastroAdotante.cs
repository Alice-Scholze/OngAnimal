using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class CadastroAdotante : Form
    {
        public int AdotanteId { get; set; }
        public Adopter Adotante { get; set; }

        public AdopterService adopterService { get; set; }
        public CityService cityService { get; set; }

        public CadastroAdotante()
        {
            InitializeComponent();
            ConfigurarCombobox();
            adopterService = new AdopterService();
            cityService = new CityService();
        }

        private void ConfigurarCombobox()
        {
            cbCidade.DisplayMember = "Nome";
            cbCidade.ValueMember = "Id";
        }

        private void CarregarCombobox()
        {
            List<City> cidades = cityService.GetAll();
            cbCidade.DataSource = cidades;
        }

        private void LimparCampos()
        {
            tbCPF.Text = "";
            tbNome.Text = "";
            tbEndereco.Text = "";
            tbEmail.Text = "";
            tbTelefone.Text = "";
            tbObservacao.Text = "";
        }

        private void CadastroAdotante_Load(object sender, EventArgs e)
        {
            CarregarCombobox();

            if (AdotanteId == 0)
            {
                Adotante = new Adopter();
            }
            else
            {
                Adotante = adopterService.GetById(AdotanteId);
                tbCodigo.Text = Adotante.Id.ToString();
                tbCPF.Text = Adotante.CPF.ToString();
                tbNome.Text = Adotante.Name.ToString();
                tbEndereco.Text = Adotante.Address.ToString();
                cbCidade.Text = Adotante.City.Name.ToString();
                tbEmail.Text = Adotante.Email.ToString();
                tbTelefone.Text = Adotante.Phone.ToString();
                tbObservacao.Text = Adotante.Note.ToString();
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
                Adotante.CPF = tbCPF.Text;
                Adotante.Name = tbNome.Text;
                Adotante.Address = tbEndereco.Text;
                //combobox
                long cidadeCod = (long)cbCidade.SelectedValue;
                Adotante.City = cityService.GetById(cidadeCod);
                //fim do combo
                Adotante.Email = tbEmail.Text;
                Adotante.Phone = tbTelefone.Text;
                Adotante.Note  = tbObservacao.Text;
                if (AdotanteId == 0)
                {
                    adopterService.Insert(Adotante);
                    MessageBox.Show("Adotante adicionado com sucesso!");
                }
                else
                {
                    Adotante.Id = AdotanteId;
                    adopterService.Update(Adotante);
                    MessageBox.Show("Adotante alterado com sucesso!");
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
