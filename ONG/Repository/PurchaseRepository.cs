using ONG.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class PurchaseRepository : BaseRepository
    {
        public List<Purchase> GetAll()
        {
            return db.Purchases.ToList();
        }

        public void Insert(Purchase purchase)
        {
            db.Purchases.Add(purchase);
            Save();
        }
    }
}
