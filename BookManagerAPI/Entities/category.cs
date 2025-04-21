using System.Collections;

namespace BookManagerAPI.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation properties
        public ICollection <Books> Books{ get; set; } 
    }
}
