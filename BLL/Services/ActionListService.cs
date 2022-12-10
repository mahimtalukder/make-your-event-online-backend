﻿using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ActionListService
    {
        public static ActionListDTO AddAdmin(ActionListDTO action)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ActionListDTO, ActionList>();
                c.CreateMap<ActionList, ActionListDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<ActionList>(action);
            var rt = DataAccessFactory.ActionListDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<ActionListDTO>(rt);
            }
            return null;
        }

        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminDataAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<AdminDTO>>(data);
        }
        public static AdminDTO Get(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<AdminDTO>(data);
        }


        public static AdminDTO Update(AdminDTO admin)
        {

            var cfg = new MapperConfiguration(c => {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Admin>(admin);
            var rt = DataAccessFactory.AdminDataAccess().Update(data);
            if (rt != null)
            {
                return mapper.Map<AdminDTO>(rt);
            }
            return null;
        }

        public static AdminDTO Delete(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().Delete(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<AdminDTO>(data);
        }
    }
}
