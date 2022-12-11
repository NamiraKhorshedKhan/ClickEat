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
    public class CusBookingService
    {
        public static List<CusBookingsDTO> Get()
        {
            var data = DataAccessFactory.CusBookingsDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Booking, CusBookingsDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<CusBookingsDTO>>(data);
        }
        public static CusBookingsDTO Get(int id)
        {
            var data = DataAccessFactory.CusBookingsDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Booking, CusBookingsDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<CusBookingsDTO>(data);
        }
        public static CusBookingsDTO Add(CusBookingsDTO data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<CusBookingsDTO, Booking>();
                c.CreateMap<Booking, CusBookingsDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<Booking>(data);
            var ret = DataAccessFactory.CusBookingsDataAccess().Add(dbobj);
            return mapper.Map<CusBookingsDTO>(ret);

        }
    }
}