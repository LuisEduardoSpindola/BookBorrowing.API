using BookBorrowing.API.Models;
using BookBorrowing.API.Repositories;

namespace BookBorrowing.API.Services
{
    public class BorrowingServices
    {
        public RepositoryBorrowing _repositoryBorrowing { get; set; }

        public BorrowingServices(BookBorrowingContext context)
        {
            _repositoryBorrowing = new RepositoryBorrowing(context);
        }
    }
}
