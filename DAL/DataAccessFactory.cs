using DAL.EF.Model;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<DAL.EF.Model.Admin, int, Admin> AdminDataAccess()
        {
            return new AdminRepo();
        }

        public static IRepo<DAL.EF.Model.Customer, int, Customer> CustomerDataAccess()
        {
            return new CustomerRepo();
        }

        public static IRepo<DAL.EF.Model.Restaurant, int, Restaurant> RestaurantDataAccess()
        {
            return new RestaurantRepo();
        }

        public static IRepo<DAL.EF.Model.Customer, int, Customer> AdminCusDataAccess()
        {
            return new AdminCusRepo();
        }

        public static IRepo<DAL.EF.Model.Restaurant, int, Restaurant> AdminResDataAccess()
        {
            return new AdminResRepo();
        }

        public static IRepo<DAL.EF.Model.AdminToken, int, AdminToken> AdminTokenAccess()
        {
            return new AdminTokenRepo();
        }

        public static IRepo<DAL.EF.Model.Booking, int, Booking> CusBookingsDataAccess()
        {
            return new CusBookingsRepo();
        }

        public static IRepo<DAL.EF.Model.CusToken, int, CusToken> CusTokensDataAccess()
        {
            return new CusTokenRepo();
        }

        public static IRepo<DAL.EF.Model.Menu, int, Menu> ResMenuDataAccess()
        {
            return new ResMenuRepo();
        }

        public static IRepo<DAL.EF.Model.ResToken, int, ResToken> ResTokenDataAccess()
        {
            return new ResTokenRepo();
        }

        public static IAuth AdminAuthDataAccess()
        {
            return new AdminRepo();
        }

        public static IAuth CusAuthDataAccess()
        {
            return new CustomerRepo();
        }

        public static IAuth ResAuthDataAccess()
        {
            return new RestaurantRepo();
        }
    }
}
