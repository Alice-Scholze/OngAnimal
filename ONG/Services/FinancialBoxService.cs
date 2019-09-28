using ONG.Domain;
using ONG.Repository;
using System;
using System.Collections.Generic;

namespace ONG.Services
{
    public class FinancialBoxService
    {
        private FinancialBoxRepository financialBoxRepository;

        public FinancialBoxService()
        {
            financialBoxRepository = new FinancialBoxRepository();
        }

        public List<FinancialBox> GetAll()
        {
            return financialBoxRepository.GetAll();
        }

        public void Insert(FinancialBox financialBox)
        {
            if (financialBox == null)
                throw new Exception("O caixa não pode ser nulo");

            if (string.IsNullOrEmpty(financialBox.Description))
                throw new Exception("É necessário adicionar uma descrição para entrada de dinheiro no caixa");

            financialBox.Total = financialBoxRepository.GetTotal() + financialBox.Value;

            financialBoxRepository.Insert(financialBox);
        }

        public decimal GetTotal()
        {
            return financialBoxRepository.GetTotal();
        }
    }
}
