using BookBorrowing.API.Repositories;

namespace BookBorrowing.API.Services
{
    public class BorrowingServices
    {
        public RepositoryBorrowing _repositoryBorrowing { get; set; }

        public BorrowingServices()
        {
            _repositoryBorrowing = new RepositoryBorrowing();
        }
    }
}
