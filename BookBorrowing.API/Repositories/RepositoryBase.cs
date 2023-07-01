using BookBorrowing.API.Interfaces;
using BookBorrowing.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookBorrowing.API.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T> where T : class
    {
        private readonly BookBorrowingContext _context;
        private readonly bool _saveChanges;

        public RepositoryBase(BookBorrowingContext context, bool saveChanges)
        {
            _context = context;
            _saveChanges = saveChanges;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            if (_saveChanges)
                _context.SaveChanges();
        }

        public async Task<IEnumerable<T>> ReadAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> ReadById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            if (_saveChanges)
                _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            if (_saveChanges)
                _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = ReadById(id);
            if (entity != null)
                Delete(entity.Result);
        }

        public async Task<bool> SaveChanges()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
