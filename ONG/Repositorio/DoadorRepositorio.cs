using ONG.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class DoadorRepositorio : BaseRepositorio
    {
        public List<Doador> DoadoresCadastrados()
        {
            return db.Doadores.ToList();
        }

        public Doador BuscarDoadorPorCodigo(long codigo)
        {
            return db.Doadores
                       .Where(doador => doador.Id == codigo)
                       .FirstOrDefault();
        }

        public void AdicionarDoador(Doador doador)
        {
            db.Doadores.Add(doador);
            Salvar();
        }

        public void ApagarDoador(Doador doador)
        {
            db.Doadores.Remove(doador);
            Salvar();
        }
    }
}
