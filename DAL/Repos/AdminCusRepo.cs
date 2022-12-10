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
    public class AdminCusRepo : AdminIRepo<Customer, int, Customer>
    {
        ClickEatContext db;
        internal AdminCusRepo()
        {
            db = new ClickEatContext();
        }
        public Customer Add(Customer obj)
        {
            db.Customers.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            db.Customers.Remove(db.Customers.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<Customer> Get()
        {
            return db.Customers.ToList();
        }

        public Customer Get(int id)
        {
            return db.Customers.Find(id);
        }

        public bool Update(Customer obj)
        {
            var ext = db.Customers.Find(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
