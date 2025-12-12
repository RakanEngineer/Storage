using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(20, ErrorMessage = "Max 20")] 
        public string Name { get; set; }
        [Range(1, 999)] 
        public decimal Price { get; set; }
        [DataType(DataType.Date)] 
        public DateTime Orderdate { get; set; }
        [StringLength(10, ErrorMessage = "Max 10")]        
        public string Category { get; set; }
        [StringLength(10, ErrorMessage = "Max 10")]
        public string Shelf { get; set; }
        [Range(0, 10000)]
        public int Count { get; set; }
        [StringLength(500, ErrorMessage = "Max 500")]
        public string Description { get; set; }

    }
}
