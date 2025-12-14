using Microsoft.AspNetCore.Mvc.Rendering;

namespace Storage.Models
{
    public class ProductSearchViewModel
    {
        public string? Category { get; set; }
        public string? SearchName { get; set; }

        public IEnumerable<SelectListItem>? Categories { get; set; }
        public IEnumerable<Product>? Products { get; set; }
    }
}