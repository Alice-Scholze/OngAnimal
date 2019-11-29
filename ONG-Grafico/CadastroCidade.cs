using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class CadastroCidade : Form
    {
        public long CidadeId { get; set; }
        private City Cidade { get; set; }
        public CityService cityService { get; set; }

        public CadastroCidade()
        {
            InitializeComponent();
            cityService = new CityService();
        }

        private void LimparCampos()
        {
            tbCodigo.Text = "";
            tbNome.Text = "";
            tbCFiscal.Text = "";
            tbPais.Text = "";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroCidade_Load(object sender, EventArgs e)
        {
            cbUF.SelectedIndex = 0;

            if (CidadeId == 0)
            {
                Cidade = new City();
            }
            else
            {
                Cidade = cityService.GetById(CidadeId);
                tbCodigo.Text = Cidade.Id.ToString();
                tbNome.Text = Cidade.Name;
                cbUF.Text = Cidade.UF.ToString();             
                tbCFiscal.Text = Cidade.MunicipalCode.ToString();
                tbPais.Text = Cidade.Country;
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Cidade.Name = tbNome.Text;
                Cidade.UF = cbUF.Text;
                Cidade.MunicipalCode = Convert.ToInt64(tbCFiscal.Text);
                Cidade.Country = tbPais.Text;
                if(CidadeId == 0)
                {
                    cityService.Insert(Cidade);
                    MessageBox.Show("Cidade adicionada com sucesso!");
                }
                else
                {
                    Cidade.Id = CidadeId;
                    cityService.Update(Cidade);
                    MessageBox.Show("Cidade alterada com sucesso!");
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
