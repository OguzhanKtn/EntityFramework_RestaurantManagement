using System.ComponentModel.DataAnnotations.Schema;


namespace EFRestaurantManagement.Models.ORM
{
    [Table("Reservations")]
    public class Reservation:BaseModel
    {
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}
