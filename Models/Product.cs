using System.ComponentModel.DataAnnotations;

namespace KAShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MinLength(4)]
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(1,10000)]
        public decimal Price { get; set; }
        public double Rate { get; set; }

        [Display(Name="Category")]
        public Category Category { get; set; }

        public string? Image {  get; set; }
        public int categoryID { get; set; }
    }
}
