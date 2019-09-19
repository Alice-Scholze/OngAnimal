using ONG.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class FuncaoRepositorio : BaseRepositorio
    {
        public List<Funcao> FuncoesCadastradas()
        {
            return db.Funcoes.ToList();
        }

        public Funcao BuscarFuncaoPorCodigo(long codigo)
        {
            return db.Funcoes
                       .Where(funcao => funcao.Id == codigo)
                       .FirstOrDefault();
        }

        public void AdicionarFuncao(Funcao funcao)
        {
            db.Funcoes.Add(funcao);
            Salvar();
        }

        public void ApagarFuncao(Funcao funcao)
        {
            db.Funcoes.Remove(funcao);
            Salvar();
        }
    }
}
