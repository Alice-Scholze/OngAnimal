using ONG.Domain;
using ONG.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Services
{
    public class ProcedureService
    {
        private ProcedureRepository procedureRepository;
        public ProcedureService()
        {
            procedureRepository = new ProcedureRepository();
        }

        public List<Procedure> GetAll()
        {
            return procedureRepository.GetAll();
        }

        public void Insert(Procedure procedure)
        {
            ProductService productService = new ProductService();

            if (procedure == null)
                throw new Exception("O procedimento não pode ser nulo");

            if (procedure.Data == null || procedure.Data == DateTime.MinValue)
                throw new Exception("Informe a data do procedimento");
            if (procedure.Animal == null)
                throw new Exception("Selecione um animal");

            if (procedure.Services.Vet != "Não")
            {
                if (string.IsNullOrEmpty(procedure.Voluntary.CRM) || procedure.Voluntary.Function.Procedure == "Não")
                {
                    throw new Exception("Este serviço só deve ser realizado por um profissional. Necessário CRM e marcação na função.");

                }
            }

            if (procedure.Products == null || procedure.Services == null)
            {
                throw new Exception("Selecione um produto ou um serviço ao procedimento");
            }

            procedureRepository.Insert(procedure);

            //atualiza o estoque
            foreach (Product produtoDoProcedimento in procedure.Products.ToList())
            {
                Product product = productService.GetById(produtoDoProcedimento.Id);

                if (product != null)
                {
                    product.Quantity = produtoDoProcedimento.Quantity + produtoDoProcedimento.QuantBuy;
                    product.Note = product.Note + Environment.NewLine + " Quantidade atualizada para "
                    + product.Quantity + " atraves do procedimento " + procedure.Id;

                    productService.Update(product);
                }
            }
        }
    }
}
