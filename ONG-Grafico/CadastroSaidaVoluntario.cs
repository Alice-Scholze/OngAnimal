﻿using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class CadastroSaidaVoluntario : Form
    {
        public long VoluntarioId { get; set; }
        private Voluntary Voluntario { get; set; }
        public VoluntaryService voluntaryService { get; set; }
        public CityService cityService { get; set; }
        public FunctionService functionService { get; set; }
        public CadastroSaidaVoluntario()
        {
            InitializeComponent();
            ConfigurarCombobox();
            voluntaryService = new VoluntaryService();
            cityService = new CityService();
            functionService = new FunctionService();
        }

        private void ConfigurarCombobox()
        {
            cbCidade.DisplayMember = "Nome";
            cbCidade.ValueMember = "Id";
            cbFuncao.DisplayMember = "Nome";
            cbFuncao.ValueMember = "Id";
        }

        private void CarregarComboboxCidade()
        {
            List<City> cidades = cityService.GetAll();
            cbCidade.DataSource = cidades;
        }

        private void CarregarComboboxFuncao()
        {
            List<Function> funcoes = functionService.GetAll();
            cbFuncao.DataSource = funcoes;
        }

        private void LimparCampos()
        {
            tbCPF.Text = "";
            cbFuncao.Text = "";
            tbCRM.Text = "";
            tbNome.Text = "";
            cbCidade.Text = "";
            tbEndereco.Text = "";
            tbEmail.Text = "";
            tbTelefone.Text = "";
            tbEntrada.Text = "";
            tbObservacao.Text = "";
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Voluntario.CPF = tbCPF.Text;
                //combobox
                long funcaoCod = (long)cbFuncao.SelectedValue;
                Voluntario.Function = functionService.GetById(funcaoCod);
                //fim do combo
                Voluntario.CRM = tbCRM.Text;
                Voluntario.Name = tbNome.Text;
                //combobox
                long cidadeCod = (long)cbCidade.SelectedValue;
                Voluntario.City = cityService.GetById(cidadeCod);
                //fim do combo
                Voluntario.Address = tbEndereco.Text;
                Voluntario.Email = tbEmail.Text;
                Voluntario.Phone = tbTelefone.Text;
                //entrada da data
                DateTime data;
                var x = DateTime.TryParse(tbEntrada.Text, out data);
                if (x == false)
                {
                    throw new Exception("Data invalida");
                }
                Voluntario.DateEntry = data;
                //fim entrada da data
                //saida da data
                DateTime dataSaida;
                var y = DateTime.TryParse(tbSaida.Text, out dataSaida);
                if (y == false)
                {
                    throw new Exception("Data invalida");
                }
                Voluntario.DateDeparture = dataSaida;
                //fim saida da data
                Voluntario.Id = VoluntarioId;
                voluntaryService.Update(Voluntario);
                MessageBox.Show("Voluntário alterado com sucesso!");
                LimparCampos();
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

        private void CadastroSaidaVoluntario_Load(object sender, EventArgs e)
        {
            CarregarComboboxCidade();
            CarregarComboboxFuncao();

            Voluntario = voluntaryService.GetById(VoluntarioId);
            tbCodigo.Text = Voluntario.Id.ToString();
            tbCPF.Text = Voluntario.CPF;
            cbFuncao.Text = Voluntario.Function.ToString();
            tbCRM.Text = Voluntario.CRM.ToString();
            tbNome.Text = Voluntario.Name;
            cbCidade.Text = Voluntario.City.Name;
            tbEndereco.Text = Voluntario.Address;
            tbEmail.Text = Voluntario.Email;
            tbTelefone.Text = Voluntario.Phone;
            tbEntrada.Text = Voluntario.DateEntry.ToString();
            tbObservacao.Text = Voluntario.Note;
        }
    }
}
