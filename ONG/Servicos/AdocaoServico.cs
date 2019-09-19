using ONG.Dominio;
using ONG.Repositorio;
using System.Collections.Generic;

namespace ONG.Servicos
{
    public class AdocaoServico
    {
        private AdocaoRepositorio adocaoRepositorio;

        public AdocaoServico()
        {
            adocaoRepositorio = new AdocaoRepositorio();
        }

        public List<Adocao> AdocoesCadastradas()
        {
            return adocaoRepositorio.AdocoesCadastradas();
        }
    }
}
