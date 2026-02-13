using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KAShop.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Column("varchar(50)")]
        [Required]
        [MinLength(1)]
        [MaxLength(30)]
        public string Name { get; set; }

        public List<Product> products { get; set; }
    }
}
