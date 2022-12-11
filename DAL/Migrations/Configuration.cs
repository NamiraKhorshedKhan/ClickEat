namespace DAL.Migrations
{
    using DAL.EF.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.ClickEatContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.ClickEatContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            string[] admins = new string[] { "Admin1", "Admin2", "Admin3" };
            List<Admin> cts = new List<Admin>();
            foreach (var item in admins)
            {
                cts.Add(new Admin
                {
                    Name = item
                }); ;
            }
            context.Admins.AddOrUpdate(cts.ToArray());
            List<AdminToken> tokens = new List<AdminToken>();
            Random rand = new Random();
            for (int i = 1; i <= 5; i++)
            {
                tokens.Add(new AdminToken()
                {
                    Id = i,
                    Tkey = i,
                    Creation = DateTime.Now,
                    Expiration = DateTime.Now ,
                    AdminID = rand.Next(1, 3)
                });
                ;
            }
            context.AdminTokens.AddOrUpdate(tokens.ToArray());
        }
    }
}
