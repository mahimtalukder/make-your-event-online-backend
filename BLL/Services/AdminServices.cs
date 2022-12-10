using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminServices
    {
        public static UserDTO AddUser(UserDTO user)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<UserDTO, User>();
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<User>(user);
            var rt = DataAccessFactory.UserDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<UserDTO>(rt);
            }
            return null;
        }
    }
}
