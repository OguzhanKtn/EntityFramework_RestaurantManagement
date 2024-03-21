using EFRestaurantManagement.Models.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurantManagement.Services
{
    public class MenuService : IMenuService
    {
        RestaurantContext db = new RestaurantContext();
        public void Add(Menu menu)
        {
            db.Menus.Add(menu);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Menu menu = db.Menus.Find(id)!;
            db.Menus.Remove(menu);
            db.SaveChanges();
        }

        public List<Menu> GetAll()
        {
            List<Menu> menus = db.Menus.ToList();
            return menus;
        }

        public void Update(Menu menu)
        {
            Menu updatedMenu = db.Menus.Find(menu.Id)!;
            updatedMenu.Price = menu.Price;
            db.SaveChanges();
        }
    }
}
