using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ResMenuService
    {
        public static List<ResMenuDTO> Get()
        {
            var data = DataAccessFactory.ResMenuDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Menu, ResMenuDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<ResMenuDTO>>(data);
        }
        public static ResMenuDTO Get(int id)
        {
            var data = DataAccessFactory.ResMenuDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Menu, ResMenuDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<ResMenuDTO>(data);
        }
        public static ResMenuDTO Add(ResMenuDTO data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<ResMenuDTO, Menu>();
                c.CreateMap<Menu, ResMenuDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<Menu>(data);
            var ret = DataAccessFactory.ResMenuDataAccess().Add(dbobj);
            return mapper.Map<ResMenuDTO>(ret);

        }
    }
}