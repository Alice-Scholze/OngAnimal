using ONG.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class ServicoRepositorio : BaseRepositorio
    {
        public List<Servico> ServicosCadastrados()
        {
            return db.Servicos.ToList();
        }

        public Servico BuscarServicoPorCodigo(long codigo)
        {
            return db.Servicos
                       .Where(servicos => servicos.Id == codigo)
                       .FirstOrDefault();
        }

        public void AdicionarServico(Servico servico)
        {
            db.Servicos.Add(servico);
            Salvar();
        }

        public void ApagarServico(Servico servico)
        {
            db.Servicos.Remove(servico);
            Salvar();
        }
    }
}
