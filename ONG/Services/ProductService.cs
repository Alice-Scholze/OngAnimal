using ONG.Domain;
using ONG.Repository;
using System;
using System.Collections.Generic;

namespace ONG.Services
{
    public class ProductService
    {
        private ProdutoRepositorio productRepository;

        public ProductService()
        {
            productRepository = new ProdutoRepositorio();
        }

        public List<Product> GetAll()
        {
            return productRepository.ProdutosCadastrados();
        }

        public Product GetById(long codigo)
        {
            return productRepository.BuscarProdutoPorCodigo(codigo);
        }

        public void Insert(Product product)
        {
            if (product == null)
                throw new Exception("O produto não pode ser nulo");

            if (string.IsNullOrEmpty(product.Name))
                throw new Exception("O produto precisa ter Name");

            if (product.Type == "Outro")
            {
                if (string.IsNullOrEmpty(product.Other))
                    throw new Exception("Preencha o campo outro");
            }

            productRepository.AdicionarProduto(product);
        }

        public void Delete(long id)
        {
            Product product = productRepository.BuscarProdutoPorCodigo(id);

            if (product == null)
                throw new Exception("Product não encontrado");

            productRepository.Delete(product);
        }

        public void Update(Product produto)
        {
            productRepository.AtualizarProduto(produto);
        }
    }
}
