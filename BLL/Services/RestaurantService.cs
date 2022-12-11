using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Model;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RestaurantService
    {
        public static List<RestaurantDTO> Get()
        {
            var data = DataAccessFactory.RestaurantDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Restaurant, RestaurantDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<RestaurantDTO>>(data);
        }
        public static RestaurantDTO Get(int id)
        {
            var data = DataAccessFactory.RestaurantDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Restaurant, RestaurantDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<RestaurantDTO>(data);
        }
        public static RestaurantDTO Add(RestaurantDTO data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<RestaurantDTO, Restaurant>();
                c.CreateMap<Restaurant, RestaurantDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<Restaurant>(data);
            var ret = DataAccessFactory.RestaurantDataAccess().Add(dbobj);
            return mapper.Map<RestaurantDTO>(ret);
        }
    }
}

