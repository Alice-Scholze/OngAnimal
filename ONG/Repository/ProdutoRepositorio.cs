using ONG.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class ProdutoRepositorio : BaseRepository
    {
        public List<Product> ProdutosCadastrados()
        {
            return db.Products.ToList();
        }

        public Product BuscarProdutoPorCodigo(long codigo)
        {
            return db.Products
                       .Where(produto => produto.Id == codigo)
                       .FirstOrDefault();
        }

        public void AdicionarProduto(Product produto)
        {
            db.Products.Add(produto);
            Save();
        }

        public void Delete(Product produto)
        {
            db.Products.Remove(produto);
            Save();
        }

        public void AtualizarProduto(Product produto)
        {
            Product produtoOld = BuscarProdutoPorCodigo(produto.Id);
            produtoOld.Name = produto.Name;
            produtoOld.Note = produto.Note;
            produtoOld.Other = produto.Other;
            produtoOld.QuantBuy = produto.QuantBuy;
            produtoOld.Quantity = produto.Quantity;
            produtoOld.Size = produto.Size;
            produtoOld.Type = produto.Type;
            produtoOld.Total = produto.Total;
            produtoOld.UnitaryValue = produto.UnitaryValue;

            Save();
        }
    }
}
