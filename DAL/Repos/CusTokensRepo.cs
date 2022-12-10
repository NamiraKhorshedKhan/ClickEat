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
    public class CusTokenRepo : IRepo<CusToken, int, CusToken>
    {
        ClickEatContext db;
        internal CusTokenRepo()
        {
            db = new ClickEatContext();
        }
        public CusToken Add(CusToken obj)
        {
            db.CusTokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbtk = Get(id);
            db.CusTokens.Remove(dbtk);
            return db.SaveChanges() > 0;
        }

        public List<CusToken> Get()
        {
            throw new NotImplementedException();
        }

        public CusToken Get(int id)
        {
            return db.CusTokens.FirstOrDefault(t => t.Tkey.Equals(id));
        }

        public bool Update(CusToken obj)
        {
            var dbtk = Get(obj.Tkey);
            db.Entry(dbtk).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}