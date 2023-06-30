using BookBorrowing.API.Repositories;

namespace BookBorrowing.API.Services
{
    public class ClientServices
    {
        public RepositoryClient _repositoryClient { get; set; }

        public ClientServices()
        {
            _repositoryClient = new RepositoryClient();
        }
    }
}
