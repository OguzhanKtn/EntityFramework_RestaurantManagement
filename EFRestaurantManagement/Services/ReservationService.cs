using EFRestaurantManagement.Models.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurantManagement.Services
{
    public class ReservationService : IBaseService<Reservation>
    {
        RestaurantContext db = new RestaurantContext();
        public void Add(Reservation item)
        {
            db.Reservations.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Reservation reservation = db.Reservations.Find(id)!;
            reservation.IsDeleted = true;
            db.SaveChanges();
        }

        public List<Reservation> GetAll()
        {
            return db.Reservations.Where(x=> x.IsDeleted == false).ToList();
        }

        public void Update(Reservation item)
        {
            Reservation reservation = db.Reservations.Find(item.Id)!;
            reservation.Note = item.Note;
            reservation.ReservationDate = item.ReservationDate;

            db.SaveChanges();
        }
    }
}
