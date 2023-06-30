using BookBorrowing.API.Interfaces;
using BookBorrowing.API.Models;

namespace BookBorrowing.API.Repositories
{
    public class RepositoryBook : RepositoryBase<Book>, IRepositoryBook
    {
        public RepositoryBook(BookBorrowingContext context, bool saveChanges) : base(context, saveChanges)
        {
        }
    }
}
