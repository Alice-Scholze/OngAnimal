using ONG.Domain;
using ONG.Services;
using System;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class TelaDoacaoDinheiro : Form
    {
        public Donation Doa { get; set; }
        public MoneyDonation DoacaoDinheiro { get; set; }
        public MoneyDonationService moneyDonationService { get; set; }

        public TelaDoacaoDinheiro()
        {
            InitializeComponent();
            moneyDonationService = new MoneyDonationService();
        }

        private void TelaDoacaoDinheiro_Load(object sender, EventArgs e)
        {

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            { 
                MoneyDonation dinheiro = new MoneyDonation();
                dinheiro.Donor = new Donor();
                dinheiro.Date = Doa.Date;
                dinheiro.Donor = Doa.Donor;
                dinheiro.Note = Doa.Note;
                dinheiro.Type = "Dinheiro";
                dinheiro.Value = Convert.ToDecimal(tbValor.Text);

                moneyDonationService.Insert(dinheiro);
                MessageBox.Show("Doação cadastrada com sucesso!");

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
    }
}
