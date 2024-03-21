

using System.ComponentModel.DataAnnotations.Schema;

namespace EFRestaurantManagement.Models.ORM
{
    [Table("Orders")]
    public class Order : BaseModel
    {
        public int? ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        public int? MenuId { get; set; }
        public Menu Menu { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public int Quantity { get; set; }
    }
}
