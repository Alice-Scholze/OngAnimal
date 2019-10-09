using ONG.Domain;
using ONG.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Services
{
    public class ProductDonationService
    {
        private ProductDonationRepository productDonationRepository;

        public ProductDonationService()
        {
            productDonationRepository = new ProductDonationRepository();
        }

        public List<ProductDonation> GetAll()
        {
            return productDonationRepository.GetAll();
        }

        public void Insert(ProductDonation donation)
        {
            ProductService productService = new ProductService();

            if (donation == null)
                throw new Exception("A doação não pode ser nula");

            if (donation.Products == null)
                throw new Exception("A doação precisa ter um produto");

            if (donation.Date == null || donation.Date == DateTime.MinValue)
                throw new Exception("Informe a data da doação");

            productDonationRepository.Insert(donation);

            //atualiza o estoque
            foreach (Product produtoDaDoacao in donation.Products.ToList())
            {
                Product product = productService.GetById(produtoDaDoacao.Id);

                if (product != null)
                {
                    product.Quantity = produtoDaDoacao.Quantity + produtoDaDoacao.QuantBuy;
                    product.Note = product.Note + Environment.NewLine + " Quantidade atualizada para "
                    + product.Quantity + " atraves da doacao " + donation.Id;

                    productService.Update(product);
                }
            }
        }
    }
}
