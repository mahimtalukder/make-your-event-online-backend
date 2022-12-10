using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class OrderRepo : Repo, IRepo<Order, int, Order>
    {
        public Order Add(Order obj)
        {
            db.Orders.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var DBUser = Get(id);
            db.Orders.Remove(DBUser);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Order> Get()
        {
            return db.Orders.ToList();
        }

        public Order Get(int id)
        {
            var DBUser = db.Orders.SingleOrDefault(x => x.Id == id);
            if (DBUser != null)
            {
                return DBUser;
            }
            return null;
        }

        public Order Update(Order obj)
        {
            var DBUser = Get(obj.Id);
            db.Entry(DBUser).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
            throw new NotImplementedException();
        }
    }
}
