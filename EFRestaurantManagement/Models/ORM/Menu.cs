
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFRestaurantManagement.Models.ORM
{
    [Table("Menus")]
    public class Menu : BaseModel
    {
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }
        public decimal Price { get; set; }

        public string MenuDetail => $"{Title}-{Description}";
    }
}
