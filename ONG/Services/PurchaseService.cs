using ONG.Domain;
using ONG.Repository;
using System;
using System.Linq;

namespace ONG.Services
{
    public class PurchaseService
    {
        private PurchaseRepository purchaseRepository;

        public PurchaseService()
        {
            purchaseRepository = new PurchaseRepository();
        }

        public void Insert(Purchase purchase)
        {
            FinancialBoxService purchaseService = new FinancialBoxService();
            ProductService productService = new ProductService();

            if (purchase == null)
                throw new Exception("A compra não pode ser nulo");

            if (purchase.Products == null)
                throw new Exception("A compra precisa ter um produto");

            if (purchase.Date == null || purchase.Date == DateTime.MinValue)
                throw new Exception("Informe a data da compra");


            //verifica se há dinheiro em caixa suficiente
            decimal totalCaixa = purchaseService.GetTotal();

            if (purchase.Total > totalCaixa)
                throw new Exception("Não há valor em caixa para realizar a compra. Value disponível R$ " + totalCaixa);

            purchaseRepository.Insert(purchase);

            FinancialBox caixa = new FinancialBox();
            //atualiza o caixa
            caixa.Date = purchase.Date;
            caixa.Description = "Caixa atualizado atravez da compra " + purchase.Id;
            caixa.Value = 0 - purchase.Total;

            purchaseService.Insert(caixa);

            //atualiza o estoque
            foreach (Product productPurchase in purchase.Products.ToList())
            {
                Product product = productService.GetById(productPurchase.Id);

                if (product != null)
                {
                    product.Quantity = productPurchase.Quantity + productPurchase.QuantBuy;
                    product.Note = product.Note + Environment.NewLine + " Quantidade atualizada para "
                    + product.Quantity + " atraves da compra " + purchase.Id;

                    productService.Update(product);
                }
            }
        }
    }
}
