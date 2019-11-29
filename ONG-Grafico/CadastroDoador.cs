using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class CadastroDoador : Form
    {
        public long DoadorId { get; set; }
        private Donor Doador { get; set; }
        public DoadorServico doadorServico { get; set; }
        public CityService cityService { get; set; }

        public CadastroDoador()
        {
            InitializeComponent();
            ConfigurarCombobox();
            doadorServico = new DoadorServico();
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
            cbCidade.Text = "";
            tbEndereco.Text = "";
            tbEmail.Text = "";
            tbTelefone.Text = "";
            gbPessoa.Text = "";
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
                Doador.CPF = tbCPF.Text;
                Doador.Name = tbNome.Text;
                //combobox
                long cidadeCod = (long)cbCidade.SelectedValue;
                Doador.City = cityService.GetById(cidadeCod);
                //fim do combo
                Doador.Address = tbEndereco.Text;
                Doador.Email = tbEmail.Text;
                Doador.Phone = tbTelefone.Text;
                // groupbox 
                if (rbFisica.Checked)
                {
                    Doador.Pessoa = "Física";
                }
                else
                {
                    Doador.Pessoa = "Jurídico";
                }
                //fim
                Doador.Note = tbObservacao.Text;
                if (DoadorId == 0)
                {
                    doadorServico.Insert(Doador);
                    MessageBox.Show("Doador adicionado com sucesso!");
                }
                else
                {
                    Doador.Id = DoadorId;
                    doadorServico.Update(Doador);
                    MessageBox.Show("Doador alterado com sucesso!");
                }
                LimparCampos();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CadastroDoador_Load_1(object sender, EventArgs e)
        {
            CarregarCombobox();

            if (DoadorId == 0)
            {
                Doador = new Donor();
            }
            else
            {
                Doador = doadorServico.GetById(DoadorId);
                tbCodigo.Text = Doador.Id.ToString();
                tbCPF.Text = Doador.CPF;
                tbNome.Text = Doador.Name;
                cbCidade.Text = Doador.City.Name;
                tbEndereco.Text = Doador.Address;
                tbEmail.Text = Doador.Email;
                tbTelefone.Text = Doador.Phone;
                if (Doador.Pessoa == "Física")
                {
                    rbFisica.Checked = Doador.Pessoa == "Física";
                }
                else
                {
                   rbJuridica.Checked = Doador.Pessoa == "Jurídico";
                }
                tbObservacao.Text = Doador.Note;
            }
        }
    }
}
