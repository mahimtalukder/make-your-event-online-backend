using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Admin, int, Admin> AdminDataAccess()
        {
            return new AdminRepo();
        }

        public static IRepo<User, int, User> UserDataAccess()
        {
            return new UserRepo();
        }

        public static IRepo<Customer,int, Customer> CustomerDataAccess()
        {
            return new CustomerRepo();
        }

        public static IRepo<Order, int, Order> OrderDataAccess()
        {
            return new OrderRepo();
        }
    }
}
