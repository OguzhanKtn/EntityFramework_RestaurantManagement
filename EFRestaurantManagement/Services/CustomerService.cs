using EFRestaurantManagement.Models.ORM;
using System.Reflection.Metadata.Ecma335;


namespace EFRestaurantManagement.Services
{
    public class CustomerService : ICustomerService
    {
        RestaurantContext db = new RestaurantContext();
        public void CustomerAdd(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public void CustomerDelete(int id)
        {
            Customer customer = db.Customers.Find(id)!;
            db.Customers.Remove(customer);
            db.SaveChanges();
        }

        public void CustomerUpdate(Customer customer)
        {
            Customer cstmr = db.Customers.Find(customer.Id)!;
            cstmr.Email = customer.Email;
            cstmr.Phone = customer.Phone;
            cstmr.Adress = customer.Adress;

            db.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = db.Customers.ToList();
            
           if(customers.Count > 0)
            {
                return customers;
            }

            else
            {
                return null;
            }
        }
    }
}
