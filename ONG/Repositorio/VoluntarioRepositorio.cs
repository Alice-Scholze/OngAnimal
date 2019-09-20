using ONG.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class VoluntarioRepositorio : BaseRepositorio
    {
        public List<Voluntario> VoluntariosCadastrados()
        {
            return db.Voluntarios.ToList();
        }

        public Voluntario BuscarVoluntarioPorCodigo(long codigo)
        {
            return db.Voluntarios
                       .Where(voluntarios => voluntarios.Id == codigo)
                       .FirstOrDefault();
        }

        public void AdicionarVoluntario(Voluntario voluntario)
        {
            db.Voluntarios.Add(voluntario);
            Salvar();
        }

        public void AdicionarSaidaVoluntario(Voluntario voluntario)
        {
            Voluntario voluntarioOld = BuscarVoluntarioPorCodigo(voluntario.Id);

            voluntarioOld.DataSaida = voluntario.DataSaida;

            Salvar();
        }

        public void ApagarVoluntario(Voluntario voluntario)
        {
            db.Voluntarios.Remove(voluntario);
            Salvar();
        }
    }
}
