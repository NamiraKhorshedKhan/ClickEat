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
    public class AdminTokenService
    {
        public static List<AdminTokenDTO> Get()
        {
            var data = DataAccessFactory.AdminTokenDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<AdminToken, AdminTokenDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<AdminTokenDTO>>(data);
        }
        public static AdminTokenDTO Get(int id)
        {
            var data = DataAccessFactory.AdminTokenDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<AdminToken, AdminTokenDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<AdminTokenDTO>(data);
        }
        public static AdminTokenDTO Add(AdminTokenDTO data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<AdminTokenDTO, AdminToken>();
                c.CreateMap<AdminToken, AdminTokenDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<AdminToken>(data);
            var ret = DataAccessFactory.AdminTokenDataAccess().Add(dbobj);
            return mapper.Map<AdminTokenDTO>(ret);

        }
    }
}