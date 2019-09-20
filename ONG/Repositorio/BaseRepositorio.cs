using ONG.Dominio;

namespace ONG.Repositorio
{
    public class BaseRepositorio
    {
        protected OngContext db;

        public BaseRepositorio()
        {
            db = new OngContext();
        }

        public void Salvar()
        {
            db.SaveChanges();
        }
    }
}
