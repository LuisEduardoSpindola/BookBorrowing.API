using BookBorrowing.API.Models;
using BookBorrowing.API.Repositories;

namespace BookBorrowing.API.Services
{
    public class ClientServices
    {
        public RepositoryClient _repositoryClient { get; set; }

        public ClientServices(BookBorrowingContext context)
        {
            _repositoryClient = new RepositoryClient(context);
        }
    }
}
