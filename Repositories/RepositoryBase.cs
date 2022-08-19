using APICatalogo.Context;
using APICatalogo.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly AppDbContext _contex;

        public RepositoryBase(AppDbContext context)
        {
            _contex = context;
        }

        public void Add(T entity)
        {
            _contex.Add(entity);
            _contex.SaveChanges();
        }

        public void Delete(T entity)
        {
            _contex.Remove(entity);
        }

        public List<T> GetAll()
        {
            return _contex.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _contex.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _contex.Entry(entity).State = EntityState.Modified;
            _contex.SaveChanges();
        }
    }

}
