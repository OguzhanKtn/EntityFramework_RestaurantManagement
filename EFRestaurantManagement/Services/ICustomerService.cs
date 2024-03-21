using EFRestaurantManagement.Models.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurantManagement.Services
{
    public interface ICustomerService
    {
        public void CustomerAdd(Customer customer);
        public List<Customer> GetAll();
        public void CustomerUpdate (Customer customer);
        public void CustomerDelete (int id);
    }
}
