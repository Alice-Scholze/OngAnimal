using ONG.Domain;

namespace ONG.Repository
{
    public class BaseRepository
    {
        protected OngContext db;

        public BaseRepository()
        {
            db = new OngContext();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
