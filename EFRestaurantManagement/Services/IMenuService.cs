using EFRestaurantManagement.Models.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurantManagement.Services
{
    public interface IMenuService
    {
        public void Add(Menu menu);
        public void Delete(int id);
        public void Update(Menu menu);
        public List<Menu> GetAll();
        
    }
}
