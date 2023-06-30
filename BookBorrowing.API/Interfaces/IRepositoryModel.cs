namespace BookBorrowing.API.Interfaces
{
    public interface IRepositoryModel<T> where T : class
    {
        void Create(T entity);
        Task<IEnumerable<T>> ReadAll();
        Task<T> ReadById(int id);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(int id);
        void SaveChanges();
    }
}
