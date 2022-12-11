using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserCustomerServices
    {
        public static List<UserCustomerDTO> Get()
        {
            var UserList = UserServices.Get();
            var CustomerList = CustomerServices.Get();
            var CustomerUserList = new List<UserCustomerDTO>();

            var CustomerUsers = UserList.Zip(CustomerList, (U, C) => new { User = U, Customer = C });

            foreach (var obj in CustomerUsers)
            {
                CustomerUserList.Add(new UserCustomerDTO
                {
                    Id = obj.User.Id,
                    Username = obj.User.Username,
                    Password = obj.User.Password,
                    UserType = obj.User.UserType,
                    Name = obj.Customer.Name,
                    Email = obj.Customer.Email,
                    Phone = obj.Customer.Phone,
                    Address = obj.Customer.Address,
                    ProfilePicture = obj.Customer.ProfilePicture,
                    ShippingAreaId = obj.Customer.ShippingAreaId
                });
            }
            if(CustomerList != null) return CustomerUserList;
            return null;
        }

        public static UserCustomerDTO Get(int id)
        {
            var User = UserServices.Get(id);
            var Customer = CustomerServices.Get(id);

            if(User != null && Customer != null)
            {
                var CustomerUser = new UserCustomerDTO
                {
                    Id = User.Id,
                    Username = User.Username,
                    Password = User.Password,
                    UserType = User.UserType,
                    Name = Customer.Name,
                    Email = Customer.Email,
                    Phone = Customer.Phone,
                    Address = Customer.Address,
                    ProfilePicture = Customer.ProfilePicture,
                    ShippingAreaId = Customer.ShippingAreaId,
                };
                return CustomerUser;
            }
            return null;
        }

        public static UserCustomerDTO Add(UserCustomerDTO CustomerUser)
        {
            var User = UserServices.Add(new UserDTO { Password = CustomerUser.Password, Username = CustomerUser.Username, UserType = CustomerUser.UserType });
            var Customer = CustomerServices.Add(new CustomerDTO { Id = User.Id, Name = CustomerUser.Name, Email = CustomerUser.Email, Phone = CustomerUser.Phone, Address = CustomerUser.Address, ProfilePicture = CustomerUser.ProfilePicture, ShippingAreaId = CustomerUser.ShippingAreaId });
            if (User != null && Customer != null)
            {
                var NewCustomerUser = new UserCustomerDTO
                {
                    Id = User.Id,
                    Username = User.Username,
                    Password = User.Password,
                    UserType = User.UserType,
                    Name = Customer.Name,
                    Email = Customer.Email,
                    Phone = Customer.Phone,
                    Address = Customer.Address,
                    ProfilePicture = Customer.ProfilePicture,
                    ShippingAreaId = Customer.ShippingAreaId,
                };
                return NewCustomerUser;
            }
            return null;
        }

        public static UserCustomerDTO Update(UserCustomerDTO CustomerUser)
        {
            var User = UserServices.Update(new UserDTO {Id=CustomerUser.Id, Password = CustomerUser.Password, Username = CustomerUser.Username, UserType = CustomerUser.UserType });
            var Customer = CustomerServices.Update(new CustomerDTO { Id = User.Id, Name = CustomerUser.Name, Email = CustomerUser.Email, Phone = CustomerUser.Phone, Address = CustomerUser.Address, ProfilePicture = CustomerUser.ProfilePicture, ShippingAreaId = CustomerUser.ShippingAreaId });
            if (User != null && Customer != null)
            {
                var NewCustomerUser = new UserCustomerDTO
                {
                    Id = User.Id,
                    Username = User.Username,
                    Password = User.Password,
                    UserType = User.UserType,
                    Name = Customer.Name,
                    Email = Customer.Email,
                    Phone = Customer.Phone,
                    Address = Customer.Address,
                    ProfilePicture = Customer.ProfilePicture,
                    ShippingAreaId = Customer.ShippingAreaId,
                };
                return NewCustomerUser;
            }
            return null;
        }

        public static bool Delete(int id)
        {
            if (!CustomerServices.Delete(id)) return false;
            if (!UserServices.Delete(id)) return false;
            return true;
        }

    }
}
