using BookBorrowing.API.Models;
using BookBorrowing.API.Repositories;

namespace BookBorrowing.API.Services
{
    public class BookServices
    {
        public RepositoryBook _repositoryBook { get; set; }

        public BookServices(BookBorrowingContext context)
        {
            _repositoryBook = new RepositoryBook(context);
        }
    }
}
