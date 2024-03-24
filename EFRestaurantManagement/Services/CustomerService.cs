using EFRestaurantManagement.Models.ORM;
using System.Reflection.Metadata.Ecma335;


namespace EFRestaurantManagement.Services
{
    public class CustomerService : IBaseService<Customer>
    {
        RestaurantContext db = new RestaurantContext();
        public void Add(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Customer customer = db.Customers.Find(id)!;
            customer.IsDeleted = true;
            db.SaveChanges();
        }

        public void Update(Customer customer)
        {
            Customer cstmr = db.Customers.Find(customer.Id)!;
            cstmr.Email = customer.Email;
            cstmr.Phone = customer.Phone;
            cstmr.Adress = customer.Adress;

            db.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = db.Customers.Where(x=> x.IsDeleted == false).ToList();
            
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
