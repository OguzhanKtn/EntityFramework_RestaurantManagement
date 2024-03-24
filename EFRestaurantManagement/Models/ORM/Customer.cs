
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFRestaurantManagement.Models.ORM
{
    [Table("Customers")]
    public class Customer : BaseModel
    {
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        public string? Adress { get; set; }

        public string FullName => $"{Name} {Surname}";
    }
}
