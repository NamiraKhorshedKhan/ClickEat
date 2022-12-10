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
    public class ResTokenRepo : IRepo<ResToken, int, ResToken>
    {
        ClickEatContext db;
        internal ResTokenRepo()
        {
            db = new ClickEatContext();
        }
        public ResToken Add(ResToken obj)
        {
            db.ResTokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbtk = Get(id);
            db.ResTokens.Remove(dbtk);
            return db.SaveChanges() > 0;
        }

        public List<ResToken> Get()
        {
            throw new NotImplementedException();
        }

        public ResToken Get(int id)
        {
            return db.ResTokens.FirstOrDefault(t => t.Tkey.Equals(id));
        }

        public bool Update(ResToken obj)
        {
            var dbtk = Get(obj.Tkey);
            db.Entry(dbtk).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}