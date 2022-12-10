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
    public class ResMenuRepo : IRepo<Menu, int, Menu>
    {
        ClickEatContext db;
        internal ResMenuRepo()
        {
            db = new ClickEatContext();
        }
        public Menu Add(Menu obj)
        {
            db.Menus.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            db.Menus.Remove(db.Menus.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<Menu> Get()
        {
            return db.Menus.ToList();
        }

        public Menu Get(int id)
        {
            return db.Menus.Find(id);
        }

        public bool Update(Menu obj)
        {
            var ext = db.Menus.Find(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
