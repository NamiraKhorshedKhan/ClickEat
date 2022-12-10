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
    public class AdminRepo: AdminIRepo <Admin, int, Admin>
    {
        ClickEatContext db;
        internal AdminRepo()
        {
            db = new ClickEatContext();
        }
        public Admin Add(Admin obj)
        {
            db.Admins.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            db.Admins.Remove(db.Admins.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();
        }

        public Admin Get(int id)
        {
            return db.Admins.Find(id);
        }

        public bool Update(Admin obj)
        {
            var ext = db.Admins.Find(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
