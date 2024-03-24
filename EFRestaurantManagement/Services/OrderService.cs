using EFRestaurantManagement.Models.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurantManagement.Services
{
    public class OrderService : IBaseService<Order>
    {
        RestaurantContext db = new RestaurantContext();
        public void Add(Order item)
        {
            db.Orders.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Order order = db.Orders.Find(id);
            order.IsDeleted = true;
            db.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return db.Orders.Where(o => o.IsDeleted == false).ToList();
        }

        public void Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
