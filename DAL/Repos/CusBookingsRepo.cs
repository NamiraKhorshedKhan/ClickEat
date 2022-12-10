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
    class CusBookingsRepo : IRepo<Booking, int, Booking>
    {
        ClickEatContext db;
        internal CusBookingsRepo()
        {
            db = new ClickEatContext();
        }
        public Booking Add(Booking obj)
        {
            db.Bookings.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            db.Bookings.Remove(db.Bookings.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<Booking> Get()
        {
            return db.Bookings.ToList();
        }

        public Booking Get(int id)
        {
            return db.Bookings.Find(id);
        }

        public bool Update(Booking obj)
        {
            var ext = db.Bookings.Find(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
