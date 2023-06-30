using BookBorrowing.API.Interfaces;
using BookBorrowing.API.Models;

namespace BookBorrowing.API.Repositories
{
    public class RepositoryClient : RepositoryBase<Client>, IRepositoryClient
    {
        public RepositoryClient(BookBorrowingContext context, bool saveChanges) : base(context, saveChanges)
        {
        }
    }
}
