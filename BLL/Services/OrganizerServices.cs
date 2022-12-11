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

        public static UserOrganizerDTO Add(UserOrganizerDTO OrganizerData)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<UserDTO, User>();
                c.CreateMap<User, UserDTO>();
                c.CreateMap<OrganizerDTO, Organizer>();
            });
            var mapper = new Mapper(config);
            var user = new UserDTO()
            {
                Username = OrganizerData.Username,
                Password = OrganizerData.Password,
                UserType = OrganizerData.UserType,
            };
            var dbuser = DataAccessFactory.UserDataAccess().Add(mapper.Map<User>(user));

            if(dbuser != null)
            {
                var organizer = new OrganizerDTO()
                {
                    Id = dbuser.Id,
                    Name = OrganizerData.Name,
                    Email = OrganizerData.Email,
                    Phone = OrganizerData.Phone,
                    Address = OrganizerData.Address,
                    ProfilePicture = OrganizerData.ProfilePicture,
                };
                var dbornizer = DataAccessFactory.OrganizerDataAccess().Add(mapper.Map<Organizer>(organizer));

                if (dbuser != null)
                {
                    UserOrganizerDTO data = new UserOrganizerDTO()
                    {
                        Id = dbuser.Id,
                        Username = dbuser.Username,
                        Password = dbuser.Password,
                        UserType = dbuser.UserType,
                        Name = organizer.Name,
                        Email = organizer.Email,
                        Phone = organizer.Phone,
                        Address = organizer.Address,
                        ProfilePicture = organizer.ProfilePicture,
                    };
                    return data;
                }
                return null;

               
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
