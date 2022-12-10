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
    public class OrganizerServices
    {
        public static List<OrganizerDTO> Get()
        {
            var data = DataAccessFactory.OrganizerDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Organizer, OrganizerDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<List<OrganizerDTO>>(data);
            return rt;
        }

        public static OrganizerDTO Get(int id)
        {
            var data = DataAccessFactory.OrganizerDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Organizer, OrganizerDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<OrganizerDTO>(data);
            return rt;
        }

        public static OrganizerDTO Add(OrganizerDTO user)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrganizerDTO, Organizer>();
                cfg.CreateMap<Organizer, OrganizerDTO>();
            });
            var mapper = new Mapper(config);
            var dbOrganizer = mapper.Map<Organizer>(user);
            var rt = DataAccessFactory.OrganizerDataAccess().Add(dbOrganizer);
            if (rt != null)
            {
                return mapper.Map<OrganizerDTO>(rt);
            }
            return null;
        }

        public static OrganizerDTO Update(OrganizerDTO user)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrganizerDTO, Organizer>();
                cfg.CreateMap<Organizer, OrganizerDTO>();
            });
            var mapper = new Mapper(config);
            var organizer = mapper.Map<Organizer>(user);
            var rt = DataAccessFactory.OrganizerDataAccess().Update(organizer);
            if (rt != null)
            {
                return mapper.Map<OrganizerDTO>(rt);
            }
            return null;
        }

        public static bool Delete(int Id)
        {
            return DataAccessFactory.OrganizerDataAccess().Delete(Id);
        }
    }
}
