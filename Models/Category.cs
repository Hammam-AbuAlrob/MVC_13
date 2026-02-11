using System.ComponentModel.DataAnnotations.Schema;

namespace KAShop.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Column("varchar(50)")]
        public string Name { get; set; }
    }
}
