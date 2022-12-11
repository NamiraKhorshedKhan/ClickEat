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
    public class ResTokenService
    {
        public static List<ResTokenDTO> Get()
        {
            var data = DataAccessFactory.ResTokenDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<ResToken, ResTokenDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<ResTokenDTO>>(data);
        }
        public static ResTokenDTO Get(int id)
        {
            var data = DataAccessFactory.ResTokenDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<ResToken, ResTokenDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<ResTokenDTO>(data);
        }
        public static ResTokenDTO Add(ResTokenDTO data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<ResTokenDTO, ResToken>();
                c.CreateMap<ResToken, ResTokenDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<ResToken>(data);
            var ret = DataAccessFactory.ResTokenDataAccess().Add(dbobj);
            return mapper.Map<ResTokenDTO>(ret);

        }
    }
}