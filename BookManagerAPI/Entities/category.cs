using System.Collections;

namespace BookManagerAPI.Entities
{
    public class category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation properties
        public ICollection Books { get; set; } 
    }
}
