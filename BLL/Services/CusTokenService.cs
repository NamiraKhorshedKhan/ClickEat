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
    public class CusTokenService
    {
        public static List<CusTokenDTO> Get()
        {
            var data = DataAccessFactory.CusTokensDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<CusToken, CusTokenDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<CusTokenDTO>>(data);
        }
        public static CusTokenDTO Get(int id)
        {
            var data = DataAccessFactory.CusTokensDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<CusToken, CusTokenDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<CusTokenDTO>(data);
        }
        public static CusTokenDTO Add(CusTokenDTO data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<CusTokenDTO, CusToken>();
                c.CreateMap<CusToken, CusTokenDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<CusToken>(data);
            var ret = DataAccessFactory.CusTokensDataAccess().Add(dbobj);
            return mapper.Map<CusTokenDTO>(ret);

        }
    }
}