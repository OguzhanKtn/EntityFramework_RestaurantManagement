using EFRestaurantManagement.Models.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurantManagement.Services
{
    public interface IBaseService<T>
    {
        public void Add(T item);
        public List<T> GetAll();
        public void Update(T item);
        public void Delete(int id);
    }
}
