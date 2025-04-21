namespace BookManagerAPI.Entities
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        //Navigation properties
        public int? categoryId { get; set; }
        public category Category { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
