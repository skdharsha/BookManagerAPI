using BookManagerAPI.Repository;

namespace BookManagerAPI.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepo bookRepo;

        public BookService(IBookRepo bookRepo)
        {
            this.bookRepo = bookRepo;
        }
    }
}
