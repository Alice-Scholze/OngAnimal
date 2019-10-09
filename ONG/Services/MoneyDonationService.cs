using ONG.Domain;
using ONG.Repository;
using System;

namespace ONG.Services
{
    public class MoneyDonationService
    {
        private MoneyDonationRepository moneyDonationRepository;

        public MoneyDonationService()
        {
            moneyDonationRepository = new MoneyDonationRepository();
        }

        public void Insert(MoneyDonation donation)
        {
            FinancialBoxRepository financialBoxRepository = new FinancialBoxRepository();

            if (donation == null)
                throw new Exception("A doação não pode ser nulo");

            if (donation.Value <= 0)
                throw new Exception("A doação deve ser maior que 0");

            if (string.IsNullOrEmpty(donation.Donor.Name))
                throw new Exception("O doador precisa ter Name");

            if (donation.Date == null || donation.Date == DateTime.MinValue)
                throw new Exception("Informe a data da doação");

            moneyDonationRepository.Insert(donation);

            FinancialBox financialBox = new FinancialBox();
            financialBox.Date = donation.Date;
            financialBox.Description = "Caixa atualizado atraves da doação " + donation.Id;
            financialBox.Value = donation.Value;

            financialBoxRepository.Insert(financialBox);
        }
    }
}
