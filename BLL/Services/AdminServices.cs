using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminServices
    {
        public static AdminDTO AddAdmin(AdminDTO admin)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Admin>(admin);
            var rt = DataAccessFactory.AdminDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<AdminDTO>(rt);
            }
            return null;
        }
    }
}
