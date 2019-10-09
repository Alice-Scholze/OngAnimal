using ONG.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class FinancialBoxRepository : BaseRepository
    {
        public List<FinancialBox> GetAll()
        {
            return db.FinancialBox.ToList();
        }

        public void Insert(FinancialBox financialBox)
        {
            db.FinancialBox.Add(financialBox);
            Save();
        }

        public decimal GetTotal()
        {
            return db.FinancialBox.Select(c => c.Total).Sum();
        }
    }
}
