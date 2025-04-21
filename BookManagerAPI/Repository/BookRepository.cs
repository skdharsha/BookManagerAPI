using BookManagerAPI.DB;

namespace BookManagerAPI.Repository
{
    public class BookRepository : IBookRepo
    {
        private readonly BookDB bookDB;

        public BookRepository(BookDB bookDB)
        {
            this.bookDB = bookDB;
        }
    }
}
