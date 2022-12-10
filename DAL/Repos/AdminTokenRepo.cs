using DAL.EF;
using DAL.EF.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AdminTokenRepo : AdminIRepo<AdminToken, int, AdminToken>
    {
        ClickEatContext db;
        internal AdminTokenRepo()
        {
            db = new ClickEatContext();
        }
        public AdminToken Add(AdminToken obj)
        {
            db.AdminTokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbtk = Get(id);
            db.AdminTokens.Remove(dbtk);
            return db.SaveChanges() > 0;
        }

        public List<AdminToken> Get()
        {
            throw new NotImplementedException();
        }

        public AdminToken Get(int id)
        {
            return db.AdminTokens.FirstOrDefault(t => t.Tkey.Equals(id));
        }

        public bool Update(AdminToken obj)
        {
            var dbtk = Get(obj.Tkey);
            db.Entry(dbtk).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}