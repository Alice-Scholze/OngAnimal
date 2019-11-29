using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class TelaDoacao : Form
    {

        public long DoacaoId { get; set; }
        private Donation Doacao { get; set; }
        public DonationService donationService { get; set; }
        public DoadorServico doadorServico { get; set; }
        public TelaDoacao()
        {
            InitializeComponent();
            ConfigurarCombobox();
            donationService = new DonationService();
            doadorServico = new DoadorServico();
        }

        private void ConfigurarCombobox()
        {
            cbAdotante.DisplayMember = "Nome";
            cbAdotante.ValueMember = "Id";
        }

        private void CarregarCombobox()
        {
            List<Donor> doadores = doadorServico.GetAll();
            cbAdotante.DataSource = doadores;
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

                Donation doacao = new Donation();
                doacao.Donor = new Donor();

                doacao.Date = data;
                Int64 adotanteId = (Int64)cbAdotante.SelectedValue;
                doacao.Donor = doadorServico.GetById(adotanteId);
                doacao.Note = tbObservacao.Text;
                if (rbDinheiro.Checked)
                {
                    doacao.Type = "Dinheiro";
                    TelaDoacaoDinheiro tela = new TelaDoacaoDinheiro();
                    tela.FormClosed += Tela_FormClosed;
                    tela.Doa = doacao;
                    tela.MdiParent = this.MdiParent;
                    tela.Show();
                }
                else
                {
                    doacao.Type = "Produto";
                    TelaDoacaoProduto tela = new TelaDoacaoProduto();
                    tela.FormClosed += Tela_FormClosed;
                    tela.Doa = doacao;
                    tela.MdiParent = this.MdiParent;
                    tela.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void Doacao_Load(object sender, EventArgs e)
        {
            CarregarCombobox();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
