using RentalTest.Interfaces;

namespace RentalTest.Models
{
    public class CategoryModel : ICategory
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
