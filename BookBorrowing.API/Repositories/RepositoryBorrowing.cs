using BookBorrowing.API.Interfaces;
using BookBorrowing.API.Models;

namespace BookBorrowing.API.Repositories
{
    public class RepositoryBorrowing : RepositoryBase<Borrowing>, IRepositoryBorrowing
    {
        public RepositoryBorrowing(BookBorrowingContext context, bool saveChanges) : base(context, saveChanges)
        {
        }
    }
}
