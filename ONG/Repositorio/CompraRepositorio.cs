using ONG.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class CompraRepositorio : BaseRepositorio
    {
        public List<Compra> ComprasCadastradas()
        {
            return db.Compras.ToList();
        }

        public void AdicionarCompra(Compra compra)
        {
            db.Compras.Add(compra);
            Salvar();
        }
    }
}
