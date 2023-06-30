using BookBorrowing.API.Repositories;

namespace BookBorrowing.API.Services
{
    public class BookServices
    {
        public RepositoryBook _repositoryBook { get; set; }

        public BookServices()
        {
            _repositoryBook = new RepositoryBook();
        }
    }
}
