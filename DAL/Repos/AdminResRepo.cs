using DAL.EF;
using DAL.EF.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class AdminResRepo : IRepo<Restaurant, int, Restaurant>
    {
        ClickEatContext db;
        internal AdminResRepo()
        {
            db = new ClickEatContext();
        }
        public Restaurant Add(Restaurant obj)
        {
            db.Restaurants.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            db.Restaurants.Remove(db.Restaurants.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<Restaurant> Get()
        {
            return db.Restaurants.ToList();
        }

        public Restaurant Get(int id)
        {
            return db.Restaurants.Find(id);
        }

        public bool Update(Restaurant obj)
        {
            var ext = db.Restaurants.Find(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
