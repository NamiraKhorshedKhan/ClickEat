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
    public class AdminService
    {
        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Admin, AdminDTO>();
                c.CreateMap<AdminToken, AdminTokenDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<AdminDTO>>(data);
        }
        public static AdminDTO Get(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Admin, AdminDTO>();
                c.CreateMap<AdminToken, AdminTokenDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<AdminDTO>(data);
        }

        public static AdminAdminTokenDTO GetTokens(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Admin, AdminAdminTokenDTO>();
                c.CreateMap<AdminToken, AdminTokenDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<AdminAdminTokenDTO>(data);
        }
        public static AdminDTO Add(AdminDTO data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<Admin>(data);
            var ret = DataAccessFactory.AdminDataAccess().Add(dbobj);
            return mapper.Map<AdminDTO>(ret);

        }
    }
}