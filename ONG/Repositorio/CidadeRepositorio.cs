using ONG.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class CidadeRepositorio : BaseRepositorio
    {
        public List<Cidade> CidadesCadastradas()
        {
            return db.Cidades.ToList();
        }

        public Cidade BuscarCidadePorCodigo(long codigo)
        {
            return db.Cidades
                       .Where(cidade => cidade.Id == codigo)
                       .FirstOrDefault();
        }

        public void AdicionarCidade(Cidade cidade)
        {
            db.Cidades.Add(cidade);
            Salvar();
        }

        public void ApagarCidade(Cidade cidade)
        {
            db.Cidades.Remove(cidade);
            Salvar();
        }
    }
}
